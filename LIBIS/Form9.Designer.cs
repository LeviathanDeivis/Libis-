namespace LIBIS
{
    partial class Form9
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
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(34, 36);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(267, 334);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "Cia turetu buti surasyti bibliotekos mecenetai, spec istaigos, kurios turi platesne prieiga;\n\ngalbut galimybe susisiekti su tam tikromis imonemis del remonto ar kitu paslaugu";
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 450);
            Controls.Add(richTextBox1);
            Name = "Form9";
            Text = "Form9";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
    }
}