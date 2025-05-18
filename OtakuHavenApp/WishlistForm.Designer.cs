namespace OtakuHavenApp
{
    partial class WishlistForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvWishlist;
        private System.Windows.Forms.TextBox txtUserId, txtProductId;
        private System.Windows.Forms.Label lblUserId, lblProductId;

        private System.Windows.Forms.Label lblFilterUser, lblFilterProduct;
        private System.Windows.Forms.TextBox txtFilterUser, txtFilterProduct;
        private System.Windows.Forms.Button btnAddToWishlist, btnSearchWishlist, btnClearFilters, btnExportExcel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WishlistForm));
            this.dgvWishlist = new System.Windows.Forms.DataGridView();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblFilterUser = new System.Windows.Forms.Label();
            this.lblFilterProduct = new System.Windows.Forms.Label();
            this.txtFilterUser = new System.Windows.Forms.TextBox();
            this.txtFilterProduct = new System.Windows.Forms.TextBox();
            this.btnAddToWishlist = new System.Windows.Forms.Button();
            this.btnSearchWishlist = new System.Windows.Forms.Button();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnhome = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWishlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWishlist
            // 
            this.dgvWishlist.BackgroundColor = System.Drawing.Color.White;
            this.dgvWishlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWishlist.Location = new System.Drawing.Point(32, 293);
            this.dgvWishlist.Name = "dgvWishlist";
            this.dgvWishlist.RowHeadersWidth = 51;
            this.dgvWishlist.RowTemplate.Height = 25;
            this.dgvWishlist.Size = new System.Drawing.Size(890, 290);
            this.dgvWishlist.TabIndex = 0;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(416, 141);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(150, 22);
            this.txtUserId.TabIndex = 1;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(416, 178);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(150, 22);
            this.txtProductId.TabIndex = 2;
            // 
            // lblUserId
            // 
            this.lblUserId.Location = new System.Drawing.Point(324, 141);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(72, 23);
            this.lblUserId.TabIndex = 3;
            this.lblUserId.Text = "User ID:";
            // 
            // lblProductId
            // 
            this.lblProductId.Location = new System.Drawing.Point(324, 177);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(78, 23);
            this.lblProductId.TabIndex = 4;
            this.lblProductId.Text = "Product ID:";
            // 
            // lblFilterUser
            // 
            this.lblFilterUser.Location = new System.Drawing.Point(62, 260);
            this.lblFilterUser.Name = "lblFilterUser";
            this.lblFilterUser.Size = new System.Drawing.Size(45, 22);
            this.lblFilterUser.TabIndex = 6;
            this.lblFilterUser.Text = "User:";
            // 
            // lblFilterProduct
            // 
            this.lblFilterProduct.Location = new System.Drawing.Point(283, 260);
            this.lblFilterProduct.Name = "lblFilterProduct";
            this.lblFilterProduct.Size = new System.Drawing.Size(65, 23);
            this.lblFilterProduct.TabIndex = 8;
            this.lblFilterProduct.Text = "Product:";
            // 
            // txtFilterUser
            // 
            this.txtFilterUser.Location = new System.Drawing.Point(101, 260);
            this.txtFilterUser.Name = "txtFilterUser";
            this.txtFilterUser.Size = new System.Drawing.Size(150, 22);
            this.txtFilterUser.TabIndex = 7;
            // 
            // txtFilterProduct
            // 
            this.txtFilterProduct.Location = new System.Drawing.Point(342, 260);
            this.txtFilterProduct.Name = "txtFilterProduct";
            this.txtFilterProduct.Size = new System.Drawing.Size(150, 22);
            this.txtFilterProduct.TabIndex = 9;
            // 
            // btnAddToWishlist
            // 
            this.btnAddToWishlist.Location = new System.Drawing.Point(416, 216);
            this.btnAddToWishlist.Name = "btnAddToWishlist";
            this.btnAddToWishlist.Size = new System.Drawing.Size(150, 30);
            this.btnAddToWishlist.TabIndex = 5;
            this.btnAddToWishlist.Text = "Add to Wishlist";
            this.btnAddToWishlist.UseVisualStyleBackColor = true;
            this.btnAddToWishlist.Click += new System.EventHandler(this.btnAddToWishlist_Click);
            // 
            // btnSearchWishlist
            // 
            this.btnSearchWishlist.Location = new System.Drawing.Point(540, 260);
            this.btnSearchWishlist.Name = "btnSearchWishlist";
            this.btnSearchWishlist.Size = new System.Drawing.Size(80, 27);
            this.btnSearchWishlist.TabIndex = 10;
            this.btnSearchWishlist.Text = "Search";
            this.btnSearchWishlist.UseVisualStyleBackColor = true;
            this.btnSearchWishlist.Click += new System.EventHandler(this.btnSearchWishlist_Click);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Location = new System.Drawing.Point(626, 260);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(90, 27);
            this.btnClearFilters.TabIndex = 11;
            this.btnClearFilters.Text = "Clear Filters";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(760, 260);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(117, 27);
            this.btnExportExcel.TabIndex = 12;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(268, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(404, 34);
            this.label4.TabIndex = 24;
            this.label4.Text = "Wishlist Management System";
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.Transparent;
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.Color.LightCoral;
            this.btnhome.Location = new System.Drawing.Point(76, 32);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(147, 45);
            this.btnhome.TabIndex = 26;
            this.btnhome.Text = "OtakuHaven";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(37, 32);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(45, 45);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 27;
            this.pictureBox9.TabStop = false;
            // 
            // WishlistForm
            // 
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(948, 613);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvWishlist);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.btnAddToWishlist);
            this.Controls.Add(this.lblFilterUser);
            this.Controls.Add(this.txtFilterUser);
            this.Controls.Add(this.lblFilterProduct);
            this.Controls.Add(this.txtFilterProduct);
            this.Controls.Add(this.btnSearchWishlist);
            this.Controls.Add(this.btnClearFilters);
            this.Controls.Add(this.btnExportExcel);
            this.Name = "WishlistForm";
            this.Text = "Wishlist";
            this.Load += new System.EventHandler(this.WishlistForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWishlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}
