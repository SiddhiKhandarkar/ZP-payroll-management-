namespace WinApp.regMasters
{
    partial class frmRegHospital
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
            this.txt_hospitalRegNo = new System.Windows.Forms.TextBox();
            this.txt_hospitalName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_regHospital = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_regHospital);
            this.groupBox1.Controls.Add(this.txt_hospitalRegNo);
            this.groupBox1.Controls.Add(this.txt_hospitalName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txt_hospitalRegNo
            // 
            this.txt_hospitalRegNo.Location = new System.Drawing.Point(90, 64);
            this.txt_hospitalRegNo.Name = "txt_hospitalRegNo";
            this.txt_hospitalRegNo.Size = new System.Drawing.Size(258, 25);
            this.txt_hospitalRegNo.TabIndex = 1;
            // 
            // txt_hospitalName
            // 
            this.txt_hospitalName.Location = new System.Drawing.Point(90, 30);
            this.txt_hospitalName.Name = "txt_hospitalName";
            this.txt_hospitalName.Size = new System.Drawing.Size(258, 25);
            this.txt_hospitalName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "नोंदणी क्रमांक";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "नाव ";
            // 
            // btn_regHospital
            // 
            this.btn_regHospital.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_regHospital.Location = new System.Drawing.Point(110, 107);
            this.btn_regHospital.Name = "btn_regHospital";
            this.btn_regHospital.Size = new System.Drawing.Size(150, 30);
            this.btn_regHospital.TabIndex = 31;
            this.btn_regHospital.TabStop = false;
            this.btn_regHospital.Text = "नोंदणी करा";
            this.btn_regHospital.UseVisualStyleBackColor = true;
            // 
            // frmRegHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 171);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegHospital";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "दवाखाना नोंदणी";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_hospitalRegNo;
        private System.Windows.Forms.TextBox txt_hospitalName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_regHospital;
    }
}