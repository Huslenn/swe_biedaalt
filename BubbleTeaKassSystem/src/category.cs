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

namespace BubbleTeaKassSystem.src
{
    public partial class category : Form
    {
        private String _category; 
        private int selected;
        public int Selected
        {
            get { return selected; }
            set { selected = value; }
        }
        public String Category
        {
            get { return _category; }
            set { _category = value; }
        }
        public category()
        {
            InitializeComponent();
            username.Text = Global.user;
            GetCategory();
        }

        private void GetCategory()
        {
            try
            {
                string query = "select id, name as Ангилал from category";
                Global.conn.Open();
                SqlDataAdapter sd = new SqlDataAdapter(query, Global.conn);
                DataTable dTable = new DataTable();
                sd.Fill(dTable);
                if(dTable.Rows.Count > 0)
                {
                    categories.DataSource = dTable;
                    categories.Columns[0].Visible = false;
                }
                Global.conn.Close();
            } catch
            {

            }
        }
        private void name_TextChanged(object sender, EventArgs e)
        {
            this._category = name.Text;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if(this._category != "")
            {
                try
                {
                    string query = "insert into category(name) values('" + this._category + "')";
                    Global.conn.Open();
                    SqlDataAdapter sd = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand(query, Global.conn);
                    sd.InsertCommand = cmd;
                    sd.InsertCommand.ExecuteNonQuery();
                    Global.conn.Close();
                    GetCategory();
                    MessageBox.Show("Inserted");
                    this._category = String.Empty;
                    name.Text = "";
                }
                catch
                {

                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (categories.SelectedRows.Count > 0 && this._category != "")
            {

                try
                {
                    string query = "update category set name = '" + this._category + "' where id = " + this.selected;
                    Global.conn.Open();
                    SqlDataAdapter sd = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand(query, Global.conn);
                    sd.UpdateCommand = cmd;
                    sd.UpdateCommand.ExecuteNonQuery();
                    Global.conn.Close();
                    GetCategory();
                    MessageBox.Show("Updated");
                    this.selected = 0;
                    this._category = String.Empty;
                    name.Text = "";
                }
                catch
                {

                }
            }
        }

        private void categories_RowHeaderCellChanged(object sender, DataGridViewRowEventArgs e)
        {
            if( categories.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow d in categories.SelectedRows)
                {
                    this.selected = d.Index;
                    this._category = d.Cells[0].Value.ToString();
                    name.Text = d.Cells[0].Value.ToString();
                }
            }
        }

        private void categories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (categories.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow d in categories.SelectedRows)
                {
                    this.selected = int.Parse(d.Cells[0].Value.ToString());
                    this._category = d.Cells[1].Value.ToString();
                    name.Text = d.Cells[1].Value.ToString();
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (categories.SelectedRows.Count > 0)
            {
                string query = "delete from category where id = " + this.selected;
                Global.conn.Open();
                SqlDataAdapter sd = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(query, Global.conn);
                sd.UpdateCommand = cmd;
                sd.UpdateCommand.ExecuteNonQuery();
                Global.conn.Close();
                GetCategory();
                MessageBox.Show("Deleted");
                this.selected = 0;
                this._category = String.Empty;
                name.Text = "";
            }
        }

        private void product_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            product _product = new product();
            _product.Show();
        }

        private void fact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            home _home= new home();
            _home.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            home _home = new home();
            _home.Show();
        }
    }
}
