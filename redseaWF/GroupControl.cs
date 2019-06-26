using System;
using System.Drawing;
using System.Windows.Forms;

namespace redseaWF
{
	/// <summary>
	/// Description of groupControl.
	/// </summary>
	public partial class GroupControl : UserControl
	{
		public Label[][] labGroup = new Label[16][];
		
		public int[,] labelTime = new int[16, 2];
		
		private void createLabels()
		{
			int spacing = 35;
			int columns = 16;

			//Label[][] labGroup = new Label[columns][];

			for (int i = 0; i < columns; i++) {
				//Create a new sub array
				labGroup[i] = new Label[columns];
				for (int j = 0; j < 2; j++) {
					labGroup[i][j] = new Label();
					labGroup[i][j].AutoSize = true;
					labGroup[i][j].BackColor = Color.LightGray;
					labGroup[i][j].ForeColor = Color.White;
					labGroup[i][j].Location = new Point(20 + i * spacing, 25 + j * 20);
					labGroup[i][j].Name = "group" + i.ToString() + "," + j.ToString();
					labGroup[i][j].Width = spacing;
					labGroup[i][j].Height = spacing;
					labGroup[i][j].TabIndex = 0;
						
					if(j==0)
						labGroup[i][j].Text =  i.ToString() + "A";
					else
						labGroup[i][j].Text =  i.ToString() + "B";
				}
				this.Controls.AddRange(labGroup[i]);
			}
		}
		
		public GroupControl()
		{
			InitializeComponent();
		}
		void GroupControlLoad(object sender, EventArgs e)
		{
			createLabels();
			groupBox1.SendToBack();
		}

		void Timer1Tick(object sender, EventArgs e)
		{
			for (int i = 0; i < 16; i++)
			{
				for (int j = 0; j < 2; j++) 
				{
					if(labelTime[i,j]==1)
						labGroup[i][j].ForeColor = Color.White;
					
					if(labelTime[i,j] > 0)
						labelTime[i,j]--;
					
				}
			}
		}
	}
}
