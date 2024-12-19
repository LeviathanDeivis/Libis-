namespace LIBIS
{

    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        string loginName = "SIMAS";
        string password = "simas";

        public Form1()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (nameTbox.Text == loginName && passTbox.Text == password)
            {
                f2.FormClosed += (s, args) => Application.Exit();
                f2.Show();
                this.Hide();
            }
            else if (nameTbox.Text != loginName)
            {
                MessageBox.Show("Ávestas neteisingas prisijungimo vardas!");
                nameTbox.Clear();
                passTbox.Clear();

            }
            else

            {
                MessageBox.Show("Ávestas neteisingas slaptaþodis!");
                nameTbox.Clear();
                passTbox.Clear();
            }
        }

        private void passTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
