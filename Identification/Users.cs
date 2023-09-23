using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ISM.WebUI
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void idbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Users_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.idbox.Text != "") { MessageBox.Show("Id is Serialize !!!");return; }
            if (this.Firstnamebox.Text =="") { MessageBox.Show("Firstname is Empty!!");return; }
            if (this.Lastnamebox.Text == "") { MessageBox.Show("Lastname is empty");return; }
            if (this.Emailbox.Text == "") { MessageBox.Show("Email is empty!!");return; }
            if (this.passwordbox.Text == "") { MessageBox.Show("password is empty");return; }
            if (Char.IsDigit(Firstnamebox.Text[0]) ||
               Char.IsDigit(Lastnamebox.Text[1]) ||
               Char.IsDigit(Emailbox.Text[2]) ||
               Char.IsDigit(passwordbox.Text[3])) { MessageBox.Show("You enter text!!! "); return; }
        }
    }
}
