using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleTeaKassSystem.src
{
    public partial class product : Form
    {
        private int selectedCategory,  selectedProduct;
        private double _unitprice;
        private string _productName;
        public int SelectedCategory
        {
            get { return selectedCategory; }
            set { selectedCategory = value; }
        }
        public int SelectedProduct
        {
            get { return selectedProduct; }
            set { selectedProduct = value; }
        }
        public double Unitprice
        {
            get { return _unitprice; }
            set { _unitprice = value; }
        }
        public string Productname
        {
            get { return _productName; }
            set { _productName = value; }
        }
        public product()
        {
            InitializeComponent();
            username.Text = Global.user;
            getCategory();
            getProduct();
        }
        DataTable categoryTable = new DataTable();
        DataTable dTable = new DataTable();

        private void getProduct()
        {
            try
            {
                dTable.Clear();
                string query = "getProduct";
                
                Global.conn.Open();
                SqlDataAdapter sd = new SqlDataAdapter(query, Global.conn);
                
                sd.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    products.DataSource = dTable;
                    products.Columns[0].Visible = false;
                }
                Global.conn.Close();
            }
            catch
            {

            }
        }
        private void getCategory()
        {
            try
            {
                string query = "select id, name  from category";
                Global.conn.Open();
                SqlDataAdapter sd = new SqlDataAdapter(query, Global.conn);
                sd.Fill(categoryTable);
                if (categoryTable.Rows.Count > 0)
                {
                    
                    for (int i = 0; i < categoryTable.Rows.Count; i++)
                    {
                        
                        category.Items.Add(categoryTable.Rows[i]["name"]);
                    }
                    
                }
                Global.conn.Close();
            }
            catch
            {

            }
        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedCategory = int.Parse(categoryTable.Rows[category.SelectedIndex]["id"].ToString());
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            this._productName = name.Text;
        }

        private void unitprice_TextChanged(object sender, EventArgs e)
        {
            this._unitprice = double.Parse(unitprice.Text);
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            category _category = new category();
            _category.Show();
        }

        private void report_Click(object sender, EventArgs e)
        {
            this.Hide();
             
        }

        private void fact_Click(object sender, EventArgs e)
        {
            this.Hide();
            home _category = new home();
            _category.Show();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            if (Global.isManager)
            {
                this.Hide();
                employee _emp = new employee();
                _emp.Show();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (this._productName != "" && this._unitprice != 0 && this.selectedCategory != 0)
            {
                try
                {
                    string query = "updateProduct " + this.selectedCategory + "," + this.selectedProduct  + ","+ Global.userId + "," + this._unitprice + ",'" + this._productName + "'" ;
                    Global.conn.Open();
                    SqlDataAdapter sd = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand(query, Global.conn);
                    sd.InsertCommand = cmd;
                    sd.InsertCommand.ExecuteNonQuery();
                    Global.conn.Close();
                    getProduct();
                    MessageBox.Show("Updated");
                    this._productName = String.Empty;
                    this.selectedCategory = 0;
                    this._unitprice = 0;
                    name.Text = "";
                    unitprice.Text = "";
                }
                catch
                {

                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(this.selectedProduct != 0)
            {
              
                try
                {
                    string query = "delete from product where id = " + this.selectedProduct;
                    Global.conn.Open();
                    SqlDataAdapter sd = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand(query, Global.conn);
                    sd.DeleteCommand = cmd;
                    sd.DeleteCommand.ExecuteNonQuery();
                    Global.conn.Close();
                    getProduct();
                    MessageBox.Show("Deleted");
                    this._productName = String.Empty;
                    this.selectedCategory = 0;
                    this._unitprice = 0;
                    name.Text = "";
                    unitprice.Text = "";
                } catch
                {

                }
            }
        }

        private void products_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (products.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow d in products.SelectedRows)
                {
                    this.selectedProduct = int.Parse(d.Cells[0].Value.ToString());
                    this._productName = d.Cells[1].Value.ToString();
                    this._unitprice =double.Parse(d.Cells[2].Value.ToString());
                    name.Text = d.Cells[1].Value.ToString();
                    unitprice.Text = this._unitprice.ToString();
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (this._productName != "" && this._unitprice != 0 && this.selectedCategory != 0)
            {
                try
                {
                    string query = "insertProduct " + Global.userId + ",'"  + this._productName + "'," + this._unitprice + "," + this.selectedCategory ;
                    Global.conn.Open();
                    SqlDataAdapter sd = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand(query, Global.conn);
                    sd.InsertCommand = cmd;
                    sd.InsertCommand.ExecuteNonQuery();
                    Global.conn.Close();
                    getProduct();
                    MessageBox.Show("Inserted");
                    this._productName = String.Empty;
                    this.selectedCategory = 0;
                    this._unitprice = 0;
                    name.Text = "";
                    unitprice.Text = "";
                }
                catch
                {

                }
            }
        }
    }
}
