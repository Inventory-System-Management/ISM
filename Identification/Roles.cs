using ISM.Domain.Models;
using ISM.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISM.WebUI
{
    public partial class Roles : Form
    {
        private readonly AllCategories _allCategories;
        private readonly ServiceforRoles _serviceforRoles;
        public Roles()
        {
            _serviceforRoles = new ServiceforRoles();
            _allCategories = new();
            InitializeComponent();
            var allRoles = _serviceforRoles.GetAll();
            //foreach (var role in allRoles)
            //{
            //    dataGridView1.Rows.Add(role.Id, role.Position);
            //}
        }
        private void button5_Click(object sender, EventArgs e) =>
            System.Windows.Forms.Application.Exit();

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            _allCategories.Show();
        }



        //private ServiceforRoles Get_serviceforRoles()
        //{
        //    return _serviceforRoles;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0) MessageBox.Show("Id is Serialize");
            if (textBox2.Text.Length == 0) { MessageBox.Show("Enter Position!"); return; }
            string position = this.textBox2.Text;
            if (position.Equals("Manager", StringComparison.OrdinalIgnoreCase) ||
            position.Equals("Seller", StringComparison.OrdinalIgnoreCase) ||
            position.Equals("Director", StringComparison.OrdinalIgnoreCase) ||
            position.Equals("Customer", StringComparison.OrdinalIgnoreCase))
            {
                Role roles = new();
                var Allroles = _serviceforRoles.GetAll();
                Role? role = Allroles.FirstOrDefault(x => x.Position == position);
                if (role == null)
                {
                    roles.Position = position;
                    Role role1 = _serviceforRoles.Create(roles);
                    if (role1.Id != 0) MessageBox.Show("New Role added");
                }
                else MessageBox.Show("This Position exist");
            }
            else MessageBox.Show("This Position not exist");
            dataGridView1.DataSource = _serviceforRoles.GetAll();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0) { MessageBox.Show("You cant enter position when you want delete !!"); return; }
            if (textBox1.Text.Length == 1)
            {
                int id = Convert.ToInt32(textBox1.Text);
                int deletedId = _serviceforRoles.Delete(id);
                if (deletedId != 0) { MessageBox.Show($"{deletedId} is deleted");
                dataGridView1.DataSource = _serviceforRoles.GetAll();
                    
                    return; }

                else MessageBox.Show("this id not exist");
            }
            else MessageBox.Show("This id not exist");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Roles_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _serviceforRoles.GetAll();

        }
    }
}
