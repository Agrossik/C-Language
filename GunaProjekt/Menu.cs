using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunaProjekt
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            Show.Visible = false;
            Hide.Visible = true;
            guna2Panel1.Visible = false;
            guna2Panel1.Width = 205;
            guna2Transition1.ShowSync(guna2Panel1);


        }

        private void Hide_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = false;
            Show.Visible = true;
            Hide.Visible = false;
            guna2Panel1.Visible = false;
            guna2Panel1.Width = 47;
            guna2Transition1.ShowSync(guna2Panel1);
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            Nastavenia _load = new Nastavenia();
            _load.Show();
            this.Hide();
        }
    }
}
