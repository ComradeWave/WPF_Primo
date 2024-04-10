namespace WPF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            btnMinus = new Button();
            btnDecimal = new Button();
            btnPlus = new Button();
            btnMulti = new Button();
            btnDivide = new Button();
            button9 = new Button();
            button6 = new Button();
            button4 = new Button();
            button5 = new Button();
            button7 = new Button();
            button8 = new Button();
            button0 = new Button();
            btnDelete = new Button();
            btnCalculate = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(179, 25);
            label1.Name = "label1";
            label1.Size = new Size(142, 28);
            label1.TabIndex = 0;
            label1.Text = "CALCOLATRICE";
            // 
            // button2
            // 
            button2.Location = new Point(95, 294);
            button2.Name = "button2";
            button2.Size = new Size(48, 43);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(24, 294);
            button1.Name = "button1";
            button1.Size = new Size(48, 43);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(166, 294);
            button3.Name = "button3";
            button3.Size = new Size(48, 43);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(239, 294);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(48, 43);
            btnMinus.TabIndex = 4;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Location = new Point(179, 358);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(35, 43);
            btnDecimal.TabIndex = 5;
            btnDecimal.Text = ",";
            btnDecimal.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(239, 358);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(48, 43);
            btnPlus.TabIndex = 6;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(239, 226);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(48, 43);
            btnMulti.TabIndex = 7;
            btnMulti.Text = "x";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(239, 158);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(48, 43);
            btnDivide.TabIndex = 8;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // button9
            // 
            button9.Location = new Point(166, 158);
            button9.Name = "button9";
            button9.Size = new Size(48, 43);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button6
            // 
            button6.Location = new Point(166, 226);
            button6.Name = "button6";
            button6.Size = new Size(48, 43);
            button6.TabIndex = 10;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.Location = new Point(24, 226);
            button4.Name = "button4";
            button4.Size = new Size(48, 43);
            button4.TabIndex = 11;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(95, 226);
            button5.Name = "button5";
            button5.Size = new Size(48, 43);
            button5.TabIndex = 12;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.Location = new Point(24, 158);
            button7.Name = "button7";
            button7.Size = new Size(48, 43);
            button7.TabIndex = 13;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(95, 158);
            button8.Name = "button8";
            button8.Size = new Size(48, 43);
            button8.TabIndex = 14;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button0
            // 
            button0.Location = new Point(24, 358);
            button0.Name = "button0";
            button0.Size = new Size(119, 43);
            button0.TabIndex = 15;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(315, 294);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(181, 43);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "C";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(315, 358);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(181, 43);
            btnCalculate.TabIndex = 17;
            btnCalculate.Text = "=";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 75);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(472, 23);
            textBox1.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(315, 158);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 19;
            label2.Text = "Errore!";
            label2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 450);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(btnCalculate);
            Controls.Add(btnDelete);
            Controls.Add(button0);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button6);
            Controls.Add(button9);
            Controls.Add(btnDivide);
            Controls.Add(btnMulti);
            Controls.Add(btnPlus);
            Controls.Add(btnDecimal);
            Controls.Add(btnMinus);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button btnMinus;
        private Button btnDecimal;
        private Button btnPlus;
        private Button btnMulti;
        private Button btnDivide;
        private Button button9;
        private Button button6;
        private Button button4;
        private Button button5;
        private Button button7;
        private Button button8;
        private Button button0;
        private Button btnDelete;
        private Button btnCalculate;
        private TextBox textBox1;
        private Label label2;
    }
}