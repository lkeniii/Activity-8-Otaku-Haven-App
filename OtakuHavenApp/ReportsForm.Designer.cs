namespace OtakuHavenApp
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Label lblFilter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnhome = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReport
            // 
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(23, 207);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 25;
            this.dgvReport.Size = new System.Drawing.Size(895, 379);
            this.dgvReport.TabIndex = 0;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(263, 161);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(221, 22);
            this.txtFilter.TabIndex = 2;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(490, 160);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 25);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Apply Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(696, 157);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(150, 25);
            this.btnExportExcel.TabIndex = 4;
            this.btnExportExcel.Text = "Export to Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.Location = new System.Drawing.Point(67, 160);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(190, 25);
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Search (Status/Date/Amount):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(161, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(668, 34);
            this.label4.TabIndex = 24;
            this.label4.Text = "Customer Order Summary  Management System";
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.Transparent;
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.Color.LightCoral;
            this.btnhome.Location = new System.Drawing.Point(72, 42);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(147, 45);
            this.btnhome.TabIndex = 25;
            this.btnhome.Text = "OtakuHaven";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click_1);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(37, 42);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(45, 45);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 26;
            this.pictureBox9.TabStop = false;
            // 
            // ReportsForm
            // 
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(948, 613);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnExportExcel);
            this.Name = "ReportsForm";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}
