namespace LIBIS
{
    partial class Form14
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
            richTextBox1.Location = new Point(34, 27);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(259, 308);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "cia knygu sarasas, kuriu pageidavo lankytojai;\n\nturi buti knygos; kiek knyga turi rezervaciju; lankytojai, rezervave sias knygas ";
            // 
            // Form14
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 450);
            Controls.Add(richTextBox1);
            Name = "Form14";
            Text = "Form14";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
    }
}