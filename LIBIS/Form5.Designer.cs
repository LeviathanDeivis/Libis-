namespace LIBIS
{
    partial class Form5
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            ID = new DataGridViewTextBoxColumn();
            Pavadinimas = new DataGridViewTextBoxColumn();
            Autoius = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Pavadinimas, Autoius });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(378, 426);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(396, 12);
            button1.Name = "button1";
            button1.Size = new Size(140, 29);
            button1.TabIndex = 1;
            button1.Text = "Pridėti";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(396, 47);
            button2.Name = "button2";
            button2.Size = new Size(140, 29);
            button2.TabIndex = 2;
            button2.Text = "Apie";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(396, 411);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 27);
            textBox1.TabIndex = 3;
            // 
            // ID
            // 
            ID.HeaderText = "ID:";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 125;
            // 
            // Pavadinimas
            // 
            Pavadinimas.HeaderText = "Pavadinimas:";
            Pavadinimas.MinimumWidth = 6;
            Pavadinimas.Name = "Pavadinimas";
            Pavadinimas.ReadOnly = true;
            Pavadinimas.Width = 125;
            // 
            // Autoius
            // 
            Autoius.HeaderText = "Autorius:";
            Autoius.MinimumWidth = 6;
            Autoius.Name = "Autoius";
            Autoius.ReadOnly = true;
            Autoius.Width = 125;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 450);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form5";
            Text = "Knygų sąrašas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Pavadinimas;
        private DataGridViewTextBoxColumn Autoius;
    }
}