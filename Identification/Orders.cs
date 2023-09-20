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
            //if (txbDate.Text.Length != 0) { MessageBox.Show("Enter Date!"); return; }
            if (txbTotalAmount.Text.Length == 0) { MessageBox.Show("Enter Amount!"); return; }
            if (txbUserId.Text.Length == 0) { MessageBox.Show("Enter User Id!"); return; }
            if (txbQuantityOrdered.Text.Length == 0) { MessageBox.Show("Enter Quantity!"); return; }
            if (txbStorageId.Text.Length == 0) { MessageBox.Show("Enter Storage Id!"); return; }

            Order order = new()
            {
                OrderDate = DateOnly.Parse(txbDate.Text),
                TotalAmount = double.Parse(txbTotalAmount.Text),
                UserId = int.Parse(txbUserId.Text),
                Order_Detail = new Order_Detail()
                {
                    QuantityOrdered = long.Parse(txbQuantityOrdered.Text),
                    StorageId = int.Parse(txbStorageId.Text)

                }
            };
            _serviceForOrders.Create(order);


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
