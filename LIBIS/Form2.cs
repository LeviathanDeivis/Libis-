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
    public partial class Form2 : Form
    {

        Form3 f3 = new Form3();
        Form5 f5 = new Form5();
        Form7 f7 = new Form7();
        Form8 f8 = new Form8();
        Form9 f9 = new Form9();
        Form10 f10 = new Form10();
        Form11 f11 = new Form11();
        Form12 f12 = new Form12();
        Form13 f13 = new Form13();
        Form14 f14 = new Form14();

        public Form2()
        {
            InitializeComponent();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void sugadintosKnygosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f13.Show();
        }

        private void sąrašasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3.Show();
        }

        private void knygųSąrašasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f5.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void renginiaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f7.Show();
        }

        private void darboGrafikasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f8.Show();
        }

        private void partneriaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f9.Show();
        }

        private void vartotojoNustatymaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f10.Show();
        }

        private void apieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f11.Show();
        }

        private void knygųUžsakymasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f12.Show();
        }

        private void rezervacijosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f14.Show();
        }
    }
}
