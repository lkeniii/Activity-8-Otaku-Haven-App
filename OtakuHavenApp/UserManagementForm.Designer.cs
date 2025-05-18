
using System.Windows.Forms;

namespace OtakuHavenApp
{
    partial class UserManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvUsers;
        private TextBox txtUsername, txtEmail, txtPassword, txtSearch;
        private ComboBox cmbRole, cmbFilter;
        private Button btnAdd, btnUpdate, btnDelete, btnExportExcel;
        private Label lbl1, lbl2, lbl3, lbl4, lblSearch, lblFilter;
        private string currentUser;
        private string userRole;
        private int currentUserId;

        public UserManagementForm(string username, string role, int userId)
        {
            InitializeComponent();
            currentUser = username;
            userRole = role;
            currentUserId = userId;
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagementForm));
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.btnhome = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(23, 315);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 25;
            this.dgvUsers.Size = new System.Drawing.Size(913, 277);
            this.dgvUsers.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(374, 147);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(182, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(374, 177);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(182, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(374, 205);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(182, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Items.AddRange(new object[] {
            "admin",
            "customer"});
            this.cmbRole.Location = new System.Drawing.Point(375, 231);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(181, 24);
            this.cmbRole.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(609, 158);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(609, 187);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(609, 216);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbl1
            // 
            this.lbl1.Location = new System.Drawing.Point(249, 147);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(100, 23);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Username:";
            // 
            // lbl2
            // 
            this.lbl2.Location = new System.Drawing.Point(249, 177);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(100, 23);
            this.lbl2.TabIndex = 6;
            this.lbl2.Text = "Email:";
            // 
            // lbl3
            // 
            this.lbl3.Location = new System.Drawing.Point(249, 204);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(100, 23);
            this.lbl3.TabIndex = 7;
            this.lbl3.Text = "Password:";
            // 
            // lbl4
            // 
            this.lbl4.Font = new System.Drawing.Font("Dubai", 8.25F);
            this.lbl4.Location = new System.Drawing.Point(249, 232);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(56, 23);
            this.lbl4.TabIndex = 8;
            this.lbl4.Text = "Role:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(83, 276);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(311, 22);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbFilter
            // 
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.Items.AddRange(new object[] {
            "All",
            "admin",
            "customer"});
            this.cmbFilter.Location = new System.Drawing.Point(527, 272);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(121, 24);
            this.cmbFilter.TabIndex = 13;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(12, 275);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(100, 23);
            this.lblSearch.TabIndex = 14;
            this.lblSearch.Text = "Search:";
            // 
            // lblFilter
            // 
            this.lblFilter.Location = new System.Drawing.Point(421, 275);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(100, 23);
            this.lblFilter.TabIndex = 15;
            this.lblFilter.Text = "Filter by Role:";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(715, 272);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(158, 23);
            this.btnExportExcel.TabIndex = 16;
            this.btnExportExcel.Text = "Export to Excel";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(32, 34);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(45, 45);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 19;
            this.pictureBox9.TabStop = false;
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.Transparent;
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.Color.LightCoral;
            this.btnhome.Location = new System.Drawing.Point(65, 34);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(147, 45);
            this.btnhome.TabIndex = 21;
            this.btnhome.Text = "OtakuHaven";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(280, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 34);
            this.label4.TabIndex = 22;
            this.label4.Text = "User Management System";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // UserManagementForm
            // 
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(948, 613);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnhome);
            this.Name = "UserManagementForm";
            this.Text = "User Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private PictureBox pictureBox9;
        private Button btnhome;
        private Label label4;
    }
}
