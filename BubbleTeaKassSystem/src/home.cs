using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleTeaKassSystem.src
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
            username.Text = Global.user;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void username_Click(object sender, EventArgs e)
        {
            if (Global.isManager)
            {
                this.Hide();
                employee _emp = new employee();
                _emp.Show();
            }
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            category _c = new category();
            _c.Show();
        }

        private void product_Click(object sender, EventArgs e)
        {
            this.Hide();
            product _c = new product();
            _c.Show();
        }

        private void report_Click(object sender, EventArgs e)
        {

        }

        private void fact_Click(object sender, EventArgs e)
        {
            this.Hide();
            home _c = new home();
            _c.Show();
        }
    }
}
