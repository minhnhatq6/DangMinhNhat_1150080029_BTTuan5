using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Xử lý khi bấm nút Nhập số hoặc nhấn Enter
        private void btnNhap_Click(object sender, EventArgs e)
        {
            ThemSo();
        }

        private void txtNhapSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ThemSo();
                e.SuppressKeyPress = true;
            }
        }

        private void ThemSo()
        {
            if (int.TryParse(txtNhapSo.Text.Trim(), out int so))
            {
                lsbDaySo.Items.Add(so);
                txtNhapSo.Clear();
                txtNhapSo.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Thông báo");
                txtNhapSo.SelectAll();
                txtNhapSo.Focus();
            }
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                int so = Convert.ToInt32(lsbDaySo.Items[i]);
                lsbDaySo.Items[i] = so + 2;
            }
        }

        private void btnChonChanDau_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                int so = Convert.ToInt32(lsbDaySo.Items[i]);
                if (so % 2 == 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    return;
                }
            }
        }

        private void btnChonLeCuoi_Click(object sender, EventArgs e)
        {
            for (int i = lsbDaySo.Items.Count - 1; i >= 0; i--)
            {
                int so = Convert.ToInt32(lsbDaySo.Items[i]);
                if (so % 2 != 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    return;
                }
            }
        }

        private void btnXoaDangChon_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.SelectedIndex >= 0)
                lsbDaySo.Items.RemoveAt(lsbDaySo.SelectedIndex);
        }

        private void btnXoaDau_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
                lsbDaySo.Items.RemoveAt(0);
        }

        private void btnXoaCuoi_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
                lsbDaySo.Items.RemoveAt(lsbDaySo.Items.Count - 1);
        }

        private void btnXoaDaySo_Click(object sender, EventArgs e)
        {
            lsbDaySo.Items.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
