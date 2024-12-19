namespace LIBIS
{
    partial class Form11
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
            richTextBox1.Location = new Point(12, 32);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(307, 379);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "IRGI NEBUTINAS, BET GERAS DALYKAS;\n\natskiras langas ARBA NET PUSLAPIS, kuriame butu naudojimo instrukcija, paaiskinimai\nir panasiai";
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 450);
            Controls.Add(richTextBox1);
            Name = "Form11";
            Text = "Form11";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
    }
}