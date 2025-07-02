namespace WinApp.regMasters
{
    partial class frmRegFamilyMember
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_memberName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_empName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_memberDOB = new System.Windows.Forms.DateTimePicker();
            this.cmb_memberRelation = new System.Windows.Forms.ComboBox();
            this.btn_regMember = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_regMember);
            this.groupBox1.Controls.Add(this.cmb_memberRelation);
            this.groupBox1.Controls.Add(this.dtp_memberDOB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb_empName);
            this.groupBox1.Controls.Add(this.txt_memberName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 203);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txt_memberName
            // 
            this.txt_memberName.Location = new System.Drawing.Point(120, 61);
            this.txt_memberName.Name = "txt_memberName";
            this.txt_memberName.Size = new System.Drawing.Size(322, 25);
            this.txt_memberName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "कुटुंब सदस्याचे नाव";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "कर्मचारी निवडा";
            // 
            // cmb_empName
            // 
            this.cmb_empName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_empName.FormattingEnabled = true;
            this.cmb_empName.Location = new System.Drawing.Point(120, 30);
            this.cmb_empName.Name = "cmb_empName";
            this.cmb_empName.Size = new System.Drawing.Size(322, 25);
            this.cmb_empName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "सदस्यासोबतचे नाते";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "जन्म दिनांक";
            // 
            // dtp_memberDOB
            // 
            this.dtp_memberDOB.CustomFormat = "yyyy-MM-dd";
            this.dtp_memberDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_memberDOB.Location = new System.Drawing.Point(120, 92);
            this.dtp_memberDOB.Name = "dtp_memberDOB";
            this.dtp_memberDOB.Size = new System.Drawing.Size(124, 25);
            this.dtp_memberDOB.TabIndex = 2;
            // 
            // cmb_memberRelation
            // 
            this.cmb_memberRelation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_memberRelation.FormattingEnabled = true;
            this.cmb_memberRelation.Location = new System.Drawing.Point(120, 123);
            this.cmb_memberRelation.Name = "cmb_memberRelation";
            this.cmb_memberRelation.Size = new System.Drawing.Size(124, 25);
            this.cmb_memberRelation.TabIndex = 3;
            // 
            // btn_regMember
            // 
            this.btn_regMember.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_regMember.Location = new System.Drawing.Point(159, 160);
            this.btn_regMember.Name = "btn_regMember";
            this.btn_regMember.Size = new System.Drawing.Size(150, 30);
            this.btn_regMember.TabIndex = 30;
            this.btn_regMember.TabStop = false;
            this.btn_regMember.Text = "नोंदणी करा";
            this.btn_regMember.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(9, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "उपलब्ध कौटुंबिक माहिती";
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(12, 240);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowTemplate.Height = 30;
            this.dtgv.Size = new System.Drawing.Size(470, 219);
            this.dtgv.TabIndex = 32;
            this.dtgv.TabStop = false;
            // 
            // frmRegFamilyMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 471);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegFamilyMember";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "कुटुंब सदस्य नोंदणी";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_memberName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_empName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_memberRelation;
        private System.Windows.Forms.DateTimePicker dtp_memberDOB;
        private System.Windows.Forms.Button btn_regMember;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgv;
    }
}