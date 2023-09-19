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
            _serviceforRoles = new();
            _allCategories = new();
            InitializeComponent();
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
            var allRoles = _serviceforRoles.GetAll();
            foreach (var role in allRoles)
            {
                dataGridView1.Rows.Add(role);
            }
            
        }
    }
}
