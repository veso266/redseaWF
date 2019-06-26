namespace redseaWF
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
        	this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
        	this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
        	this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        	this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        	this.msgControl3 = new redseaWF.MsgControl();
        	this.msgControl2 = new redseaWF.MsgControl();
        	this.msgControl1 = new redseaWF.MsgControl();
        	this.msgControl4 = new redseaWF.MsgControl();
        	this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        	this.label1 = new System.Windows.Forms.Label();
        	this.buttonSet = new System.Windows.Forms.Button();
        	this.label4 = new System.Windows.Forms.Label();
        	this.labelPI = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.labelStationName = new System.Windows.Forms.Label();
        	this.groupControl = new redseaWF.GroupControl();
        	this.statusStrip1 = new System.Windows.Forms.StatusStrip();
        	this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
        	this.tableLayoutPanel1.SuspendLayout();
        	this.tableLayoutPanel3.SuspendLayout();
        	this.tableLayoutPanel2.SuspendLayout();
        	this.statusStrip1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// numericUpDown1
        	// 
        	this.numericUpDown1.DecimalPlaces = 1;
        	this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Right;
        	this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.numericUpDown1.Increment = new decimal(new int[] {
			1,
			0,
			0,
			65536});
        	this.numericUpDown1.Location = new System.Drawing.Point(3, 3);
        	this.numericUpDown1.Maximum = new decimal(new int[] {
			1095,
			0,
			0,
			65536});
        	this.numericUpDown1.Minimum = new decimal(new int[] {
			805,
			0,
			0,
			65536});
        	this.numericUpDown1.Name = "numericUpDown1";
        	this.numericUpDown1.Size = new System.Drawing.Size(72, 29);
        	this.numericUpDown1.TabIndex = 1;
        	this.numericUpDown1.Value = new decimal(new int[] {
			1000,
			0,
			0,
			65536});
        	// 
        	// numericUpDown2
        	// 
        	this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.numericUpDown2.Location = new System.Drawing.Point(334, 3);
        	this.numericUpDown2.Name = "numericUpDown2";
        	this.numericUpDown2.Size = new System.Drawing.Size(40, 20);
        	this.numericUpDown2.TabIndex = 2;
        	// 
        	// tableLayoutPanel1
        	// 
        	this.tableLayoutPanel1.ColumnCount = 1;
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 663F));
        	this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
        	this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
        	this.tableLayoutPanel1.Controls.Add(this.groupControl, 0, 1);
        	this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        	this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        	this.tableLayoutPanel1.RowCount = 3;
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
        	this.tableLayoutPanel1.Size = new System.Drawing.Size(663, 466);
        	this.tableLayoutPanel1.TabIndex = 3;
        	// 
        	// tableLayoutPanel3
        	// 
        	this.tableLayoutPanel3.ColumnCount = 4;
        	this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        	this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        	this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        	this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        	this.tableLayoutPanel3.Controls.Add(this.msgControl3, 2, 0);
        	this.tableLayoutPanel3.Controls.Add(this.msgControl2, 1, 0);
        	this.tableLayoutPanel3.Controls.Add(this.msgControl1, 0, 0);
        	this.tableLayoutPanel3.Controls.Add(this.msgControl4, 3, 0);
        	this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 131);
        	this.tableLayoutPanel3.Name = "tableLayoutPanel3";
        	this.tableLayoutPanel3.RowCount = 1;
        	this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel3.Size = new System.Drawing.Size(657, 332);
        	this.tableLayoutPanel3.TabIndex = 4;
        	// 
        	// msgControl3
        	// 
        	this.msgControl3.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.msgControl3.Location = new System.Drawing.Point(331, 3);
        	this.msgControl3.Name = "msgControl3";
        	this.msgControl3.Size = new System.Drawing.Size(158, 326);
        	this.msgControl3.TabIndex = 9;
        	// 
        	// msgControl2
        	// 
        	this.msgControl2.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.msgControl2.Location = new System.Drawing.Point(167, 3);
        	this.msgControl2.Name = "msgControl2";
        	this.msgControl2.Size = new System.Drawing.Size(158, 326);
        	this.msgControl2.TabIndex = 10;
        	// 
        	// msgControl1
        	// 
        	this.msgControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.msgControl1.Location = new System.Drawing.Point(3, 3);
        	this.msgControl1.Name = "msgControl1";
        	this.msgControl1.Size = new System.Drawing.Size(158, 326);
        	this.msgControl1.TabIndex = 11;
        	// 
        	// msgControl4
        	// 
        	this.msgControl4.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.msgControl4.Location = new System.Drawing.Point(495, 3);
        	this.msgControl4.Name = "msgControl4";
        	this.msgControl4.Size = new System.Drawing.Size(159, 326);
        	this.msgControl4.TabIndex = 12;
        	// 
        	// tableLayoutPanel2
        	// 
        	this.tableLayoutPanel2.ColumnCount = 8;
        	this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        	this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        	this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        	this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        	this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        	this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        	this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
        	this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 266F));
        	this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
        	this.tableLayoutPanel2.Controls.Add(this.numericUpDown1, 0, 0);
        	this.tableLayoutPanel2.Controls.Add(this.buttonSet, 7, 0);
        	this.tableLayoutPanel2.Controls.Add(this.numericUpDown2, 6, 0);
        	this.tableLayoutPanel2.Controls.Add(this.label4, 5, 0);
        	this.tableLayoutPanel2.Controls.Add(this.labelPI, 4, 0);
        	this.tableLayoutPanel2.Controls.Add(this.label2, 3, 0);
        	this.tableLayoutPanel2.Controls.Add(this.labelStationName, 2, 0);
        	this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
        	this.tableLayoutPanel2.Name = "tableLayoutPanel2";
        	this.tableLayoutPanel2.RowCount = 1;
        	this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel2.Size = new System.Drawing.Size(657, 34);
        	this.tableLayoutPanel2.TabIndex = 4;
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Dock = System.Windows.Forms.DockStyle.Left;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(81, 0);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(50, 34);
        	this.label1.TabIndex = 7;
        	this.label1.Text = "MHz.";
        	// 
        	// buttonSet
        	// 
        	this.buttonSet.Dock = System.Windows.Forms.DockStyle.Right;
        	this.buttonSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.buttonSet.Location = new System.Drawing.Point(608, 3);
        	this.buttonSet.Name = "buttonSet";
        	this.buttonSet.Size = new System.Drawing.Size(46, 28);
        	this.buttonSet.TabIndex = 10;
        	this.buttonSet.Text = "Set";
        	this.buttonSet.UseVisualStyleBackColor = true;
        	this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label4.Location = new System.Drawing.Point(280, 0);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(48, 13);
        	this.label4.TabIndex = 6;
        	this.label4.Text = "Rx Gain:";
        	// 
        	// labelPI
        	// 
        	this.labelPI.AutoSize = true;
        	this.labelPI.Dock = System.Windows.Forms.DockStyle.Left;
        	this.labelPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.labelPI.Location = new System.Drawing.Point(235, 0);
        	this.labelPI.Name = "labelPI";
        	this.labelPI.Size = new System.Drawing.Size(39, 34);
        	this.labelPI.TabIndex = 5;
        	this.labelPI.Text = "0000";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Dock = System.Windows.Forms.DockStyle.Right;
        	this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.Location = new System.Drawing.Point(209, 0);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(20, 34);
        	this.label2.TabIndex = 4;
        	this.label2.Text = "PI:";
        	// 
        	// labelStationName
        	// 
        	this.labelStationName.AutoSize = true;
        	this.labelStationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.labelStationName.Location = new System.Drawing.Point(137, 0);
        	this.labelStationName.Name = "labelStationName";
        	this.labelStationName.Size = new System.Drawing.Size(66, 24);
        	this.labelStationName.TabIndex = 11;
        	this.labelStationName.Text = "--------";
        	// 
        	// groupControl
        	// 
        	this.groupControl.Location = new System.Drawing.Point(3, 43);
        	this.groupControl.Name = "groupControl";
        	this.groupControl.Size = new System.Drawing.Size(597, 78);
        	this.groupControl.TabIndex = 5;
        	// 
        	// statusStrip1
        	// 
        	this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel});
        	this.statusStrip1.Location = new System.Drawing.Point(0, 444);
        	this.statusStrip1.Name = "statusStrip1";
        	this.statusStrip1.Size = new System.Drawing.Size(663, 22);
        	this.statusStrip1.TabIndex = 4;
        	this.statusStrip1.Text = "statusStrip1";
        	// 
        	// toolStripStatusLabel
        	// 
        	this.toolStripStatusLabel.Name = "toolStripStatusLabel";
        	this.toolStripStatusLabel.Size = new System.Drawing.Size(56, 17);
        	this.toolStripStatusLabel.Text = "radiotext:";
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(663, 466);
        	this.Controls.Add(this.statusStrip1);
        	this.Controls.Add(this.tableLayoutPanel1);
        	this.Name = "Form1";
        	this.Text = "redseaWF";
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        	this.Load += new System.EventHandler(this.Form1Load);
        	((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
        	this.tableLayoutPanel1.ResumeLayout(false);
        	this.tableLayoutPanel3.ResumeLayout(false);
        	this.tableLayoutPanel2.ResumeLayout(false);
        	this.tableLayoutPanel2.PerformLayout();
        	this.statusStrip1.ResumeLayout(false);
        	this.statusStrip1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private redseaWF.MsgControl msgControl3;
        private redseaWF.MsgControl msgControl2;
        private redseaWF.MsgControl msgControl1;
        private redseaWF.MsgControl msgControl4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private GroupControl groupControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Label labelStationName;
    }
}

