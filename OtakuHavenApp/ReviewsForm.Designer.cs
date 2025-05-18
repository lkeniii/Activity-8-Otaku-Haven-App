namespace OtakuHavenApp
{
    partial class ReviewsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvReviews;
        private System.Windows.Forms.TextBox txtUserId, txtProductId, txtRating, txtReview;
        private System.Windows.Forms.Button btnAddReview;
        private System.Windows.Forms.Label lblUserId, lblProductId, lblRating, lblReview;

        private System.Windows.Forms.Label lblFilterUser, lblFilterProduct, lblFilterRating;
        private System.Windows.Forms.TextBox txtFilterUser, txtFilterProduct, txtFilterRating;
        private System.Windows.Forms.Button btnSearchReviews, btnClearFilters;
        private System.Windows.Forms.Button btnExportExcel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewsForm));
            this.dgvReviews = new System.Windows.Forms.DataGridView();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtReview = new System.Windows.Forms.TextBox();
            this.btnAddReview = new System.Windows.Forms.Button();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblReview = new System.Windows.Forms.Label();
            this.lblFilterUser = new System.Windows.Forms.Label();
            this.lblFilterProduct = new System.Windows.Forms.Label();
            this.lblFilterRating = new System.Windows.Forms.Label();
            this.txtFilterUser = new System.Windows.Forms.TextBox();
            this.txtFilterProduct = new System.Windows.Forms.TextBox();
            this.txtFilterRating = new System.Windows.Forms.TextBox();
            this.btnSearchReviews = new System.Windows.Forms.Button();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnhome = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReviews
            // 
            this.dgvReviews.BackgroundColor = System.Drawing.Color.White;
            this.dgvReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReviews.Location = new System.Drawing.Point(23, 304);
            this.dgvReviews.Name = "dgvReviews";
            this.dgvReviews.RowHeadersWidth = 51;
            this.dgvReviews.RowTemplate.Height = 25;
            this.dgvReviews.Size = new System.Drawing.Size(901, 280);
            this.dgvReviews.TabIndex = 0;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(281, 146);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(150, 22);
            this.txtUserId.TabIndex = 1;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(281, 174);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(150, 22);
            this.txtProductId.TabIndex = 2;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(281, 202);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(150, 22);
            this.txtRating.TabIndex = 3;
            // 
            // txtReview
            // 
            this.txtReview.Location = new System.Drawing.Point(281, 230);
            this.txtReview.Name = "txtReview";
            this.txtReview.Size = new System.Drawing.Size(400, 22);
            this.txtReview.TabIndex = 4;
            this.txtReview.TextChanged += new System.EventHandler(this.txtReview_TextChanged);
            // 
            // btnAddReview
            // 
            this.btnAddReview.Location = new System.Drawing.Point(687, 226);
            this.btnAddReview.Name = "btnAddReview";
            this.btnAddReview.Size = new System.Drawing.Size(150, 30);
            this.btnAddReview.TabIndex = 9;
            this.btnAddReview.Text = "Add Review";
            this.btnAddReview.UseVisualStyleBackColor = true;
            this.btnAddReview.Click += new System.EventHandler(this.btnAddReview_Click);
            // 
            // lblUserId
            // 
            this.lblUserId.Location = new System.Drawing.Point(168, 149);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(70, 20);
            this.lblUserId.TabIndex = 5;
            this.lblUserId.Text = "User ID:";
            // 
            // lblProductId
            // 
            this.lblProductId.Location = new System.Drawing.Point(168, 176);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(91, 20);
            this.lblProductId.TabIndex = 6;
            this.lblProductId.Text = "Product ID:";
            // 
            // lblRating
            // 
            this.lblRating.Location = new System.Drawing.Point(168, 202);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(84, 20);
            this.lblRating.TabIndex = 7;
            this.lblRating.Text = "Rating (1-5):";
            // 
            // lblReview
            // 
            this.lblReview.Location = new System.Drawing.Point(168, 230);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(70, 20);
            this.lblReview.TabIndex = 8;
            this.lblReview.Text = "Review:";
            // 
            // lblFilterUser
            // 
            this.lblFilterUser.Location = new System.Drawing.Point(39, 273);
            this.lblFilterUser.Name = "lblFilterUser";
            this.lblFilterUser.Size = new System.Drawing.Size(40, 20);
            this.lblFilterUser.TabIndex = 10;
            this.lblFilterUser.Text = "User:";
            // 
            // lblFilterProduct
            // 
            this.lblFilterProduct.Location = new System.Drawing.Point(191, 275);
            this.lblFilterProduct.Name = "lblFilterProduct";
            this.lblFilterProduct.Size = new System.Drawing.Size(68, 20);
            this.lblFilterProduct.TabIndex = 12;
            this.lblFilterProduct.Text = "Product:";
            // 
            // lblFilterRating
            // 
            this.lblFilterRating.Location = new System.Drawing.Point(380, 275);
            this.lblFilterRating.Name = "lblFilterRating";
            this.lblFilterRating.Size = new System.Drawing.Size(51, 20);
            this.lblFilterRating.TabIndex = 14;
            this.lblFilterRating.Text = "Rating:";
            // 
            // txtFilterUser
            // 
            this.txtFilterUser.Location = new System.Drawing.Point(85, 273);
            this.txtFilterUser.Name = "txtFilterUser";
            this.txtFilterUser.Size = new System.Drawing.Size(100, 22);
            this.txtFilterUser.TabIndex = 11;
            // 
            // txtFilterProduct
            // 
            this.txtFilterProduct.Location = new System.Drawing.Point(258, 273);
            this.txtFilterProduct.Name = "txtFilterProduct";
            this.txtFilterProduct.Size = new System.Drawing.Size(100, 22);
            this.txtFilterProduct.TabIndex = 13;
            // 
            // txtFilterRating
            // 
            this.txtFilterRating.Location = new System.Drawing.Point(439, 273);
            this.txtFilterRating.Name = "txtFilterRating";
            this.txtFilterRating.Size = new System.Drawing.Size(50, 22);
            this.txtFilterRating.TabIndex = 15;
            // 
            // btnSearchReviews
            // 
            this.btnSearchReviews.Location = new System.Drawing.Point(512, 271);
            this.btnSearchReviews.Name = "btnSearchReviews";
            this.btnSearchReviews.Size = new System.Drawing.Size(100, 27);
            this.btnSearchReviews.TabIndex = 16;
            this.btnSearchReviews.Text = "Search";
            this.btnSearchReviews.UseVisualStyleBackColor = true;
            this.btnSearchReviews.Click += new System.EventHandler(this.btnSearchReviews_Click);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Location = new System.Drawing.Point(618, 271);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(100, 27);
            this.btnClearFilters.TabIndex = 17;
            this.btnClearFilters.Text = "Clear Filters";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(761, 272);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(126, 25);
            this.btnExportExcel.TabIndex = 18;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(216, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(530, 34);
            this.label4.TabIndex = 23;
            this.label4.Text = "Product Reviews Management System";
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.Transparent;
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.Color.LightCoral;
            this.btnhome.Location = new System.Drawing.Point(66, 40);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(147, 45);
            this.btnhome.TabIndex = 25;
            this.btnhome.Text = "OtakuHaven";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(32, 40);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(45, 45);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 26;
            this.pictureBox9.TabStop = false;
            // 
            // ReviewsForm
            // 
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(948, 613);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvReviews);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtReview);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblReview);
            this.Controls.Add(this.btnAddReview);
            this.Controls.Add(this.lblFilterUser);
            this.Controls.Add(this.txtFilterUser);
            this.Controls.Add(this.lblFilterProduct);
            this.Controls.Add(this.txtFilterProduct);
            this.Controls.Add(this.lblFilterRating);
            this.Controls.Add(this.txtFilterRating);
            this.Controls.Add(this.btnSearchReviews);
            this.Controls.Add(this.btnClearFilters);
            this.Controls.Add(this.btnExportExcel);
            this.Name = "ReviewsForm";
            this.Text = "Product Reviews";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}
