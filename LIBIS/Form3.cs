using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace LIBIS
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(this);
            f4.ShowDialog();
        }

        public void vartotojoPridejimas(string id, string vardas, string pavarde, string statusas, string gatve, string miestas, string numeris, string pastas)
        {
            dataGridView1.Rows.Add(id, vardas, pavarde, statusas, gatve, miestas, numeris, pastas);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.Show();
        }
    }
}
