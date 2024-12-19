using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBIS
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(this);
            f6.ShowDialog();
        }

        public void knygosPridejimas(string id, string pavadinimas, string autorius, string zanras, string isleidimoMetai, string bukle)
        {
            dataGridView1.Rows.Add(id, pavadinimas, autorius, zanras, isleidimoMetai, bukle);
        }
    }
}
