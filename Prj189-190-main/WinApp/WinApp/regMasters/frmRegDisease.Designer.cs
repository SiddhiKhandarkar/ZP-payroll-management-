namespace WinApp.regMasters
{
    partial class frmRegDisease
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
            this.cmb_diseaseType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_regDisease = new System.Windows.Forms.Button();
            this.txt_diseaseRegNo = new System.Windows.Forms.TextBox();
            this.txt_diseaseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_diseaseType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_regDisease);
            this.groupBox1.Controls.Add(this.txt_diseaseRegNo);
            this.groupBox1.Controls.Add(this.txt_diseaseName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 180);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // cmb_diseaseType
            // 
            this.cmb_diseaseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_diseaseType.FormattingEnabled = true;
            this.cmb_diseaseType.Items.AddRange(new object[] {
            "आजार गंभीर आहे",
            "आजार गंभीर नाही"});
            this.cmb_diseaseType.Location = new System.Drawing.Point(103, 92);
            this.cmb_diseaseType.Name = "cmb_diseaseType";
            this.cmb_diseaseType.Size = new System.Drawing.Size(245, 25);
            this.cmb_diseaseType.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "आजाराचा प्रकार";
            // 
            // btn_regDisease
            // 
            this.btn_regDisease.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_regDisease.Location = new System.Drawing.Point(120, 133);
            this.btn_regDisease.Name = "btn_regDisease";
            this.btn_regDisease.Size = new System.Drawing.Size(150, 30);
            this.btn_regDisease.TabIndex = 31;
            this.btn_regDisease.TabStop = false;
            this.btn_regDisease.Text = "नोंदणी करा";
            this.btn_regDisease.UseVisualStyleBackColor = true;
            // 
            // txt_diseaseRegNo
            // 
            this.txt_diseaseRegNo.Location = new System.Drawing.Point(103, 61);
            this.txt_diseaseRegNo.Name = "txt_diseaseRegNo";
            this.txt_diseaseRegNo.Size = new System.Drawing.Size(245, 25);
            this.txt_diseaseRegNo.TabIndex = 1;
            // 
            // txt_diseaseName
            // 
            this.txt_diseaseName.Location = new System.Drawing.Point(103, 30);
            this.txt_diseaseName.Name = "txt_diseaseName";
            this.txt_diseaseName.Size = new System.Drawing.Size(245, 25);
            this.txt_diseaseName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "नोंदणी क्रमांक";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "नाव ";
            // 
            // frmRegDisease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 196);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegDisease";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "आजार नोंदणी";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_regDisease;
        private System.Windows.Forms.TextBox txt_diseaseRegNo;
        private System.Windows.Forms.TextBox txt_diseaseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_diseaseType;
    }
}