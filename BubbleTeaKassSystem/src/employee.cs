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
    public partial class employee : Form
    {
        private string _username, _password, _phone, _address, _register, _firstname, _lastname;
        private int _profession, _eId;
        public string Username 
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address= value; }

        }
        DataTable employeeTable = new DataTable();
        DataTable professionTable = new DataTable();
        private void firstname_TextChanged(object sender, EventArgs e)
        {
            this._firstname = firstname.Text;
        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {
            this._lastname = lastname.Text;
        }

        private void phone_TextChanged(object sender, EventArgs e)
        {
            this._phone = phone.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this._password = textBox1.Text;
        }

        private void registerNumber_TextChanged(object sender, EventArgs e)
        {
            this._register = registerNumber.Text;
        }

        private void address_TextChanged(object sender, EventArgs e)
        {
            this._address = address.Text;
        }

        private void profession_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._profession = int.Parse(professionTable.Rows[profession.SelectedIndex]["id"].ToString());
        }

        public string Register
        {
            get { return _register; }
            set { _register= value; }

        }
        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (this._username != "" && this._lastname != ""  && this._password != "" && this._address != "" && this._firstname != "" && this._phone != ""
                && this._profession != -1 && this._register != "")
            {
                try
                {
                    
                    bool isManager = this._profession == 5;
                    
                    string query = "insertEmployee '" + this._username + "','" + this._lastname + "',' " + this._firstname + "','" + this._password + "','" + 
                        this._phone + "','" + this._address + "','" + this._register + "'," + this._profession + ',' + isManager;
                    Global.conn.Open();
                    SqlDataAdapter sd = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand(query, Global.conn);
                    sd.InsertCommand = cmd;
                    sd.InsertCommand.ExecuteNonQuery();
                    Global.conn.Close();
                    GetEmployee();
                    MessageBox.Show("Inserted");
                    this._firstname = String.Empty;
                    firstname.Text = "";
                    this._lastname = String.Empty;
                    lastname.Text = "";
                    this._username = String.Empty;
                    name.Text = "";
                    this._phone = String.Empty;
                    phone.Text = "";
                    this._register = String.Empty;
                    registerNumber.Text = "";
                    this._password= String.Empty;
                    textBox1.Text = "";
                    this._address = String.Empty;
                    address.Text = "";
                    this._profession = 0;
                }
                catch
                {
                    Console.WriteLine("error");
                }
            }
        }

        private void employees_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (employees.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow d in employees.SelectedRows)
                {
                    this._eId = int.Parse(d.Cells[0].Value.ToString());
                    this._username = d.Cells[1].Value.ToString();
                    this._phone = d.Cells[3].Value.ToString();
                    this._address = d.Cells[4].Value.ToString();
                    address.Text = this._address;
                    this._register = d.Cells[5].Value.ToString();
                    registerNumber.Text = this._register;
                    this._firstname= d.Cells[8].Value.ToString();
                    firstname.Text = this._firstname;
                    this._lastname= d.Cells[9].Value.ToString();
                    lastname.Text = this._lastname;
                    this._password= d.Cells[2].Value.ToString();
                    textBox1.Text = this._password;
                    this._profession = int.Parse(d.Cells[6].Value.ToString());
                    name.Text = this._username;
                    phone.Text = this._phone;
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (this._username != "" && this._lastname != "" && this._password != "" && this._address != "" && this._firstname != "" && this._phone != ""
                && this._profession != -1 && this._register != "")
            {
                try
                {

                    bool isManager = this._profession == 5;

                    string query = "updateEmployee '" + this._username + "','" + this._lastname + "',' " + this._firstname + "','" + this._password + "','" +
                        this._phone + "','" + this._address + "','" + this._register + "'," + this._profession + ',' + isManager + ',' + this._eId;
                    Global.conn.Open();
                    SqlDataAdapter sd = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand(query, Global.conn);
                    sd.UpdateCommand = cmd;
                    sd.UpdateCommand.ExecuteNonQuery();
                    Global.conn.Close();
                    GetEmployee();
                    MessageBox.Show("Updated");
                    this._firstname = String.Empty;
                    firstname.Text = "";
                    this._lastname = String.Empty;
                    lastname.Text = "";
                    this._username = String.Empty;
                    name.Text = "";
                    this._phone = String.Empty;
                    phone.Text = "";
                    this._register = String.Empty;
                    registerNumber.Text = "";
                    this._password = String.Empty;
                    textBox1.Text = "";
                    this._address = String.Empty;
                    address.Text = "";
                    this._eId = 0;
                    this._profession = 0;
                }
                catch
                {
                    Console.WriteLine("error");
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(this._eId != 0)
            {
                try
                {



                    string query = "delete from employee where id = " + this._eId;
                    Global.conn.Open();
                    SqlDataAdapter sd = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand(query, Global.conn);
                    sd.DeleteCommand = cmd;
                    sd.DeleteCommand.ExecuteNonQuery();
                    Global.conn.Close();
                    GetEmployee();
                    MessageBox.Show("Deleted");
                    this._firstname = String.Empty;
                    firstname.Text = "";
                    this._lastname = String.Empty;
                    lastname.Text = "";
                    this._username = String.Empty;
                    name.Text = "";
                    this._phone = String.Empty;
                    phone.Text = "";
                    this._register = String.Empty;
                    registerNumber.Text = "";
                    this._password = String.Empty;
                    textBox1.Text = "";
                    this._address = String.Empty;
                    address.Text = "";
                    this._eId = 0;
                    this._profession = 0;
                }
                catch
                {
                    Console.WriteLine("error");
                }
            }
        }

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        private int Profession
        {
            get { return _profession; }
            set { _profession = value; }
        }
        private int EmployeeId
        {
            get { return _eId; }
            set { _eId = value; }
        }

        public employee()
        {
            InitializeComponent();
            GetEmployee();
            GetProfession();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            this._username = name.Text;
        }

        private void GetEmployee()
        {
            try
            {
                employeeTable.Clear();
                string query = "select *  from employee";
                Global.conn.Open();
                SqlDataAdapter sd = new SqlDataAdapter(query, Global.conn);
                sd.Fill(employeeTable);
                if (employeeTable.Rows.Count > 0)
                {

                    employees.DataSource = employeeTable;
                    employees.Columns[0].Visible = false;
                    employees.Columns[6].Visible = false;
                    employees.Columns[10].Visible = false;

                }
                Global.conn.Close();
            }
            catch
            {

            }
        }
        private void GetProfession()
        {
            try
            {
                string query = "select *  from profession ";
                Global.conn.Open();
                SqlDataAdapter sd = new SqlDataAdapter(query, Global.conn);
                sd.Fill(professionTable);
                if (professionTable.Rows.Count > 0)
                {
                    for (int i = 0; i < professionTable.Rows.Count; i++)
                    {

                        profession.Items.Add(professionTable.Rows[i]["profession"]);
                    }


                }
                Global.conn.Close();
            }
            catch
            {

            }
        }
    }
}
