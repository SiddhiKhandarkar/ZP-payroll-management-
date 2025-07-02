namespace WinApp.menuMasters
{
    partial class frmDocMaster
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
            this.tblpnl_mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.btn_regDoctor = new System.Windows.Forms.Button();
            this.tblpnl_mainLayout.SuspendLayout();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.pnl_footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblpnl_mainLayout
            // 
            this.tblpnl_mainLayout.ColumnCount = 3;
            this.tblpnl_mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblpnl_mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnl_mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblpnl_mainLayout.Controls.Add(this.pnl_header, 1, 1);
            this.tblpnl_mainLayout.Controls.Add(this.dtgv, 1, 3);
            this.tblpnl_mainLayout.Controls.Add(this.pnl_footer, 1, 4);
            this.tblpnl_mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnl_mainLayout.Location = new System.Drawing.Point(0, 0);
            this.tblpnl_mainLayout.Name = "tblpnl_mainLayout";
            this.tblpnl_mainLayout.RowCount = 6;
            this.tblpnl_mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblpnl_mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblpnl_mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tblpnl_mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnl_mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblpnl_mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblpnl_mainLayout.Size = new System.Drawing.Size(794, 571);
            this.tblpnl_mainLayout.TabIndex = 1;
            // 
            // pnl_header
            // 
            this.pnl_header.Controls.Add(this.txt_search);
            this.pnl_header.Controls.Add(this.label2);
            this.pnl_header.Controls.Add(this.label1);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_header.Location = new System.Drawing.Point(10, 10);
            this.pnl_header.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(774, 35);
            this.pnl_header.TabIndex = 0;
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Location = new System.Drawing.Point(556, 5);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(215, 25);
            this.txt_search.TabIndex = 2;
            this.txt_search.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "वैद्यकीय अधिकारी माहिती";
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv.Location = new System.Drawing.Point(13, 53);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowTemplate.Height = 30;
            this.dtgv.Size = new System.Drawing.Size(768, 455);
            this.dtgv.TabIndex = 1;
            this.dtgv.TabStop = false;
            // 
            // pnl_footer
            // 
            this.pnl_footer.Controls.Add(this.btn_regDoctor);
            this.pnl_footer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_footer.Location = new System.Drawing.Point(10, 511);
            this.pnl_footer.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(774, 50);
            this.pnl_footer.TabIndex = 2;
            // 
            // btn_regDoctor
            // 
            this.btn_regDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_regDoctor.Location = new System.Drawing.Point(651, 3);
            this.btn_regDoctor.Name = "btn_regDoctor";
            this.btn_regDoctor.Size = new System.Drawing.Size(120, 45);
            this.btn_regDoctor.TabIndex = 0;
            this.btn_regDoctor.TabStop = false;
            this.btn_regDoctor.Text = "नवीन वैद्यकीय अधिकारी नोंदणी";
            this.btn_regDoctor.UseVisualStyleBackColor = true;
            this.btn_regDoctor.Click += new System.EventHandler(this.btn_regDoctor_Click);
            // 
            // frmDocMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 571);
            this.Controls.Add(this.tblpnl_mainLayout);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDocMaster";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "दीपस्तंभ - वैद्यकीय अधिकारी";
            this.Load += new System.EventHandler(this.frmDocMaster_Load);
            this.tblpnl_mainLayout.ResumeLayout(false);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.pnl_footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblpnl_mainLayout;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Button btn_regDoctor;
    }
}