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
    public partial class AllCategories : Form
    {
        private Identification identification;
        public AllCategories()
        {
            identification = new();
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            identification.Show();
        }
    }
}
