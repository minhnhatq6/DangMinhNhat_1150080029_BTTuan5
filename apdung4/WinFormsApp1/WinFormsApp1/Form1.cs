using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Khởi tạo dữ liệu ban đầu cho listBox1
            listBox1.Items.AddRange(new string[]
            {
                "CPU", "MainBoard", "RAM", "Keyboard", "Mouse", "HDD", "VGA", "NIC", "FAN"
            });
        }

        // Chuyển phần tử được chọn sang listBox2
        private void btnRight_Click(object sender, EventArgs e)
        {
            while (listBox1.SelectedItems.Count > 0)
            {
                object item = listBox1.SelectedItems[0];
                listBox2.Items.Add(item);
                listBox1.Items.Remove(item);
            }
        }

        // Chuyển toàn bộ phần tử sang listBox2
        private void btnRightAll_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items)
                listBox2.Items.Add(item);
            listBox1.Items.Clear();
        }

        // Chuyển phần tử được chọn về listBox1
        private void btnLeft_Click(object sender, EventArgs e)
        {
            while (listBox2.SelectedItems.Count > 0)
            {
                object item = listBox2.SelectedItems[0];
                listBox1.Items.Add(item);
                listBox2.Items.Remove(item);
            }
        }

        // Chuyển toàn bộ phần tử về listBox1
        private void btnLeftAll_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox2.Items)
                listBox1.Items.Add(item);
            listBox2.Items.Clear();
        }
    }
}
