using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label lblDanhSach;
        private Label lblLuaChon;
        private Button btnRight, btnRightAll, btnLeft, btnLeftAll;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBox1 = new ListBox();
            this.listBox2 = new ListBox();
            this.lblDanhSach = new Label();
            this.lblLuaChon = new Label();
            this.btnRight = new Button();
            this.btnRightAll = new Button();
            this.btnLeft = new Button();
            this.btnLeftAll = new Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Location = new Point(30, 50);
            this.listBox1.Size = new Size(150, 200);
            this.listBox1.SelectionMode = SelectionMode.MultiExtended;
            // 
            // listBox2
            // 
            this.listBox2.Location = new Point(300, 50);
            this.listBox2.Size = new Size(150, 200);
            this.listBox2.SelectionMode = SelectionMode.MultiExtended;
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.Text = "Danh sách các mặt hàng";
            this.lblDanhSach.Location = new Point(30, 20);
            this.lblDanhSach.AutoSize = true;
            // 
            // lblLuaChon
            // 
            this.lblLuaChon.Text = "Các mặt hàng lựa chọn";
            this.lblLuaChon.Location = new Point(300, 20);
            this.lblLuaChon.AutoSize = true;
            // 
            // btnRight
            // 
            this.btnRight.Text = ">";
            this.btnRight.Location = new Point(200, 70);
            this.btnRight.Size = new Size(75, 23);
            this.btnRight.Click += new EventHandler(this.btnRight_Click);
            // 
            // btnRightAll
            // 
            this.btnRightAll.Text = ">>";
            this.btnRightAll.Location = new Point(200, 110);
            this.btnRightAll.Size = new Size(75, 23);
            this.btnRightAll.Click += new EventHandler(this.btnRightAll_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Text = "<";
            this.btnLeft.Location = new Point(200, 150);
            this.btnLeft.Size = new Size(75, 23);
            this.btnLeft.Click += new EventHandler(this.btnLeft_Click);
            // 
            // btnLeftAll
            // 
            this.btnLeftAll.Text = "<<";
            this.btnLeftAll.Location = new Point(200, 190);
            this.btnLeftAll.Size = new Size(75, 23);
            this.btnLeftAll.Click += new EventHandler(this.btnLeftAll_Click);
            // 
            // Form1
            // 
            this.ClientSize = new Size(500, 300);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.lblLuaChon);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnRightAll);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnLeftAll);
            this.Text = "Bài 7 - ListBox và Button";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
