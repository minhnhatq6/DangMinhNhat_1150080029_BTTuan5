using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Danh sách password cho từng nhóm
        Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>()
        {
            { "Phát triển công nghệ", new List<string>{ "1496", "2673" } },
            { "Nghiên cứu viên", new List<string>{ "7462" } },
            { "Thiết kế mô hình", new List<string>{ "8884", "3842", "3383" } }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDigit_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtPassword.Text += btn.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string pwd = txtPassword.Text;
            string groupName = "Không có";
            string result = "Từ chối!";

            foreach (var g in groups)
            {
                if (g.Value.Contains(pwd))
                {
                    groupName = g.Key;
                    result = "Chấp nhận!";
                    break;
                }
            }

            dgvLog.Rows.Add(DateTime.Now.ToString(), groupName, result);

            txtPassword.Clear();
        }

        private void btnRing_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chuông báo động được kích hoạt!", "RING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
