using ISM.Domain.Models;
using ISM.Infrastructure.Services;
using System.ComponentModel;

namespace ISM.WebUI
{
    public partial class Storages : Form
    {
        private readonly AllCategories _allCategories;
        private readonly ServiceforStorage _storage;

        public Storages()
        {
            _storage = new();
            _allCategories = new();
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.ResumeLayout();
            this.Hide();
            _allCategories.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "") { MessageBox.Show("Id is serialize !!!"); return; }
            if (textBox3.Text == "") { MessageBox.Show("Enter Name !!"); return; }
            if (textBox4.Text == "") { MessageBox.Show("Enter Description !!"); return; }
            if (textBox5.Text == "") { MessageBox.Show("Enter Amount !!"); return; }
            if (Char.IsDigit(textBox5.Text[0]) ||
                Char.IsDigit(textBox5.Text[1]) ||
                Char.IsDigit(textBox5.Text[2]) ||
                Char.IsDigit(textBox5.Text[3])
                ) { MessageBox.Show("You enter text!!! "); return; }
            Storage storage = new();
            storage.Name = this.textBox2.Text;
            storage.Description = this.textBox3.Text;
            storage.Amount = Convert.ToInt32(this.textBox4.Text);
            _storage.Create(storage);
        }
        private void button4_click(object sender, EventArgs e)
        {
            if (textBox3.Text == "") { MessageBox.Show("Enter Name !!"); return; }
            if (textBox2.Text == "") { MessageBox.Show("Enter Id !!"); return; }
            if (textBox4.Text == "") { MessageBox.Show("Enter Description !!"); return; }
            if (textBox5.Text == "") { MessageBox.Show("Enter Amount !!"); return; }
            if (Char.IsDigit(textBox5.Text[0]) ||
                Char.IsDigit(textBox5.Text[1]) ||
                Char.IsDigit(textBox5.Text[2]) ||
                Char.IsDigit(textBox5.Text[3])
                ) { MessageBox.Show("You enter wrong enter digits!!! "); return; }
            Storage storage = new();
            storage.Name = this.textBox2.Text;
            storage.Description = this.textBox3.Text;
            storage.Amount = Convert.ToInt32(this.textBox4.Text);
            _storage.Create(storage);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string searchingPattern =this.textBox1.Text;
            var elements= _storage.GetAll().Where(i => i.Name == searchingPattern);
             this.dataGridView1.DataSource= elements.ToList();
}
        private void Storages_Load(object sender, EventArgs e)
        {
            dataGridView1.SuspendLayout();

        }
    }
}
