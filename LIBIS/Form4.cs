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
    
        public partial class Form4 : Form
        {
            private Form3 _parentForm; 

            Random rnd = new Random();

            public Form4(Form3 parentForm)
            {
                InitializeComponent();
                _parentForm = parentForm; 

                int uniqueID = rnd.Next(10000, 90000);
                textBox5.Text = uniqueID.ToString();
            }

            private void button1_Click(object sender, EventArgs e)
            {
             
                string id = textBox5.Text;
                string vardas = textBox3.Text;
                string pavarde = textBox2.Text;
                string statusas = comboBox1.Text;
                string gatve = textBox1.Text;
                string miestas = textBox7.Text;
                string numeris = textBox6.Text;
                string pastas = textBox4.Text;

             
                _parentForm.vartotojoPridejimas(id, vardas, pavarde, statusas, gatve, miestas, numeris, pastas);

                this.Close(); 
            }
        }
    }