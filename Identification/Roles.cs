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
            foreach (var role in allRoles)
            {
                dataGridView1.Rows.Add(role.Id, role.Position);
            }
        }
        private void button5_Click(object sender, EventArgs e) =>
            System.Windows.Forms.Application.Exit();

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            _allCategories.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        //private ServiceforRoles Get_serviceforRoles()
        //{
        //    return _serviceforRoles;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0) MessageBox.Show("Id is Serialize");
            if (textBox2.Text.Length == 0) MessageBox.Show("Enter Position!" );
            string position = this.textBox2.Text;
            if (position.Equals("Manager", StringComparison.OrdinalIgnoreCase) ||
            position.Equals("Seller", StringComparison.OrdinalIgnoreCase) ||
            position.Equals("Manager", StringComparison.OrdinalIgnoreCase) ||
            position.Equals("Customer", StringComparison.OrdinalIgnoreCase))
            {
                Role roles = new Role();
                var Allroles = _serviceforRoles.GetAll();
                Role? role = Allroles.FirstOrDefault(x => x.Position == roles.Position);
                if (role == null)
                {
                    roles = role;
                    _serviceforRoles.Create(roles);
                }
                else MessageBox.Show("This Position exist");


            }
        }

        private void Roles_Load(object sender, EventArgs e)
        {

        }
    }
}
