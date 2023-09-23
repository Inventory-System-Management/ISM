using ISM.Application.Interfaces;
using ISM.Infrastructure.Checking;

namespace ISM.WebUI
{
    public partial class Identification : Form
    {
        private readonly IChecks _checks;
        public Identification()
        {
            InitializeComponent();
            _checks = new CheckService();
        }
        private void Login_btn_Click(object? sender, EventArgs? e)
        {
            if (textBox1.Text.Length == 0) { MessageBox.Show("Enter Login!"); return; }
            if (textBox2.Text.Length == 0) { MessageBox.Show("Enter Password!"); return; }
            var user = _checks.Password(textBox1.Text, textBox2.Text);
            if (user != null)
            {
                AllCategories allCategories = new(user);

                allCategories.Text = "Navigation Bar Example";
                allCategories.Location = new Point(0, 0);
                this.Hide();
                allCategories.Show();
            }
            else MessageBox.Show("This user not exist in database !!!");
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.UseSystemPasswordChar = !this.checkBox1.Checked;
        }
        private void label3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter ||e.KeyCode==Keys.Down)
            {
                textBox2.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text.Length == 0) { MessageBox.Show("Enter Login!"); return; }
                if (textBox2.Text.Length == 0) { MessageBox.Show("Enter Password!"); return; }
                var user = _checks.Password(textBox1.Text, textBox2.Text);
                if (user != null)
                {
                    AllCategories allCategories = new(user);

                    allCategories.Text = "Navigation Bar Example";
                    allCategories.Location = new Point(0, 0);
                    this.Hide();
                    allCategories.Show();
                }
                else MessageBox.Show("This user not exist in database !!!");
                textBox2.Focus();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                textBox1.Focus();
                e.SuppressKeyPress = true;
            }
        }
    }
}
