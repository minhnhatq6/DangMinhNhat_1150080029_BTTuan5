using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtNhapSo;
        private Button btnNhap;
        private ListBox lsbDaySo;
        private Button btnTang2, btnChonChanDau, btnChonLeCuoi;
        private Button btnXoaDangChon, btnXoaDau, btnXoaCuoi;
        private Button btnXoaDaySo, btnThoat;
        private Label lblTitle, lblNhapSo, lblChucNang;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.lsbDaySo = new System.Windows.Forms.ListBox();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnChonChanDau = new System.Windows.Forms.Button();
            this.btnChonLeCuoi = new System.Windows.Forms.Button();
            this.btnXoaDangChon = new System.Windows.Forms.Button();
            this.btnXoaDau = new System.Windows.Forms.Button();
            this.btnXoaCuoi = new System.Windows.Forms.Button();
            this.btnXoaDaySo = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNhapSo = new System.Windows.Forms.Label();
            this.lblChucNang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Location = new System.Drawing.Point(150, 65);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(100, 22);
            this.txtNhapSo.TabIndex = 2;
            this.txtNhapSo.KeyDown += new KeyEventHandler(this.txtNhapSo_KeyDown);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(320, 63);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 3;
            this.btnNhap.Text = "Nhập số";
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // lsbDaySo
            // 
            this.lsbDaySo.ItemHeight = 16;
            this.lsbDaySo.Location = new System.Drawing.Point(30, 120);
            this.lsbDaySo.Name = "lsbDaySo";
            this.lsbDaySo.Size = new System.Drawing.Size(150, 196);
            this.lsbDaySo.TabIndex = 4;
            // 
            // btnTang2
            // 
            this.btnTang2.Location = new System.Drawing.Point(220, 130);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(175, 23);
            this.btnTang2.TabIndex = 6;
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);
            // 
            // btnChonChanDau
            // 
            this.btnChonChanDau.Location = new System.Drawing.Point(220, 170);
            this.btnChonChanDau.Name = "btnChonChanDau";
            this.btnChonChanDau.Size = new System.Drawing.Size(175, 23);
            this.btnChonChanDau.TabIndex = 7;
            this.btnChonChanDau.Text = "Chọn số chẵn đầu";
            this.btnChonChanDau.Click += new System.EventHandler(this.btnChonChanDau_Click);
            // 
            // btnChonLeCuoi
            // 
            this.btnChonLeCuoi.Location = new System.Drawing.Point(220, 210);
            this.btnChonLeCuoi.Name = "btnChonLeCuoi";
            this.btnChonLeCuoi.Size = new System.Drawing.Size(175, 23);
            this.btnChonLeCuoi.TabIndex = 8;
            this.btnChonLeCuoi.Text = "Chọn số lẻ cuối";
            this.btnChonLeCuoi.Click += new System.EventHandler(this.btnChonLeCuoi_Click);
            // 
            // btnXoaDangChon
            // 
            this.btnXoaDangChon.Location = new System.Drawing.Point(220, 250);
            this.btnXoaDangChon.Name = "btnXoaDangChon";
            this.btnXoaDangChon.Size = new System.Drawing.Size(175, 23);
            this.btnXoaDangChon.TabIndex = 9;
            this.btnXoaDangChon.Text = "Xóa phần tử đang chọn";
            this.btnXoaDangChon.Click += new System.EventHandler(this.btnXoaDangChon_Click);
            // 
            // btnXoaDau
            // 
            this.btnXoaDau.Location = new System.Drawing.Point(220, 290);
            this.btnXoaDau.Name = "btnXoaDau";
            this.btnXoaDau.Size = new System.Drawing.Size(175, 23);
            this.btnXoaDau.TabIndex = 10;
            this.btnXoaDau.Text = "Xóa phần tử đầu";
            this.btnXoaDau.Click += new System.EventHandler(this.btnXoaDau_Click);
            // 
            // btnXoaCuoi
            // 
            this.btnXoaCuoi.Location = new System.Drawing.Point(220, 330);
            this.btnXoaCuoi.Name = "btnXoaCuoi";
            this.btnXoaCuoi.Size = new System.Drawing.Size(175, 23);
            this.btnXoaCuoi.TabIndex = 11;
            this.btnXoaCuoi.Text = "Xóa phần tử cuối";
            this.btnXoaCuoi.Click += new System.EventHandler(this.btnXoaCuoi_Click);
            // 
            // btnXoaDaySo
            // 
            this.btnXoaDaySo.BackColor = System.Drawing.Color.Gray;
            this.btnXoaDaySo.ForeColor = System.Drawing.Color.White;
            this.btnXoaDaySo.Location = new System.Drawing.Point(150, 380);
            this.btnXoaDaySo.Name = "btnXoaDaySo";
            this.btnXoaDaySo.Size = new System.Drawing.Size(90, 23);
            this.btnXoaDaySo.TabIndex = 12;
            this.btnXoaDaySo.Text = "Xóa dãy số";
            this.btnXoaDaySo.UseVisualStyleBackColor = false;
            this.btnXoaDaySo.Click += new System.EventHandler(this.btnXoaDaySo_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(30, 380);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 23);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Kết thúc ứng dụng";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Teal;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ứng dụng xử lý dãy số";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNhapSo
            // 
            this.lblNhapSo.Location = new System.Drawing.Point(30, 70);
            this.lblNhapSo.Name = "lblNhapSo";
            this.lblNhapSo.Size = new System.Drawing.Size(120, 23);
            this.lblNhapSo.TabIndex = 1;
            this.lblNhapSo.Text = "Nhập số nguyên:";
            // 
            // lblChucNang
            // 
            this.lblChucNang.Location = new System.Drawing.Point(220, 100);
            this.lblChucNang.Name = "lblChucNang";
            this.lblChucNang.Size = new System.Drawing.Size(100, 23);
            this.lblChucNang.TabIndex = 5;
            this.lblChucNang.Text = "Chức năng:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblNhapSo);
            this.Controls.Add(this.txtNhapSo);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.lsbDaySo);
            this.Controls.Add(this.lblChucNang);
            this.Controls.Add(this.btnTang2);
            this.Controls.Add(this.btnChonChanDau);
            this.Controls.Add(this.btnChonLeCuoi);
            this.Controls.Add(this.btnXoaDangChon);
            this.Controls.Add(this.btnXoaDau);
            this.Controls.Add(this.btnXoaCuoi);
            this.Controls.Add(this.btnXoaDaySo);
            this.Controls.Add(this.btnThoat);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
