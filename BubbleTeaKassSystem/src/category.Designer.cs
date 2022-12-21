namespace BubbleTeaKassSystem.src
{
    partial class category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(category));
            this.panel1 = new System.Windows.Forms.Panel();
            this.categorybtn = new System.Windows.Forms.LinkLabel();
            this.product = new System.Windows.Forms.LinkLabel();
            this.profile = new System.Windows.Forms.LinkLabel();
            this.report = new System.Windows.Forms.LinkLabel();
            this.fact = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.categories = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categories)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 3;
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
            this.product.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.product_LinkClicked);
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
            this.fact.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.fact_LinkClicked);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Name:";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(21, 244);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(65, 23);
            this.delete.TabIndex = 24;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(94, 244);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(65, 23);
            this.update.TabIndex = 23;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(165, 244);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(65, 23);
            this.add.TabIndex = 22;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(109, 142);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(121, 20);
            this.name.TabIndex = 20;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // categories
            // 
            this.categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categories.Location = new System.Drawing.Point(489, 105);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(175, 188);
            this.categories.TabIndex = 28;
            this.categories.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.categories_RowHeaderMouseClick);
            this.categories.RowHeaderCellChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.categories_RowHeaderCellChanged);
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
            // category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.categories);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.name);
            this.Controls.Add(this.panel1);
            this.Name = "category";
            this.Text = "category";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel product;
        private System.Windows.Forms.LinkLabel profile;
        private System.Windows.Forms.LinkLabel report;
        private System.Windows.Forms.LinkLabel fact;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.LinkLabel categorybtn;
        private System.Windows.Forms.DataGridView categories;
        private System.Windows.Forms.LinkLabel username;
    }
}