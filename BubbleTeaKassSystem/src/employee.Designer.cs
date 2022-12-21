namespace BubbleTeaKassSystem.src
{
    partial class employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employee));
            this.employees = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.LinkLabel();
            this.categorybtn = new System.Windows.Forms.LinkLabel();
            this.product = new System.Windows.Forms.LinkLabel();
            this.profile = new System.Windows.Forms.LinkLabel();
            this.report = new System.Windows.Forms.LinkLabel();
            this.fact = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.registerNumber = new System.Windows.Forms.TextBox();
            this.profession = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.employees)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // employees
            // 
            this.employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employees.Location = new System.Drawing.Point(384, 108);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(345, 188);
            this.employees.TabIndex = 35;
            this.employees.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.employees_RowHeaderMouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Username:";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(21, 372);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(65, 23);
            this.delete.TabIndex = 33;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(94, 372);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(65, 23);
            this.update.TabIndex = 32;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(165, 372);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(65, 23);
            this.add.TabIndex = 31;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(109, 105);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(121, 20);
            this.name.TabIndex = 30;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.categorybtn);
            this.panel1.Controls.Add(this.product);
            this.panel1.Controls.Add(this.profile);
            this.panel1.Controls.Add(this.report);
            this.panel1.Controls.Add(this.fact);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 42);
            this.panel1.TabIndex = 29;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.username.LinkColor = System.Drawing.Color.Black;
            this.username.Location = new System.Drawing.Point(654, 13);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(0, 20);
            this.username.TabIndex = 7;
            // 
            // categorybtn
            // 
            this.categorybtn.AutoSize = true;
            this.categorybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorybtn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.categorybtn.LinkColor = System.Drawing.Color.Black;
            this.categorybtn.Location = new System.Drawing.Point(485, 13);
            this.categorybtn.Name = "categorybtn";
            this.categorybtn.Size = new System.Drawing.Size(74, 20);
            this.categorybtn.TabIndex = 6;
            this.categorybtn.TabStop = true;
            this.categorybtn.Text = "Ангилал";
            // 
            // product
            // 
            this.product.AutoSize = true;
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.product.LinkColor = System.Drawing.Color.Black;
            this.product.Location = new System.Drawing.Point(368, 13);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(111, 20);
            this.product.TabIndex = 5;
            this.product.TabStop = true;
            this.product.Text = "Бүтээгдэхүүн";
            // 
            // profile
            // 
            this.profile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profile.AutoSize = true;
            this.profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.profile.LinkColor = System.Drawing.Color.Black;
            this.profile.Location = new System.Drawing.Point(648, 13);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(0, 20);
            this.profile.TabIndex = 4;
            this.profile.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // report
            // 
            this.report.AutoSize = true;
            this.report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.report.LinkColor = System.Drawing.Color.Black;
            this.report.Location = new System.Drawing.Point(262, 13);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(100, 20);
            this.report.TabIndex = 3;
            this.report.TabStop = true;
            this.report.Text = "Борлуулалт";
            // 
            // fact
            // 
            this.fact.AutoSize = true;
            this.fact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fact.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.fact.LinkColor = System.Drawing.Color.Black;
            this.fact.Location = new System.Drawing.Point(195, 13);
            this.fact.Name = "fact";
            this.fact.Size = new System.Drawing.Size(49, 20);
            this.fact.TabIndex = 2;
            this.fact.TabStop = true;
            this.fact.Text = "Шинэ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(144, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bubble tea";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Firstname:";
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(109, 131);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(121, 20);
            this.firstname.TabIndex = 36;
            this.firstname.TextChanged += new System.EventHandler(this.firstname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Lastname:";
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(109, 157);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(121, 20);
            this.lastname.TabIndex = 38;
            this.lastname.TextChanged += new System.EventHandler(this.lastname_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Phone:";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(109, 183);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(121, 20);
            this.phone.TabIndex = 40;
            this.phone.TextChanged += new System.EventHandler(this.phone_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Register number:";
            // 
            // registerNumber
            // 
            this.registerNumber.Location = new System.Drawing.Point(109, 209);
            this.registerNumber.Name = "registerNumber";
            this.registerNumber.Size = new System.Drawing.Size(121, 20);
            this.registerNumber.TabIndex = 42;
            this.registerNumber.TextChanged += new System.EventHandler(this.registerNumber_TextChanged);
            // 
            // profession
            // 
            this.profession.FormattingEnabled = true;
            this.profession.Location = new System.Drawing.Point(109, 235);
            this.profession.Name = "profession";
            this.profession.Size = new System.Drawing.Size(121, 21);
            this.profession.TabIndex = 44;
            this.profession.SelectedIndexChanged += new System.EventHandler(this.profession_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Profession:";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(109, 290);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(121, 64);
            this.address.TabIndex = 46;
            this.address.Text = "";
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 264);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 48;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.profession);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.registerNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.employees);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.name);
            this.Controls.Add(this.panel1);
            this.Name = "employee";
            this.Text = "employee";
            ((System.ComponentModel.ISupportInitialize)(this.employees)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel username;
        private System.Windows.Forms.LinkLabel categorybtn;
        private System.Windows.Forms.LinkLabel product;
        private System.Windows.Forms.LinkLabel profile;
        private System.Windows.Forms.LinkLabel report;
        private System.Windows.Forms.LinkLabel fact;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox registerNumber;
        private System.Windows.Forms.ComboBox profession;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
    }
}