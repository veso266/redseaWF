using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace redseaWF
{
	public static class Helper
	{
		#region pinvoke
		[DllImport("kernel32.dll", SetLastError = true)]
		static extern bool AttachConsole(uint dwProcessId);

		[DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
		static extern bool FreeConsole();

		[DllImport("kernel32.dll")]
		static extern bool SetConsoleCtrlHandler(ConsoleCtrlDelegate HandlerRoutine, bool Add);
		// Delegate type to be used as the Handler Routine for SCCH
		delegate Boolean ConsoleCtrlDelegate(CtrlTypes CtrlType);

		// Enumerated type for the control messages sent to the handler routine
		enum CtrlTypes : uint
		{
			CTRL_C_EVENT = 0,
			CTRL_BREAK_EVENT,
			CTRL_CLOSE_EVENT,
			CTRL_LOGOFF_EVENT = 5,
			CTRL_SHUTDOWN_EVENT
		}
		
		[DllImport("kernel32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool GenerateConsoleCtrlEvent(CtrlTypes dwCtrlEvent, uint dwProcessGroupId);

		private const int WM_VSCROLL = 277;
		private const int SB_BOTTOM = 7;

		[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessage")]
		private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
		
		private const int VK_CONTROL = 0x11;
		private const int WM_KEYDOWN = 0x100;
		private const int WM_CHAR = 0x102;
		private const int WM_KEYUP = 0x101;
		private const int VK_CANCEL = 0x03;
		private const int VK_C = 0x0043;
		#endregion pinvoke

		public static Form1 _instanceForm;

		public static string lastPI;
		public static string lastPS;
		
		public static Process StartRedseaProgram()
		{
			string sep = ".";
			NumberFormatInfo nfi = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
			nfi.NumberDecimalSeparator = sep;
			
			string sFreq = _instanceForm.Frequency.ToString(nfi);
			string sGain = _instanceForm.Gain.ToString();
			
			File.WriteAllText("run_redsea.cmd", "rtl_fm -M fm -l 0 -A std -p 0 -s 171k -g " + sGain + " -F 9 -f " + sFreq + "M | redsea");
			
			Process RunningRrocess = new Process();
			try {
				RunningRrocess.StartInfo.WorkingDirectory = "";
				RunningRrocess.StartInfo.FileName = "run_redsea.cmd";
				RunningRrocess.StartInfo.Arguments = "< NUL";
				RunningRrocess.StartInfo.CreateNoWindow = true;
				RunningRrocess.StartInfo.UseShellExecute = false;
				RunningRrocess.StartInfo.RedirectStandardError = true;
				RunningRrocess.StartInfo.RedirectStandardOutput = true;
				RunningRrocess.StartInfo.RedirectStandardInput = true;
				RunningRrocess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				RunningRrocess.OutputDataReceived += (origin, args) => WriteTextAsync(args.Data);
				RunningRrocess.ErrorDataReceived += (origin, args) => WriteTextAsync(args.Data);
				RunningRrocess.Start();
				RunningRrocess.BeginOutputReadLine();
				RunningRrocess.BeginErrorReadLine();
			} catch (Exception) {
			}
			return RunningRrocess;
		}

		public static void StopProgramByAttachingToItsConsoleAndIssuingCtrlCEvent(Process proc)
		{
			//This does not require the console window to be visible.
			if (AttachConsole((uint)proc.Id)) {
				//Disable Ctrl-C handling for our program
				SetConsoleCtrlHandler(null, true);
				GenerateConsoleCtrlEvent(CtrlTypes.CTRL_C_EVENT, 0);
				
				//Must wait here. If we don't and re-enable Ctrl-C handling below too fast, we might terminate ourselves.
				proc.WaitForExit();
				
				FreeConsole();
				
				//Re-enable Ctrl-C handling or any subsequently started programs will inherit the disabled state.
				SetConsoleCtrlHandler(null, false);
			}
		}


		private static void dispGC(string text)
		{
			int colu = 0;
			int row = 0;
			
			if (Int32.TryParse(text.TrimEnd('A', 'B'), out colu) == false)
				return;
			
			if (text.EndsWith("B"))
				row = 1;
			else
				row = 0;
			
			_instanceForm.GControl.labGroup[colu][row].ForeColor = System.Drawing.Color.Black;
			
			_instanceForm.GControl.labelTime[colu, row] = 15;
		}
		
		
		private static void dispRT(string text)
		{
			_instanceForm.TSLabel.Text = "radiotext:        " + text;
		}

		private static void dispPI(string text)
		{
			if (text != lastPI)
				_instanceForm.LabelPI.Text = text.Substring(2);
			lastPI = text;
		}
		
		private static void dispPS(string text)
		{
			if (text != lastPS)
				_instanceForm.LabelStationName.Text = text;
			lastPS = text;
		}
		
		private static void WriteOnRichTextBox(string text, RichTextBox RTB)
		{
			Action action = () => {
				RTB.AppendText(text + Environment.NewLine);
				IntPtr ptrWparam = new IntPtr(SB_BOTTOM);
				IntPtr ptrLparam = new IntPtr(0);
				SendMessage(RTB.Handle, WM_VSCROLL, ptrWparam, ptrLparam);
			};
			RTB.BeginInvoke(action, null);
		}

		private static void WriteTextAsync(string text)
		{
			if (text != null) {
				try {
					text = Encoding.UTF8.GetString(Encoding.Default.GetBytes(text));
					
					dynamic results = JObject.Parse(text);
				
					text = results.ToString(Formatting.Indented);
					
					if (results.group == _instanceForm.MsgControl1.micombobox.Text)
						WriteOnRichTextBox(text, _instanceForm.MsgControl1.mirichtextbox);

					if (results.group == _instanceForm.MsgControl2.micombobox.Text)
						WriteOnRichTextBox(text, _instanceForm.MsgControl2.mirichtextbox);
					
					if (results.group == _instanceForm.MsgControl3.micombobox.Text)
						WriteOnRichTextBox(text, _instanceForm.MsgControl3.mirichtextbox);

					if (results.group == _instanceForm.MsgControl4.micombobox.Text)
						WriteOnRichTextBox(text, _instanceForm.MsgControl4.mirichtextbox);
					
					if (results.radiotext != null)
						dispRT(results.radiotext.ToString());
					
					if (results.group != null)
						dispGC(results.group.ToString());
					
					if (results.pi != null)
						dispPI(results.pi.ToString());
					
					if (results.ps != null)
						dispPS(results.ps.ToString());
					
				} catch {
				}
				;
			}
		}
	}
}
