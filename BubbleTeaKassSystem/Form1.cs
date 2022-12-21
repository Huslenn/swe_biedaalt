using BubbleTeaKassSystem.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleTeaKassSystem
{
    public partial class Login : Form
    {
        private String _username, _password;
        public String Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public String Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public Login()
        {
            InitializeComponent();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            this._password = password.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "execute login  " + this._username + ',' + this._password;
                Global.conn.Open();
                SqlDataAdapter sd = new SqlDataAdapter(query, Global.conn);
                DataTable dTable = new DataTable();
                sd.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    Global.user = dTable.Rows[0]["username"].ToString();
                    Global.userId = int.Parse(dTable.Rows[0]["id"].ToString());
                    Global.isManager = bool.Parse(dTable.Rows[0]["isManager"].ToString());
                    this.Hide();
                    home _home = new home();
                    _home.Show();
                }
                Global.conn.Close();
            } catch
            {

            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            this._username = username.Text;
        }
    }
}
