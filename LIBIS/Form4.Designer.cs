namespace LIBIS
{
    partial class Form4
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(380, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(97, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(97, 70);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(179, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(380, 138);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(179, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(97, 35);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(179, 27);
            textBox5.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 70);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 5;
            label1.Text = "Vardas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 103);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 6;
            label2.Text = "Pavardė:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(301, 141);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 7;
            label3.Text = "El. paštas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(284, 103);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 8;
            label4.Text = "Tel. numeris:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(324, 35);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 9;
            label5.Text = "Gatvė:";
         
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(312, 70);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 10;
            label6.Text = "Miestas:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Įprastas", "Studentas", "Moksleivis", "Specialus" });
            comboBox1.Location = new Point(97, 138);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(179, 28);
            comboBox1.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 138);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 12;
            label7.Text = "Statusas:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(380, 101);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(179, 27);
            textBox6.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(61, 35);
            label8.Name = "label8";
            label8.Size = new Size(27, 20);
            label8.TabIndex = 14;
            label8.Text = "ID:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(380, 68);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(179, 27);
            textBox7.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(245, 185);
            button1.Name = "button1";
            button1.Size = new Size(138, 28);
            button1.TabIndex = 16;
            button1.Text = "Pridėti";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 240);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form4";
            Text = "Naujas lankytojas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox7;
        private Button button1;
    }
}