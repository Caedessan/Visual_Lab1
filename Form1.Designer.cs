namespace Visual_Lab1
{
    class UnselectableButton : System.Windows.Forms.Button
    {
        public UnselectableButton() : base()
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.Selectable, false);
        }

        public void SimulateClick()
        {
            InvokeOnClick(this, System.EventArgs.Empty);
        }
    }
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
        public void DisplayMessage(string message)
        {
            transparentTextBox1.Text = message;
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WholeExpressionTextBox = new System.Windows.Forms.TextBox();
            this.CurrentInputTextBox = new System.Windows.Forms.TextBox();
            this.transparentTextBox1 = new System.Windows.Forms.TextBox();
            this.Number1 = new Visual_Lab1.UnselectableButton();
            this.Number2 = new Visual_Lab1.UnselectableButton();
            this.Number3 = new Visual_Lab1.UnselectableButton();
            this.Number4 = new Visual_Lab1.UnselectableButton();
            this.Number5 = new Visual_Lab1.UnselectableButton();
            this.Number6 = new Visual_Lab1.UnselectableButton();
            this.Number7 = new Visual_Lab1.UnselectableButton();
            this.Number8 = new Visual_Lab1.UnselectableButton();
            this.Number9 = new Visual_Lab1.UnselectableButton();
            this.Number0 = new Visual_Lab1.UnselectableButton();
            this.AddButton = new Visual_Lab1.UnselectableButton();
            this.SubtractButton = new Visual_Lab1.UnselectableButton();
            this.MultiplyButton = new Visual_Lab1.UnselectableButton();
            this.DivideButton = new Visual_Lab1.UnselectableButton();
            this.OpenBracket = new Visual_Lab1.UnselectableButton();
            this.CloseBracket = new Visual_Lab1.UnselectableButton();
            this.ClearButton = new Visual_Lab1.UnselectableButton();
            this.FuncButton = new Visual_Lab1.UnselectableButton();
            this.Sqrt = new Visual_Lab1.UnselectableButton();
            this.EqualsButton = new Visual_Lab1.UnselectableButton();
            this.DecimalButton = new Visual_Lab1.UnselectableButton();
            this.SuspendLayout();
            // 
            // WholeExpressionTextBox
            // 
            this.WholeExpressionTextBox.Location = new System.Drawing.Point(14, 14);
            this.WholeExpressionTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.WholeExpressionTextBox.Multiline = true;
            this.WholeExpressionTextBox.Name = "WholeExpressionTextBox";
            this.WholeExpressionTextBox.ReadOnly = true;
            this.WholeExpressionTextBox.Size = new System.Drawing.Size(448, 86);
            this.WholeExpressionTextBox.TabIndex = 0;
            this.WholeExpressionTextBox.TabStop = false;
            this.WholeExpressionTextBox.TextChanged += new System.EventHandler(this.WholeExpressionTextBox_TextChanged);
            // 
            // CurrentInputTextBox
            // 
            this.CurrentInputTextBox.Enabled = false;
            this.CurrentInputTextBox.Location = new System.Drawing.Point(411, 130);
            this.CurrentInputTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CurrentInputTextBox.Multiline = true;
            this.CurrentInputTextBox.Name = "CurrentInputTextBox";
            this.CurrentInputTextBox.Size = new System.Drawing.Size(194, 36);
            this.CurrentInputTextBox.TabIndex = 1;
            // 
            // transparentTextBox1
            // 
            this.transparentTextBox1.Enabled = false;
            this.transparentTextBox1.Location = new System.Drawing.Point(14, 130);
            this.transparentTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.transparentTextBox1.Multiline = true;
            this.transparentTextBox1.Name = "transparentTextBox1";
            this.transparentTextBox1.Size = new System.Drawing.Size(389, 36);
            this.transparentTextBox1.TabIndex = 2;
            // 
            // Number1
            // 
            this.Number1.Location = new System.Drawing.Point(14, 235);
            this.Number1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(49, 39);
            this.Number1.TabIndex = 3;
            this.Number1.Text = "1";
            this.Number1.UseVisualStyleBackColor = true;
            this.Number1.Click += new System.EventHandler(this.Number1_Click);
            // 
            // Number2
            // 
            this.Number2.Location = new System.Drawing.Point(70, 235);
            this.Number2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(49, 39);
            this.Number2.TabIndex = 4;
            this.Number2.Text = "2";
            this.Number2.UseVisualStyleBackColor = true;
            this.Number2.Click += new System.EventHandler(this.Number2_Click);
            // 
            // Number3
            // 
            this.Number3.Location = new System.Drawing.Point(126, 235);
            this.Number3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Number3.Name = "Number3";
            this.Number3.Size = new System.Drawing.Size(49, 39);
            this.Number3.TabIndex = 5;
            this.Number3.Text = "3";
            this.Number3.UseVisualStyleBackColor = true;
            this.Number3.Click += new System.EventHandler(this.Number3_Click);
            // 
            // Number4
            // 
            this.Number4.Location = new System.Drawing.Point(14, 282);
            this.Number4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Number4.Name = "Number4";
            this.Number4.Size = new System.Drawing.Size(49, 39);
            this.Number4.TabIndex = 6;
            this.Number4.Text = "4";
            this.Number4.UseVisualStyleBackColor = true;
            this.Number4.Click += new System.EventHandler(this.Number4_Click);
            // 
            // Number5
            // 
            this.Number5.Location = new System.Drawing.Point(70, 282);
            this.Number5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Number5.Name = "Number5";
            this.Number5.Size = new System.Drawing.Size(49, 39);
            this.Number5.TabIndex = 7;
            this.Number5.Text = "5";
            this.Number5.UseVisualStyleBackColor = true;
            this.Number5.Click += new System.EventHandler(this.Number5_Click);
            // 
            // Number6
            // 
            this.Number6.Location = new System.Drawing.Point(126, 282);
            this.Number6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Number6.Name = "Number6";
            this.Number6.Size = new System.Drawing.Size(49, 39);
            this.Number6.TabIndex = 8;
            this.Number6.Text = "6";
            this.Number6.UseVisualStyleBackColor = true;
            this.Number6.Click += new System.EventHandler(this.Number6_Click);
            // 
            // Number7
            // 
            this.Number7.Location = new System.Drawing.Point(14, 328);
            this.Number7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Number7.Name = "Number7";
            this.Number7.Size = new System.Drawing.Size(49, 39);
            this.Number7.TabIndex = 9;
            this.Number7.Text = "7";
            this.Number7.UseVisualStyleBackColor = true;
            this.Number7.Click += new System.EventHandler(this.Number7_Click);
            // 
            // Number8
            // 
            this.Number8.Location = new System.Drawing.Point(70, 328);
            this.Number8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Number8.Name = "Number8";
            this.Number8.Size = new System.Drawing.Size(49, 39);
            this.Number8.TabIndex = 10;
            this.Number8.Text = "8";
            this.Number8.UseVisualStyleBackColor = true;
            this.Number8.Click += new System.EventHandler(this.Number8_Click);
            // 
            // Number9
            // 
            this.Number9.Location = new System.Drawing.Point(126, 328);
            this.Number9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Number9.Name = "Number9";
            this.Number9.Size = new System.Drawing.Size(49, 39);
            this.Number9.TabIndex = 11;
            this.Number9.Text = "9";
            this.Number9.UseVisualStyleBackColor = true;
            this.Number9.Click += new System.EventHandler(this.Number9_Click);
            // 
            // Number0
            // 
            this.Number0.Location = new System.Drawing.Point(71, 375);
            this.Number0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Number0.Name = "Number0";
            this.Number0.Size = new System.Drawing.Size(49, 39);
            this.Number0.TabIndex = 13;
            this.Number0.Text = "0";
            this.Number0.UseVisualStyleBackColor = true;
            this.Number0.Click += new System.EventHandler(this.Number0_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(411, 192);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(49, 39);
            this.AddButton.TabIndex = 15;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubtractButton
            // 
            this.SubtractButton.Location = new System.Drawing.Point(467, 192);
            this.SubtractButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(49, 39);
            this.SubtractButton.TabIndex = 16;
            this.SubtractButton.Text = "-";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(411, 235);
            this.MultiplyButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(49, 39);
            this.MultiplyButton.TabIndex = 17;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Location = new System.Drawing.Point(467, 235);
            this.DivideButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(49, 39);
            this.DivideButton.TabIndex = 18;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // OpenBracket
            // 
            this.OpenBracket.Location = new System.Drawing.Point(411, 282);
            this.OpenBracket.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OpenBracket.Name = "OpenBracket";
            this.OpenBracket.Size = new System.Drawing.Size(49, 39);
            this.OpenBracket.TabIndex = 19;
            this.OpenBracket.Text = "(";
            this.OpenBracket.UseVisualStyleBackColor = true;
            this.OpenBracket.Click += new System.EventHandler(this.OpenBracket_Click);
            // 
            // CloseBracket
            // 
            this.CloseBracket.Location = new System.Drawing.Point(467, 282);
            this.CloseBracket.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CloseBracket.Name = "CloseBracket";
            this.CloseBracket.Size = new System.Drawing.Size(49, 39);
            this.CloseBracket.TabIndex = 20;
            this.CloseBracket.Text = ")";
            this.CloseBracket.UseVisualStyleBackColor = true;
            this.CloseBracket.Click += new System.EventHandler(this.CloseBracket_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(14, 174);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(49, 39);
            this.ClearButton.TabIndex = 21;
            this.ClearButton.Text = "С";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // FuncButton
            // 
            this.FuncButton.Location = new System.Drawing.Point(523, 192);
            this.FuncButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FuncButton.Name = "FuncButton";
            this.FuncButton.Size = new System.Drawing.Size(49, 39);
            this.FuncButton.TabIndex = 22;
            this.FuncButton.Text = "F";
            this.FuncButton.UseVisualStyleBackColor = true;
            this.FuncButton.Click += new System.EventHandler(this.FuncButton_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.Location = new System.Drawing.Point(411, 328);
            this.Sqrt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(49, 39);
            this.Sqrt.TabIndex = 23;
            this.Sqrt.Text = "√";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // EqualsButton
            // 
            this.EqualsButton.Location = new System.Drawing.Point(523, 375);
            this.EqualsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(49, 39);
            this.EqualsButton.TabIndex = 24;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // DecimalButton
            // 
            this.DecimalButton.Location = new System.Drawing.Point(467, 328);
            this.DecimalButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(49, 39);
            this.DecimalButton.TabIndex = 25;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = true;
            this.DecimalButton.Click += new System.EventHandler(this.DecimalButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 519);
            this.Controls.Add(this.DecimalButton);
            this.Controls.Add(this.EqualsButton);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.FuncButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CloseBracket);
            this.Controls.Add(this.OpenBracket);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Number0);
            this.Controls.Add(this.Number9);
            this.Controls.Add(this.Number8);
            this.Controls.Add(this.Number7);
            this.Controls.Add(this.Number6);
            this.Controls.Add(this.Number5);
            this.Controls.Add(this.Number4);
            this.Controls.Add(this.Number3);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.transparentTextBox1);
            this.Controls.Add(this.CurrentInputTextBox);
            this.Controls.Add(this.WholeExpressionTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPreview = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WholeExpressionTextBox;
        private System.Windows.Forms.TextBox CurrentInputTextBox;
        private System.Windows.Forms.TextBox transparentTextBox1;
        private UnselectableButton Number1;
        private UnselectableButton Number2;
        private UnselectableButton Number3;
        private UnselectableButton Number4;
        private UnselectableButton Number5;
        private UnselectableButton Number6;
        private UnselectableButton Number7;
        private UnselectableButton Number8;
        private UnselectableButton Number9;
        private UnselectableButton Number0;
        private UnselectableButton AddButton;
        private UnselectableButton SubtractButton;
        private UnselectableButton MultiplyButton;
        private UnselectableButton DivideButton;
        private UnselectableButton OpenBracket;
        private UnselectableButton CloseBracket;
        private UnselectableButton ClearButton;
        private UnselectableButton FuncButton;
        private UnselectableButton Sqrt;
        private UnselectableButton EqualsButton;
        private UnselectableButton DecimalButton;
    }
}

