namespace OtakuHavenApp
{
    partial class PaymentsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Button btnMarkAsPaid;
        private System.Windows.Forms.Button btnRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentsForm));
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.btnMarkAsPaid = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnhome = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPayments
            // 
            this.dgvPayments.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Location = new System.Drawing.Point(22, 207);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.RowHeadersWidth = 51;
            this.dgvPayments.RowTemplate.Height = 25;
            this.dgvPayments.Size = new System.Drawing.Size(898, 379);
            this.dgvPayments.TabIndex = 0;
            // 
            // btnMarkAsPaid
            // 
            this.btnMarkAsPaid.Location = new System.Drawing.Point(22, 158);
            this.btnMarkAsPaid.Name = "btnMarkAsPaid";
            this.btnMarkAsPaid.Size = new System.Drawing.Size(150, 30);
            this.btnMarkAsPaid.TabIndex = 1;
            this.btnMarkAsPaid.Text = "Mark as Paid";
            this.btnMarkAsPaid.UseVisualStyleBackColor = true;
            this.btnMarkAsPaid.Click += new System.EventHandler(this.btnMarkAsPaid_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(192, 158);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 30);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh Payments";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(186, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(581, 34);
            this.label4.TabIndex = 24;
            this.label4.Text = "Payment Processing Management System";
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.Transparent;
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.Color.LightCoral;
            this.btnhome.Location = new System.Drawing.Point(84, 29);
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
            this.pictureBox9.Location = new System.Drawing.Point(33, 29);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(45, 45);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 26;
            this.pictureBox9.TabStop = false;
            // 
            // PaymentsForm
            // 
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(948, 613);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvPayments);
            this.Controls.Add(this.btnMarkAsPaid);
            this.Controls.Add(this.btnRefresh);
            this.Name = "PaymentsForm";
            this.Text = "Payments";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}
