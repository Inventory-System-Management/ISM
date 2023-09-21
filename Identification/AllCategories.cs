using ISM.Domain.Models;
using System.Data;
using System.Diagnostics;

namespace ISM.WebUI;

public partial class AllCategories : Form
{
    private readonly Identification identification;
    private readonly Storages storages;
    private readonly User user;
    private readonly Roles roles;
    public AllCategories(User user)
    {
        this.user = user;
        storages = new Storages();
        roles = new();
        identification = new();
        InitializeComponent();
    }
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

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        this.Hide();
        Orders orders = new();
        orders.Show();
    }
    private void pictureBox5_Click(object sender, EventArgs e)
    {
        this.Hide();
        storages.Show();
    }

    private void RolesPictureBox_Click(object sender, EventArgs e)
    {
        this.Hide();
        Roles roles = new();
        roles.Show();
    }
}
