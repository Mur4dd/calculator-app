namespace Day_8
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
            panel1 = new Panel();
            result = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dot = new Button();
            division = new Button();
            equal = new Button();
            zero = new Button();
            clear = new Button();
            power = new Button();
            multiplication = new Button();
            three = new Button();
            two = new Button();
            one = new Button();
            percentage = new Button();
            subtraction = new Button();
            six = new Button();
            five = new Button();
            four = new Button();
            sqrt = new Button();
            plus = new Button();
            nine = new Button();
            eight = new Button();
            seven = new Button();
            panel3 = new Panel();
            historyListBox = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(result);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            result.Location = new Point(12, 9);
            result.Name = "result";
            result.Size = new Size(28, 32);
            result.TabIndex = 1;
            result.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(700, 65);
            label1.Name = "label1";
            label1.Size = new Size(88, 32);
            label1.TabIndex = 0;
            label1.Text = "History";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(dot);
            panel2.Controls.Add(division);
            panel2.Controls.Add(equal);
            panel2.Controls.Add(zero);
            panel2.Controls.Add(clear);
            panel2.Controls.Add(power);
            panel2.Controls.Add(multiplication);
            panel2.Controls.Add(three);
            panel2.Controls.Add(two);
            panel2.Controls.Add(one);
            panel2.Controls.Add(percentage);
            panel2.Controls.Add(subtraction);
            panel2.Controls.Add(six);
            panel2.Controls.Add(five);
            panel2.Controls.Add(four);
            panel2.Controls.Add(sqrt);
            panel2.Controls.Add(plus);
            panel2.Controls.Add(nine);
            panel2.Controls.Add(eight);
            panel2.Controls.Add(seven);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(547, 482);
            panel2.TabIndex = 1;
            // 
            // dot
            // 
            dot.BackColor = Color.Sienna;
            dot.Font = new Font("Segoe UI", 14.25F);
            dot.Location = new Point(434, 350);
            dot.Name = "dot";
            dot.Size = new Size(100, 100);
            dot.TabIndex = 19;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = false;
            dot.Click += dot_Click;
            // 
            // division
            // 
            division.BackColor = Color.OrangeRed;
            division.Font = new Font("Segoe UI", 14.25F);
            division.Location = new Point(330, 350);
            division.Name = "division";
            division.Size = new Size(100, 100);
            division.TabIndex = 18;
            division.Text = "/";
            division.UseVisualStyleBackColor = false;
            division.Click += division_Click;
            // 
            // equal
            // 
            equal.BackColor = Color.Green;
            equal.Font = new Font("Segoe UI", 14.25F);
            equal.Location = new Point(224, 350);
            equal.Name = "equal";
            equal.Size = new Size(100, 100);
            equal.TabIndex = 17;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            equal.Click += equal_Click;
            // 
            // zero
            // 
            zero.BackColor = Color.Cyan;
            zero.Font = new Font("Segoe UI", 14.25F);
            zero.Location = new Point(117, 350);
            zero.Name = "zero";
            zero.Size = new Size(100, 100);
            zero.TabIndex = 16;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = false;
            zero.Click += zero_Click;
            // 
            // clear
            // 
            clear.BackColor = Color.Red;
            clear.Font = new Font("Segoe UI", 14.25F);
            clear.Location = new Point(11, 350);
            clear.Name = "clear";
            clear.Size = new Size(100, 100);
            clear.TabIndex = 15;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // power
            // 
            power.BackColor = Color.Sienna;
            power.Font = new Font("Segoe UI", 14.25F);
            power.Location = new Point(434, 242);
            power.Name = "power";
            power.Size = new Size(100, 100);
            power.TabIndex = 14;
            power.Text = "x^2";
            power.UseVisualStyleBackColor = false;
            power.Click += power_Click;
            // 
            // multiplication
            // 
            multiplication.BackColor = Color.OrangeRed;
            multiplication.Font = new Font("Segoe UI", 14.25F);
            multiplication.Location = new Point(330, 242);
            multiplication.Name = "multiplication";
            multiplication.Size = new Size(100, 100);
            multiplication.TabIndex = 13;
            multiplication.Text = "X";
            multiplication.UseVisualStyleBackColor = false;
            multiplication.Click += multiplication_Click;
            // 
            // three
            // 
            three.BackColor = Color.Cyan;
            three.Font = new Font("Segoe UI", 14.25F);
            three.Location = new Point(224, 242);
            three.Name = "three";
            three.Size = new Size(100, 100);
            three.TabIndex = 12;
            three.Text = "3";
            three.UseVisualStyleBackColor = false;
            three.Click += three_Click;
            // 
            // two
            // 
            two.BackColor = Color.Cyan;
            two.Font = new Font("Segoe UI", 14.25F);
            two.Location = new Point(117, 242);
            two.Name = "two";
            two.Size = new Size(100, 100);
            two.TabIndex = 11;
            two.Text = "2";
            two.UseVisualStyleBackColor = false;
            two.Click += two_Click;
            // 
            // one
            // 
            one.BackColor = Color.Cyan;
            one.Font = new Font("Segoe UI", 14.25F);
            one.Location = new Point(11, 242);
            one.Name = "one";
            one.Size = new Size(100, 100);
            one.TabIndex = 10;
            one.Text = "1";
            one.UseVisualStyleBackColor = false;
            one.Click += one_Click;
            // 
            // percentage
            // 
            percentage.BackColor = Color.Sienna;
            percentage.Font = new Font("Segoe UI", 14.25F);
            percentage.Location = new Point(434, 136);
            percentage.Name = "percentage";
            percentage.Size = new Size(100, 100);
            percentage.TabIndex = 9;
            percentage.Text = "%";
            percentage.UseVisualStyleBackColor = false;
            percentage.Click += percentage_Click;
            // 
            // subtraction
            // 
            subtraction.BackColor = Color.OrangeRed;
            subtraction.Font = new Font("Segoe UI", 14.25F);
            subtraction.Location = new Point(330, 136);
            subtraction.Name = "subtraction";
            subtraction.Size = new Size(100, 100);
            subtraction.TabIndex = 8;
            subtraction.Text = "-";
            subtraction.UseVisualStyleBackColor = false;
            subtraction.Click += subtraction_Click;
            // 
            // six
            // 
            six.BackColor = Color.Cyan;
            six.Font = new Font("Segoe UI", 14.25F);
            six.Location = new Point(224, 136);
            six.Name = "six";
            six.Size = new Size(100, 100);
            six.TabIndex = 7;
            six.Text = "6";
            six.UseVisualStyleBackColor = false;
            six.Click += six_Click;
            // 
            // five
            // 
            five.BackColor = Color.Cyan;
            five.Font = new Font("Segoe UI", 14.25F);
            five.Location = new Point(117, 136);
            five.Name = "five";
            five.Size = new Size(100, 100);
            five.TabIndex = 6;
            five.Text = "5";
            five.UseVisualStyleBackColor = false;
            five.Click += five_Click;
            // 
            // four
            // 
            four.BackColor = Color.Cyan;
            four.Font = new Font("Segoe UI", 14.25F);
            four.Location = new Point(11, 136);
            four.Name = "four";
            four.Size = new Size(100, 100);
            four.TabIndex = 5;
            four.Text = "4";
            four.UseVisualStyleBackColor = false;
            four.Click += four_Click;
            // 
            // sqrt
            // 
            sqrt.BackColor = Color.Sienna;
            sqrt.Font = new Font("Segoe UI", 14.25F);
            sqrt.Location = new Point(434, 30);
            sqrt.Name = "sqrt";
            sqrt.Size = new Size(100, 100);
            sqrt.TabIndex = 4;
            sqrt.Text = "Sqrt";
            sqrt.UseVisualStyleBackColor = false;
            sqrt.Click += sqrt_Click;
            // 
            // plus
            // 
            plus.BackColor = Color.OrangeRed;
            plus.Font = new Font("Segoe UI", 14.25F);
            plus.Location = new Point(330, 30);
            plus.Name = "plus";
            plus.Size = new Size(100, 100);
            plus.TabIndex = 3;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = false;
            plus.Click += plus_Click;
            // 
            // nine
            // 
            nine.BackColor = Color.Cyan;
            nine.Font = new Font("Segoe UI", 14.25F);
            nine.Location = new Point(224, 30);
            nine.Name = "nine";
            nine.Size = new Size(100, 100);
            nine.TabIndex = 2;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = false;
            nine.Click += nine_Click;
            // 
            // eight
            // 
            eight.BackColor = Color.Cyan;
            eight.Font = new Font("Segoe UI", 14.25F);
            eight.Location = new Point(117, 30);
            eight.Name = "eight";
            eight.Size = new Size(100, 100);
            eight.TabIndex = 1;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = false;
            eight.Click += eight_Click;
            // 
            // seven
            // 
            seven.BackColor = Color.Cyan;
            seven.Font = new Font("Segoe UI", 14.25F);
            seven.Location = new Point(11, 30);
            seven.Name = "seven";
            seven.Size = new Size(100, 100);
            seven.TabIndex = 0;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = false;
            seven.Click += seven_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(historyListBox);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(545, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(255, 482);
            panel3.TabIndex = 2;
            // 
            // historyListBox
            // 
            historyListBox.FormattingEnabled = true;
            historyListBox.ItemHeight = 15;
            historyListBox.Location = new Point(3, 6);
            historyListBox.Name = "historyListBox";
            historyListBox.Size = new Size(249, 469);
            historyListBox.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 582);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button percentage;
        private Button subtraction;
        private Button six;
        private Button five;
        private Button four;
        private Button sqrt;
        private Button plus;
        private Button nine;
        private Button eight;
        private Button seven;
        private Panel panel3;
        private Button dot;
        private Button division;
        private Button equal;
        private Button zero;
        private Button clear;
        private Button power;
        private Button multiplication;
        private Button three;
        private Button two;
        private Button one;
        private Label label1;
        private Label result;
        private ListBox historyListBox;
    }
}
