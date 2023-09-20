using ISM.Application.Interfaces.Orders;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ISM.WebUI
{
    public partial class Orders : Form
    {
        private readonly AllCategories _allCategories;
        private readonly IOrderService _serviceForOrders;
        public Orders()
        {
            _allCategories = new();
            _serviceForOrders = new ServiceForOrders();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add

            #region
            //if (textBox1.Text.Length != 0) MessageBox.Show("Id is Serialize");
            //if (textBox2.Text.Length == 0) { MessageBox.Show("Enter Position!"); return; }
            //string position = this.textBox2.Text;
            //if (position.Equals("Manager", StringComparison.OrdinalIgnoreCase) ||
            //position.Equals("Seller", StringComparison.OrdinalIgnoreCase) ||
            //position.Equals("Director", StringComparison.OrdinalIgnoreCase) ||
            //position.Equals("Customer", StringComparison.OrdinalIgnoreCase))
            //{
            //    Role roles = new();
            //    var Allroles = _serviceforRoles.GetAll();
            //    Role? role = Allroles.FirstOrDefault(x => x.Position == position);
            //    if (role == null)
            //    {
            //        roles.Position = position;
            //        Role role1 = _serviceforRoles.Create(roles);
            //        if (role1.Id != 0) MessageBox.Show("New Role added");
            //    }
            //    else MessageBox.Show("This Position exist");
            //}
            //else MessageBox.Show("This Position not exist");
            #endregion

            dataGridView1.DataSource = _serviceForOrders.GetAll();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            _allCategories.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Orders_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = _serviceForOrders.GetAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //edit
            dataGridView1.DataSource = _serviceForOrders.GetAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //delete
            dataGridView1.DataSource = _serviceForOrders.GetAll();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //search
            dataGridView1.DataSource = _serviceForOrders.GetAll().Where(x => x == x);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = _serviceForOrders.GetAll();//.
                //FirstOrDefault(x => x.Id== int.Parse(textBox1.Text));
        }
    }
}
