namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomer.Text))
            {
                MessageBox.Show("Tên khách hàng không được để trống!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomer.Focus();
                return;
            }

            int total = 0;

            if (chkLayCaoRang.Checked) total += 50000;
            if (chkTayTrang.Checked) total += 100000;
            if (chkHanRang.Checked) total += 100000 * (int)numHanRang.Value;
            if (chkBeRang.Checked) total += 10000 * (int)numBeRang.Value;
            if (chkBocRang.Checked) total += 1000000 * (int)numBocRang.Value;

            // Hiển thị kết quả ngay trên form
            txtTongTien.Text = total.ToString("N0") + " đ";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
