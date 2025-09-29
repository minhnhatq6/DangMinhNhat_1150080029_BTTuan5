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
            lblTitle = new Label();
            lblCustomer = new Label();
            txtCustomer = new TextBox();
            grpServices = new GroupBox();
            chkLayCaoRang = new CheckBox();
            lblGiaLayCao = new Label();
            chkTayTrang = new CheckBox();
            lblGiaTayTrang = new Label();
            chkHanRang = new CheckBox();
            lblGiaHanRang = new Label();
            numHanRang = new NumericUpDown();
            chkBeRang = new CheckBox();
            lblGiaBeRang = new Label();
            numBeRang = new NumericUpDown();
            chkBocRang = new CheckBox();
            lblGiaBocRang = new Label();
            numBocRang = new NumericUpDown();
            grpFunction = new GroupBox();
            btnTinhTien = new Button();
            txtTongTien = new TextBox();
            btnThoat = new Button();
            grpServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numHanRang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBeRang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBocRang).BeginInit();
            grpFunction.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.LimeGreen;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(530, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "PHÒNG KHÁM NHA KHOA HẢI ÂU";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(12, 60);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(114, 20);
            lblCustomer.TabIndex = 1;
            lblCustomer.Text = "Tên khách hàng:";
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(132, 57);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(250, 27);
            txtCustomer.TabIndex = 2;
            // 
            // grpServices
            // 
            grpServices.Controls.Add(chkLayCaoRang);
            grpServices.Controls.Add(lblGiaLayCao);
            grpServices.Controls.Add(chkTayTrang);
            grpServices.Controls.Add(lblGiaTayTrang);
            grpServices.Controls.Add(chkHanRang);
            grpServices.Controls.Add(lblGiaHanRang);
            grpServices.Controls.Add(numHanRang);
            grpServices.Controls.Add(chkBeRang);
            grpServices.Controls.Add(lblGiaBeRang);
            grpServices.Controls.Add(numBeRang);
            grpServices.Controls.Add(chkBocRang);
            grpServices.Controls.Add(lblGiaBocRang);
            grpServices.Controls.Add(numBocRang);
            grpServices.Location = new Point(12, 100);
            grpServices.Name = "grpServices";
            grpServices.Size = new Size(530, 170);
            grpServices.TabIndex = 3;
            grpServices.TabStop = false;
            grpServices.Text = "Dịch vụ tại phòng khám:";
            // 
            // chkLayCaoRang
            // 
            chkLayCaoRang.Location = new Point(20, 25);
            chkLayCaoRang.Name = "chkLayCaoRang";
            chkLayCaoRang.Size = new Size(104, 24);
            chkLayCaoRang.TabIndex = 0;
            chkLayCaoRang.Text = "Lấy cao răng";
            // 
            // lblGiaLayCao
            // 
            lblGiaLayCao.Location = new Point(200, 25);
            lblGiaLayCao.Name = "lblGiaLayCao";
            lblGiaLayCao.Size = new Size(140, 23);
            lblGiaLayCao.TabIndex = 1;
            lblGiaLayCao.Text = "50.000đ/2 hàm";
            // 
            // chkTayTrang
            // 
            chkTayTrang.Location = new Point(20, 50);
            chkTayTrang.Name = "chkTayTrang";
            chkTayTrang.Size = new Size(104, 24);
            chkTayTrang.TabIndex = 2;
            chkTayTrang.Text = "Tẩy trắng răng";
            // 
            // lblGiaTayTrang
            // 
            lblGiaTayTrang.Location = new Point(200, 50);
            lblGiaTayTrang.Name = "lblGiaTayTrang";
            lblGiaTayTrang.Size = new Size(140, 23);
            lblGiaTayTrang.TabIndex = 3;
            lblGiaTayTrang.Text = "100.000đ/2 hàm";
            // 
            // chkHanRang
            // 
            chkHanRang.Location = new Point(20, 75);
            chkHanRang.Name = "chkHanRang";
            chkHanRang.Size = new Size(104, 24);
            chkHanRang.TabIndex = 4;
            chkHanRang.Text = "Hàn răng";
            // 
            // lblGiaHanRang
            // 
            lblGiaHanRang.Location = new Point(200, 75);
            lblGiaHanRang.Name = "lblGiaHanRang";
            lblGiaHanRang.Size = new Size(122, 23);
            lblGiaHanRang.TabIndex = 5;
            lblGiaHanRang.Text = "100.000đ/1 răng";
            // 
            // numHanRang
            // 
            numHanRang.Location = new Point(350, 75);
            numHanRang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numHanRang.Name = "numHanRang";
            numHanRang.Size = new Size(120, 27);
            numHanRang.TabIndex = 6;
            numHanRang.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // chkBeRang
            // 
            chkBeRang.Location = new Point(20, 100);
            chkBeRang.Name = "chkBeRang";
            chkBeRang.Size = new Size(104, 24);
            chkBeRang.TabIndex = 7;
            chkBeRang.Text = "Bẻ răng";
            // 
            // lblGiaBeRang
            // 
            lblGiaBeRang.Location = new Point(200, 100);
            lblGiaBeRang.Name = "lblGiaBeRang";
            lblGiaBeRang.Size = new Size(122, 23);
            lblGiaBeRang.TabIndex = 8;
            lblGiaBeRang.Text = "10.000đ/1 răng";
            // 
            // numBeRang
            // 
            numBeRang.Location = new Point(350, 100);
            numBeRang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numBeRang.Name = "numBeRang";
            numBeRang.Size = new Size(120, 27);
            numBeRang.TabIndex = 9;
            numBeRang.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // chkBocRang
            // 
            chkBocRang.Location = new Point(20, 125);
            chkBocRang.Name = "chkBocRang";
            chkBocRang.Size = new Size(104, 24);
            chkBocRang.TabIndex = 10;
            chkBocRang.Text = "Bọc răng";
            // 
            // lblGiaBocRang
            // 
            lblGiaBocRang.Location = new Point(200, 125);
            lblGiaBocRang.Name = "lblGiaBocRang";
            lblGiaBocRang.Size = new Size(144, 23);
            lblGiaBocRang.TabIndex = 11;
            lblGiaBocRang.Text = "1.000.000đ/1 răng";
            // 
            // numBocRang
            // 
            numBocRang.Location = new Point(350, 125);
            numBocRang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numBocRang.Name = "numBocRang";
            numBocRang.Size = new Size(120, 27);
            numBocRang.TabIndex = 12;
            numBocRang.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // grpFunction
            // 
            grpFunction.Controls.Add(btnTinhTien);
            grpFunction.Controls.Add(txtTongTien);
            grpFunction.Controls.Add(btnThoat);
            grpFunction.Location = new Point(12, 280);
            grpFunction.Name = "grpFunction";
            grpFunction.Size = new Size(530, 70);
            grpFunction.TabIndex = 4;
            grpFunction.TabStop = false;
            grpFunction.Text = "Chức năng:";
            // 
            // btnTinhTien
            // 
            btnTinhTien.Location = new Point(20, 30);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(100, 30);
            btnTinhTien.TabIndex = 0;
            btnTinhTien.Text = "Tính tiền";
            btnTinhTien.Click += btnTinhTien_Click;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(140, 34);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(200, 27);
            txtTongTien.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(360, 30);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 30);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(560, 370);
            Controls.Add(lblTitle);
            Controls.Add(lblCustomer);
            Controls.Add(txtCustomer);
            Controls.Add(grpServices);
            Controls.Add(grpFunction);
            Name = "Form1";
            Text = "Dental Clinic";
            grpServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numHanRang).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBeRang).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBocRang).EndInit();
            grpFunction.ResumeLayout(false);
            grpFunction.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle, lblCustomer;
        private TextBox txtCustomer;
        private GroupBox grpServices, grpFunction;
        private CheckBox chkLayCaoRang, chkTayTrang, chkHanRang, chkBeRang, chkBocRang;
        private Label lblGiaLayCao, lblGiaTayTrang, lblGiaHanRang, lblGiaBeRang, lblGiaBocRang;
        private NumericUpDown numHanRang, numBeRang, numBocRang;
        private Button btnTinhTien, btnThoat;
        private TextBox txtTongTien;
    }
}
