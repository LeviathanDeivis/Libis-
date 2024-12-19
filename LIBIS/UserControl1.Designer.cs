namespace LIBIS
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(83, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 48);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 93);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 2;
            label2.Text = "Vardas:";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(83, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 27);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 137);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 4;
            label3.Text = "Pavardė:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(83, 141);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(204, 27);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(333, 48);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 6;
            label4.Text = "Gatvė:";
            label4.Click += label4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(389, 45);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(204, 27);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(321, 97);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 8;
            label5.Text = "Miestas:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(389, 97);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(204, 27);
            textBox5.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(293, 144);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 10;
            label6.Text = "Tel. numeris:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(389, 141);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(204, 27);
            textBox6.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(310, 189);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 12;
            label7.Text = "El. paštas:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(389, 186);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(204, 27);
            textBox7.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 189);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 14;
            label8.Text = "Statusas:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Įprastas", "Moksleivis", "Studentas", "Specialus" });
            comboBox1.Location = new Point(83, 189);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 28);
            comboBox1.TabIndex = 15;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "UserControl1";
            Size = new Size(813, 317);
            Load += UserControl1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox7;
        private Label label8;
        private ComboBox comboBox1;
    }
}
