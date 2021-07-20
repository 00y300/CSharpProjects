namespace Jerry_Nava_CPT_185_Chapter_8
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
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Convertbutton = new System.Windows.Forms.Button();
            this.MorsecodelistBox = new System.Windows.Forms.ListBox();
            this.StandardtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Clrbutton = new System.Windows.Forms.Button();
            this.Soundbutton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Exitbutton
            // 
            this.Exitbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exitbutton.Location = new System.Drawing.Point(376, 219);
            this.Exitbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(112, 34);
            this.Exitbutton.TabIndex = 3;
            this.Exitbutton.Text = "E&xit";
            this.toolTip1.SetToolTip(this.Exitbutton, "Exit");
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Convertbutton
            // 
            this.Convertbutton.Location = new System.Drawing.Point(20, 219);
            this.Convertbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Convertbutton.Name = "Convertbutton";
            this.Convertbutton.Size = new System.Drawing.Size(112, 32);
            this.Convertbutton.TabIndex = 1;
            this.Convertbutton.Text = "&Convert";
            this.toolTip1.SetToolTip(this.Convertbutton, "Convert Text To Morse Code");
            this.Convertbutton.UseVisualStyleBackColor = true;
            this.Convertbutton.Click += new System.EventHandler(this.Convertbutton_Click);
            // 
            // MorsecodelistBox
            // 
            this.MorsecodelistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MorsecodelistBox.FormattingEnabled = true;
            this.MorsecodelistBox.ItemHeight = 24;
            this.MorsecodelistBox.Location = new System.Drawing.Point(157, 87);
            this.MorsecodelistBox.Margin = new System.Windows.Forms.Padding(4);
            this.MorsecodelistBox.Name = "MorsecodelistBox";
            this.MorsecodelistBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MorsecodelistBox.Size = new System.Drawing.Size(173, 124);
            this.MorsecodelistBox.TabIndex = 8;
            this.MorsecodelistBox.TabStop = false;
            this.toolTip1.SetToolTip(this.MorsecodelistBox, "Text In Morse Code");
            // 
            // StandardtextBox
            // 
            this.StandardtextBox.Location = new System.Drawing.Point(49, 53);
            this.StandardtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.StandardtextBox.Name = "StandardtextBox";
            this.StandardtextBox.Size = new System.Drawing.Size(386, 26);
            this.StandardtextBox.TabIndex = 0;
            this.StandardtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter the text that you want to be converted to Morse Code.";
            // 
            // Clrbutton
            // 
            this.Clrbutton.Location = new System.Drawing.Point(256, 219);
            this.Clrbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Clrbutton.Name = "Clrbutton";
            this.Clrbutton.Size = new System.Drawing.Size(112, 34);
            this.Clrbutton.TabIndex = 2;
            this.Clrbutton.Text = "C&lear";
            this.toolTip1.SetToolTip(this.Clrbutton, "Clear All Values");
            this.Clrbutton.UseVisualStyleBackColor = true;
            this.Clrbutton.Click += new System.EventHandler(this.Clrbutton_Click);
            // 
            // Soundbutton
            // 
            this.Soundbutton.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.Soundbutton.Location = new System.Drawing.Point(139, 219);
            this.Soundbutton.Name = "Soundbutton";
            this.Soundbutton.Size = new System.Drawing.Size(112, 34);
            this.Soundbutton.TabIndex = 9;
            this.Soundbutton.Text = "&Play Sound";
            this.toolTip1.SetToolTip(this.Soundbutton, "Play Morse Code Sound");
            this.Soundbutton.UseVisualStyleBackColor = true;
            this.Soundbutton.Click += new System.EventHandler(this.Soundbutton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.Convertbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.CancelButton = this.Exitbutton;
            this.ClientSize = new System.Drawing.Size(525, 276);
            this.Controls.Add(this.Soundbutton);
            this.Controls.Add(this.Clrbutton);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Convertbutton);
            this.Controls.Add(this.MorsecodelistBox);
            this.Controls.Add(this.StandardtextBox);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapter 8 Jerry Nava Morse Code";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button Convertbutton;
        private System.Windows.Forms.ListBox MorsecodelistBox;
        private System.Windows.Forms.TextBox StandardtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Clrbutton;
        private System.Windows.Forms.Button Soundbutton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

