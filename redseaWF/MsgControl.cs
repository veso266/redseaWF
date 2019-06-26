using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace redseaWF
{
	public partial class MsgControl : UserControl
	{
		int counter;
    	
		public MsgControl()
		{
			InitializeComponent();
			counter = 0;
		}
        
		void updateCounter()
		{
			counter++;
			labelCounter.Text = counter.ToString();
		}

		public RichTextBox mirichtextbox {
			set	{ }
			get {
				updateCounter();
				return richTextBox1;
			}
		}
          
		public ComboBox micombobox {
			set	{ }
			get{ return comboBox1; }
		}

		public string GroupComboBoxText { set; get; }
		
		public void setComboBoxText ()
		{
			comboBox1.Text = GroupComboBoxText;
		}
		
		private void buttonClear_Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
			counter = 0;
			labelCounter.Text = "-----";
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			GroupComboBoxText = comboBox1.Text;
		}
	}
}
