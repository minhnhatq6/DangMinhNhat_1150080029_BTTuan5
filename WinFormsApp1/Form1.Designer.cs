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
            this.btnCong = new Button();
            this.btnTru = new Button();
            this.btnNhan = new Button();
            this.btnChia = new Button();
            this.btnXoa = new Button();
            this.btnThoat = new Button();
            this.lblKetQua = new Label();
            this.txtKetQua = new TextBox();
            this.lblTitle = new Label();
            this.txtB = new TextBox();
            this.txtA = new TextBox();
            this.lblA = new Label();
            this.lblB = new Label();
            this.SuspendLayout();
            // 
            // btnCong
            // 
            this.btnCong.Location = new Point(86, 200);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new Size(94, 29);
            this.btnCong.TabIndex = 0;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new Point(200, 200);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new Size(94, 29);
            this.btnTru.TabIndex = 1;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new Point(314, 200);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new Size(94, 29);
            this.btnNhan.TabIndex = 2;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new Point(428, 200);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new Size(94, 29);
            this.btnChia.TabIndex = 3;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new EventHandler(this.btnChia_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new Point(200, 250);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new Size(94, 29);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new Point(314, 250);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new Size(94, 29);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new Point(86, 150);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new Size(63, 20);
            this.lblKetQua.TabIndex = 6;
            this.lblKetQua.Text = "Kết quả:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new Point(200, 147);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new Size(200, 27);
            this.txtKetQua.TabIndex = 7;
            this.txtKetQua.ReadOnly = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new Point(270, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(190, 20);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "THỰC HIỆN PHÉP TÍNH SỐ HỌC";
            // 
            // txtB
            // 
            this.txtB.Location = new Point(200, 100);
            this.txtB.Name = "txtB";
            this.txtB.Size = new Size(200, 27);
            this.txtB.TabIndex = 9;
            // 
            // txtA
            // 
            this.txtA.Location = new Point(200, 57);
            this.txtA.Name = "txtA";
            this.txtA.Size = new Size(200, 27);
            this.txtA.TabIndex = 10;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new Point(86, 60);
            this.lblA.Name = "lblA";
            this.lblA.Size = new Size(66, 20);
            this.lblA.TabIndex = 11;
            this.lblA.Text = "Nhập số a";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new Point(86, 103);
            this.lblB.Name = "lblB";
            this.lblB.Size = new Size(67, 20);
            this.lblB.TabIndex = 12;
            this.lblB.Text = "Nhập số b";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(600, 350);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
        private Button btnXoa;
        private Button btnThoat;
        private Label lblKetQua;
        private TextBox txtKetQua;
        private Label lblTitle;
        private TextBox txtB;
        private TextBox txtA;
        private Label lblA;
        private Label lblB;
    }
}
