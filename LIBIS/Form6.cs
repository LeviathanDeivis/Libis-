using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LIBIS
{
    public partial class Form6 : Form
    {
        private Form5 _parentForm;

        Random rnd = new Random();

        public Form6(Form5 parentForm)
        {
            InitializeComponent();

            _parentForm = parentForm;

            int uniqueID = rnd.Next(10000, 90000);
            textBox1.Text = uniqueID.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string pavadinimas = textBox2.Text;
            string autorius = textBox3.Text;
            string zanras = textBox4.Text;
            string isleidimoMetai = textBox5.Text;
            string bukle = comboBox1.Text;

            _parentForm.knygosPridejimas(id, pavadinimas, autorius, zanras, isleidimoMetai, bukle);

            this.Close();
        }
    }
}
