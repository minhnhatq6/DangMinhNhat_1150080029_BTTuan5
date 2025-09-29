namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int USCLN(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        private int BSCNN(int a, int b)
        {
            return (a * b) / USCLN(a, b);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);

                if (rdbUSCLN.Checked)
                {
                    txtKetQua.Text = USCLN(a, b).ToString();
                }
                else if (rdbBSCNN.Checked)
                {
                    txtKetQua.Text = BSCNN(a, b).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
