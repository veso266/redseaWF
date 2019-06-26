using System;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using Jot.DefaultInitializer;

namespace redseaWF
{
	public partial class Form1 : Form
	{
		Process proc;
    	
		[Trackable]
		public Decimal Frequency {
			get { return numericUpDown1.Value; }
			set { numericUpDown1.Value = value; }
		}
		
		[Trackable]
		public int Gain {
			get { return (int)numericUpDown2.Value; }
			set { numericUpDown2.Value = value; }
		}
    	
        [Trackable]
        public string GroupComboBox1
        {
        	get { return MsgControl1.GroupComboBoxText; }
        	set { MsgControl1.GroupComboBoxText = value; }
        }		
		
        [Trackable]
        public string GroupComboBox2
        {
        	get { return MsgControl2.GroupComboBoxText; }
        	set { MsgControl2.GroupComboBoxText = value; }
        }	

        [Trackable]
        public string GroupComboBox3
        {
        	get { return MsgControl3.GroupComboBoxText; }
        	set { MsgControl3.GroupComboBoxText = value; }
        }	
        
       [Trackable]
        public string GroupComboBox4
        {
        	get { return MsgControl4.GroupComboBoxText; }
        	set { MsgControl4.GroupComboBoxText = value; }
        }		
		
		public MsgControl MsgControl1{ get { return this.msgControl1; } set { } }
		public MsgControl MsgControl2{ get { return this.msgControl2; } set { } }
		public MsgControl MsgControl3{ get { return this.msgControl3; } set { } }
		public MsgControl MsgControl4{ get { return this.msgControl4; } set { } }
		public Label LabelPI{ get { return this.labelPI; } set { } }
		public Label LabelStationName{ get { return this.labelStationName; } set { } }
		public ToolStripLabel TSLabel{ get { return this.toolStripStatusLabel; } set { } }
		public GroupControl GControl{ get { return this.groupControl; } set { } }
 		
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (proc != null) {
				Helper.StopProgramByAttachingToItsConsoleAndIssuingCtrlCEvent(proc);
			}
		}
        
		void Form1Load(object sender, EventArgs e)
		{
			//setting up Form tracking
			Services.Tracker.Configure(this).Apply();
			
			this.msgControl1.setComboBoxText();
			this.msgControl2.setComboBoxText();
			this.msgControl3.setComboBoxText();
			this.msgControl4.setComboBoxText();
		}

		private void buttonSet_Click(object sender, EventArgs e)
		{
			if (proc != null) {
				Helper.StopProgramByAttachingToItsConsoleAndIssuingCtrlCEvent(proc);
			}		
			TSLabel.Text = "radiotext:";
			Helper.lastPS = "";			
			LabelStationName.Text = "--------";
			Helper.lastPI = "";
			LabelPI.Text = "0000";
			Helper._instanceForm = this;
			proc = Helper.StartRedseaProgram();
		}
	}
}
