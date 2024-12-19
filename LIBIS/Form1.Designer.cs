namespace LIBIS
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
            loginBtn = new Button();
            exitBtn = new Button();
            nameTbox = new TextBox();
            passTbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(142, 231);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(94, 29);
            loginBtn.TabIndex = 0;
            loginBtn.Text = "Prisijungti";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(314, 231);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(94, 29);
            exitBtn.TabIndex = 1;
            exitBtn.Text = "Išeiti";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // nameTbox
            // 
            nameTbox.CharacterCasing = CharacterCasing.Upper;
            nameTbox.Location = new Point(142, 134);
            nameTbox.Name = "nameTbox";
            nameTbox.Size = new Size(266, 27);
            nameTbox.TabIndex = 2;
            // 
            // passTbox
            // 
            passTbox.Location = new Point(142, 177);
            passTbox.Name = "passTbox";
            passTbox.Size = new Size(266, 27);
            passTbox.TabIndex = 3;
            passTbox.UseSystemPasswordChar = true;
            passTbox.TextChanged += passTbox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 137);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 4;
            label1.Text = "Vardas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 180);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 5;
            label2.Text = "Slaptažodis:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(545, 336);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passTbox);
            Controls.Add(nameTbox);
            Controls.Add(exitBtn);
            Controls.Add(loginBtn);
            Name = "Form1";
            Text = "Libis";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginBtn;
        private Button exitBtn;
        private TextBox nameTbox;
        private TextBox passTbox;
        private Label label1;
        private Label label2;
    }
}
