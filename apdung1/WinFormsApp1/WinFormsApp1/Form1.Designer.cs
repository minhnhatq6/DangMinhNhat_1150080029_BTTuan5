namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBoxNhap = new System.Windows.Forms.GroupBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.groupBoxChon = new System.Windows.Forms.GroupBox();
            this.rdbBSCNN = new System.Windows.Forms.RadioButton();
            this.rdbUSCLN = new System.Windows.Forms.RadioButton();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBoxNhap.SuspendLayout();
            this.groupBoxChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNhap
            // 
            this.groupBoxNhap.BackColor = System.Drawing.Color.LightGreen;
            this.groupBoxNhap.Controls.Add(this.txtB);
            this.groupBoxNhap.Controls.Add(this.txtA);
            this.groupBoxNhap.Controls.Add(this.lblB);
            this.groupBoxNhap.Controls.Add(this.lblA);
            this.groupBoxNhap.Location = new System.Drawing.Point(12, 12);
            this.groupBoxNhap.Name = "groupBoxNhap";
            this.groupBoxNhap.Size = new System.Drawing.Size(300, 100);
            this.groupBoxNhap.TabIndex = 0;
            this.groupBoxNhap.TabStop = false;
            this.groupBoxNhap.Text = "Nhập dữ liệu:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(120, 60);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(150, 23);
            this.txtB.TabIndex = 3;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(120, 30);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(150, 23);
            this.txtA.TabIndex = 2;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(20, 63);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(77, 15);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "Số nguyên b:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(20, 33);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(76, 15);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Số nguyên a:";
            // 
            // groupBoxChon
            // 
            this.groupBoxChon.Controls.Add(this.rdbBSCNN);
            this.groupBoxChon.Controls.Add(this.rdbUSCLN);
            this.groupBoxChon.Location = new System.Drawing.Point(330, 12);
            this.groupBoxChon.Name = "groupBoxChon";
            this.groupBoxChon.Size = new System.Drawing.Size(150, 100);
            this.groupBoxChon.TabIndex = 1;
            this.groupBoxChon.TabStop = false;
            this.groupBoxChon.Text = "Tùy chọn:";
            // 
            // rdbBSCNN
            // 
            this.rdbBSCNN.AutoSize = true;
            this.rdbBSCNN.Location = new System.Drawing.Point(20, 60);
            this.rdbBSCNN.Name = "rdbBSCNN";
            this.rdbBSCNN.Size = new System.Drawing.Size(62, 19);
            this.rdbBSCNN.TabIndex = 1;
            this.rdbBSCNN.Text = "BSCNN";
            this.rdbBSCNN.UseVisualStyleBackColor = true;
            // 
            // rdbUSCLN
            // 
            this.rdbUSCLN.AutoSize = true;
            this.rdbUSCLN.Checked = true;
            this.rdbUSCLN.Location = new System.Drawing.Point(20, 30);
            this.rdbUSCLN.Name = "rdbUSCLN";
            this.rdbUSCLN.Size = new System.Drawing.Size(62, 19);
            this.rdbUSCLN.TabIndex = 0;
            this.rdbUSCLN.TabStop = true;
            this.rdbUSCLN.Text = "USCLN";
            this.rdbUSCLN.UseVisualStyleBackColor = true;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(12, 140);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(47, 15);
            this.lblKetQua.TabIndex = 2;
            this.lblKetQua.Text = "Kết quả:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(80, 137);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(200, 23);
            this.txtKetQua.TabIndex = 3;
            this.txtKetQua.ReadOnly = true;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(330, 135);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(70, 25);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(410, 135);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(70, 25);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.groupBoxChon);
            this.Controls.Add(this.groupBoxNhap);
            this.Name = "Form1";
            this.Text = "Tìm USCLN và BSCNN của số nguyên a và b";
            this.groupBoxNhap.ResumeLayout(false);
            this.groupBoxNhap.PerformLayout();
            this.groupBoxChon.ResumeLayout(false);
            this.groupBoxChon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private GroupBox groupBoxNhap;
        private TextBox txtB;
        private TextBox txtA;
        private Label lblB;
        private Label lblA;
        private GroupBox groupBoxChon;
        private RadioButton rdbBSCNN;
        private RadioButton rdbUSCLN;
        private Label lblKetQua;
        private TextBox txtKetQua;
        private Button btnTim;
        private Button btnThoat;
    }
}
