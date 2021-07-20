namespace Jerry_Nava_CPT_185_Test_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Calculatebutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.clearbutton = new System.Windows.Forms.Button();
            this.autoBox = new System.Windows.Forms.ListBox();
            this.TransBox = new System.Windows.Forms.ListBox();
            this.Pricetext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.taxratetextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Transtext = new System.Windows.Forms.TextBox();
            this.subtotalbox = new System.Windows.Forms.TextBox();
            this.taxBox = new System.Windows.Forms.TextBox();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Calculatebutton
            // 
            this.Calculatebutton.Location = new System.Drawing.Point(98, 348);
            this.Calculatebutton.Margin = new System.Windows.Forms.Padding(4);
            this.Calculatebutton.Name = "Calculatebutton";
            this.Calculatebutton.Size = new System.Drawing.Size(112, 34);
            this.Calculatebutton.TabIndex = 0;
            this.Calculatebutton.Text = "&Calcluate";
            this.toolTip1.SetToolTip(this.Calculatebutton, "Click here to Calculate");
            this.Calculatebutton.UseVisualStyleBackColor = true;
            this.Calculatebutton.Click += new System.EventHandler(this.Calculatebutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitbutton.Location = new System.Drawing.Point(452, 348);
            this.exitbutton.Margin = new System.Windows.Forms.Padding(4);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(112, 34);
            this.exitbutton.TabIndex = 1;
            this.exitbutton.Text = "&Exit";
            this.toolTip1.SetToolTip(this.exitbutton, "Click Here to Exit");
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(284, 348);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(112, 34);
            this.clearbutton.TabIndex = 17;
            this.clearbutton.Text = "Cle&ar";
            this.toolTip1.SetToolTip(this.clearbutton, "Clear all the Information");
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // autoBox
            // 
            this.autoBox.FormattingEnabled = true;
            this.autoBox.ItemHeight = 19;
            this.autoBox.Items.AddRange(new object[] {
            "Lamborghini",
            "Ferrari",
            "Corvette"});
            this.autoBox.Location = new System.Drawing.Point(90, 89);
            this.autoBox.Margin = new System.Windows.Forms.Padding(4);
            this.autoBox.Name = "autoBox";
            this.autoBox.Size = new System.Drawing.Size(98, 61);
            this.autoBox.TabIndex = 2;
            // 
            // TransBox
            // 
            this.TransBox.FormattingEnabled = true;
            this.TransBox.ItemHeight = 19;
            this.TransBox.Items.AddRange(new object[] {
            "Manual",
            "Automatic"});
            this.TransBox.Location = new System.Drawing.Point(90, 218);
            this.TransBox.Name = "TransBox";
            this.TransBox.Size = new System.Drawing.Size(120, 42);
            this.TransBox.TabIndex = 3;
            // 
            // Pricetext
            // 
            this.Pricetext.Enabled = false;
            this.Pricetext.Location = new System.Drawing.Point(535, 89);
            this.Pricetext.Name = "Pricetext";
            this.Pricetext.ReadOnly = true;
            this.Pricetext.Size = new System.Drawing.Size(100, 26);
            this.Pricetext.TabIndex = 4;
            this.Pricetext.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Trans label";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Subtotal:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(430, 277);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(48, 19);
            this.label.TabIndex = 13;
            this.label.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tax Label";
            // 
            // taxratetextBox
            // 
            this.taxratetextBox.Location = new System.Drawing.Point(130, 291);
            this.taxratetextBox.Name = "taxratetextBox";
            this.taxratetextBox.Size = new System.Drawing.Size(100, 26);
            this.taxratetextBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tax rate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Auto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Transmission";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(506, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Selected Auto";
            // 
            // Transtext
            // 
            this.Transtext.Enabled = false;
            this.Transtext.Location = new System.Drawing.Point(535, 133);
            this.Transtext.Name = "Transtext";
            this.Transtext.ReadOnly = true;
            this.Transtext.Size = new System.Drawing.Size(100, 26);
            this.Transtext.TabIndex = 21;
            this.Transtext.TabStop = false;
            // 
            // subtotalbox
            // 
            this.subtotalbox.Enabled = false;
            this.subtotalbox.Location = new System.Drawing.Point(535, 172);
            this.subtotalbox.Name = "subtotalbox";
            this.subtotalbox.ReadOnly = true;
            this.subtotalbox.Size = new System.Drawing.Size(100, 26);
            this.subtotalbox.TabIndex = 22;
            this.subtotalbox.TabStop = false;
            // 
            // taxBox
            // 
            this.taxBox.Enabled = false;
            this.taxBox.Location = new System.Drawing.Point(535, 221);
            this.taxBox.Name = "taxBox";
            this.taxBox.ReadOnly = true;
            this.taxBox.Size = new System.Drawing.Size(100, 26);
            this.taxBox.TabIndex = 23;
            this.taxBox.TabStop = false;
            // 
            // TotalBox
            // 
            this.TotalBox.Enabled = false;
            this.TotalBox.Location = new System.Drawing.Point(535, 270);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.ReadOnly = true;
            this.TotalBox.Size = new System.Drawing.Size(100, 26);
            this.TotalBox.TabIndex = 24;
            this.TotalBox.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.Calculatebutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.exitbutton;
            this.ClientSize = new System.Drawing.Size(686, 426);
            this.Controls.Add(this.TotalBox);
            this.Controls.Add(this.taxBox);
            this.Controls.Add(this.subtotalbox);
            this.Controls.Add(this.Transtext);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.taxratetextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pricetext);
            this.Controls.Add(this.TransBox);
            this.Controls.Add(this.autoBox);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.Calculatebutton);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jerry Nava Test-1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculatebutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox autoBox;
        private System.Windows.Forms.ListBox TransBox;
        private System.Windows.Forms.TextBox Pricetext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox taxratetextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Transtext;
        private System.Windows.Forms.TextBox subtotalbox;
        private System.Windows.Forms.TextBox taxBox;
        private System.Windows.Forms.TextBox TotalBox;
    }
}

