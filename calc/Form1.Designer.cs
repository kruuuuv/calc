namespace calc
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 3;
            label1.Text = "Введите число в градусах";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "Вы ввели:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 197);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 6;
            label3.Text = "выберите действие:";
            // 
            // button1
            // 
            button1.Location = new Point(12, 296);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Посчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(34, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(347, 23);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(34, 358);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(347, 23);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 331);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 10;
            label4.Text = "Ответ:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "°", "'", "\"" });
            comboBox2.Location = new Point(341, 50);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(40, 23);
            comboBox2.TabIndex = 11;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(12, 232);
            button2.Name = "button2";
            button2.Size = new Size(27, 23);
            button2.TabIndex = 12;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(45, 232);
            button3.Name = "button3";
            button3.Size = new Size(27, 23);
            button3.TabIndex = 13;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(78, 232);
            button4.Name = "button4";
            button4.Size = new Size(27, 23);
            button4.TabIndex = 14;
            button4.Text = "*";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(111, 232);
            button5.Name = "button5";
            button5.Size = new Size(27, 23);
            button5.TabIndex = 15;
            button5.Text = "/";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(12, 261);
            button6.Name = "button6";
            button6.Size = new Size(41, 23);
            button6.TabIndex = 16;
            button6.Text = "cos";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(59, 261);
            button7.Name = "button7";
            button7.Size = new Size(41, 23);
            button7.TabIndex = 17;
            button7.Text = "sin";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(106, 261);
            button8.Name = "button8";
            button8.Size = new Size(41, 23);
            button8.TabIndex = 18;
            button8.Text = "tg";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(153, 261);
            button9.Name = "button9";
            button9.Size = new Size(41, 23);
            button9.TabIndex = 19;
            button9.Text = "ctg";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(265, 23);
            label5.Name = "label5";
            label5.Size = new Size(10, 15);
            label5.TabIndex = 20;
            label5.Text = " ";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 450);
            Controls.Add(label5);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private ComboBox comboBox2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label5;
    }
}
