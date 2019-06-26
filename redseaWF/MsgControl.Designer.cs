namespace redseaWF
{
    partial class MsgControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
        	this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        	this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        	this.comboBox1 = new System.Windows.Forms.ComboBox();
        	this.labelCounter = new System.Windows.Forms.Label();
        	this.buttonClear = new System.Windows.Forms.Button();
        	this.richTextBox1 = new System.Windows.Forms.RichTextBox();
        	this.tableLayoutPanel1.SuspendLayout();
        	this.tableLayoutPanel2.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// tableLayoutPanel1
        	// 
        	this.tableLayoutPanel1.ColumnCount = 1;
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
        	this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 0, 0);
        	this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        	this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        	this.tableLayoutPanel1.RowCount = 2;
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
        	this.tableLayoutPanel1.Size = new System.Drawing.Size(255, 536);
        	this.tableLayoutPanel1.TabIndex = 0;
        	// 
        	// tableLayoutPanel2
        	// 
        	this.tableLayoutPanel2.ColumnCount = 3;
        	this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
        	this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        	this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        	this.tableLayoutPanel2.Controls.Add(this.comboBox1, 0, 0);
        	this.tableLayoutPanel2.Controls.Add(this.labelCounter, 1, 0);
        	this.tableLayoutPanel2.Controls.Add(this.buttonClear, 2, 0);
        	this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 485);
        	this.tableLayoutPanel2.Name = "tableLayoutPanel2";
        	this.tableLayoutPanel2.RowCount = 1;
        	this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel2.Size = new System.Drawing.Size(249, 48);
        	this.tableLayoutPanel2.TabIndex = 1;
        	// 
        	// comboBox1
        	// 
        	this.comboBox1.Dock = System.Windows.Forms.DockStyle.Left;
        	this.comboBox1.DropDownHeight = 120;
        	this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.comboBox1.FormattingEnabled = true;
        	this.comboBox1.IntegralHeight = false;
        	this.comboBox1.Items.AddRange(new object[] {
			"0A",
			"1A",
			"2A",
			"3A",
			"4A",
			"5A",
			"6A",
			"7A",
			"8A",
			"9A",
			"10A",
			"11A",
			"12A",
			"13A",
			"14A",
			"15A",
			"0B",
			"1B",
			"2B",
			"3B",
			"4B",
			"5B",
			"6B",
			"7B",
			"8B",
			"9B",
			"10B",
			"11B",
			"12B",
			"13B",
			"14B",
			"15B"});
        	this.comboBox1.Location = new System.Drawing.Point(3, 3);
        	this.comboBox1.Name = "comboBox1";
        	this.comboBox1.Size = new System.Drawing.Size(51, 21);
        	this.comboBox1.TabIndex = 2;
        	this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
        	// 
        	// labelCounter
        	// 
        	this.labelCounter.AutoSize = true;
        	this.labelCounter.Location = new System.Drawing.Point(60, 0);
        	this.labelCounter.Name = "labelCounter";
        	this.labelCounter.Size = new System.Drawing.Size(22, 13);
        	this.labelCounter.TabIndex = 6;
        	this.labelCounter.Text = "-----";
        	// 
        	// buttonClear
        	// 
        	this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.buttonClear.Location = new System.Drawing.Point(88, 3);
        	this.buttonClear.Name = "buttonClear";
        	this.buttonClear.Size = new System.Drawing.Size(41, 21);
        	this.buttonClear.TabIndex = 3;
        	this.buttonClear.Text = "Clear";
        	this.buttonClear.UseVisualStyleBackColor = true;
        	this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
        	// 
        	// richTextBox1
        	// 
        	this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.richTextBox1.Location = new System.Drawing.Point(3, 3);
        	this.richTextBox1.Name = "richTextBox1";
        	this.richTextBox1.Size = new System.Drawing.Size(249, 476);
        	this.richTextBox1.TabIndex = 2;
        	this.richTextBox1.Text = "";
        	// 
        	// MsgControl
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.Controls.Add(this.tableLayoutPanel1);
        	this.Name = "MsgControl";
        	this.Size = new System.Drawing.Size(255, 536);
        	this.tableLayoutPanel1.ResumeLayout(false);
        	this.tableLayoutPanel2.ResumeLayout(false);
        	this.tableLayoutPanel2.PerformLayout();
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelCounter;
    }
}
