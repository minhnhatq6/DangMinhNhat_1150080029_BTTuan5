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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.groupBoxKeyboard = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnRing = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLog = new System.Windows.Forms.Label();
            this.groupBoxKeyboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 15);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(63, 15);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(90, 12);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // groupBoxKeyboard
            // 
            this.groupBoxKeyboard.Controls.Add(this.btn9);
            this.groupBoxKeyboard.Controls.Add(this.btn8);
            this.groupBoxKeyboard.Controls.Add(this.btn7);
            this.groupBoxKeyboard.Controls.Add(this.btn6);
            this.groupBoxKeyboard.Controls.Add(this.btn5);
            this.groupBoxKeyboard.Controls.Add(this.btn4);
            this.groupBoxKeyboard.Controls.Add(this.btn3);
            this.groupBoxKeyboard.Controls.Add(this.btn2);
            this.groupBoxKeyboard.Controls.Add(this.btn1);
            this.groupBoxKeyboard.Controls.Add(this.btnRing);
            this.groupBoxKeyboard.Controls.Add(this.btnEnter);
            this.groupBoxKeyboard.Controls.Add(this.btnClear);
            this.groupBoxKeyboard.Location = new System.Drawing.Point(12, 50);
            this.groupBoxKeyboard.Name = "groupBoxKeyboard";
            this.groupBoxKeyboard.Size = new System.Drawing.Size(400, 150);
            this.groupBoxKeyboard.TabIndex = 2;
            this.groupBoxKeyboard.TabStop = false;
            this.groupBoxKeyboard.Text = "Keyboard:";
            // 
            // Button digits
            int btnSize = 40;
            int margin = 10;
            int startX = 10;
            int startY = 20;

            this.btn1.Location = new System.Drawing.Point(startX, startY);
            this.btn1.Size = new System.Drawing.Size(btnSize, btnSize);
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.btnDigit_Click);

            this.btn2.Location = new System.Drawing.Point(startX + (btnSize + margin), startY);
            this.btn2.Size = new System.Drawing.Size(btnSize, btnSize);
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.btnDigit_Click);

            this.btn3.Location = new System.Drawing.Point(startX + 2 * (btnSize + margin), startY);
            this.btn3.Size = new System.Drawing.Size(btnSize, btnSize);
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.btnDigit_Click);

            this.btn4.Location = new System.Drawing.Point(startX, startY + (btnSize + margin));
            this.btn4.Size = new System.Drawing.Size(btnSize, btnSize);
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.btnDigit_Click);

            this.btn5.Location = new System.Drawing.Point(startX + (btnSize + margin), startY + (btnSize + margin));
            this.btn5.Size = new System.Drawing.Size(btnSize, btnSize);
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.btnDigit_Click);

            this.btn6.Location = new System.Drawing.Point(startX + 2 * (btnSize + margin), startY + (btnSize + margin));
            this.btn6.Size = new System.Drawing.Size(btnSize, btnSize);
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.btnDigit_Click);

            this.btn7.Location = new System.Drawing.Point(startX, startY + 2 * (btnSize + margin));
            this.btn7.Size = new System.Drawing.Size(btnSize, btnSize);
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.btnDigit_Click);

            this.btn8.Location = new System.Drawing.Point(startX + (btnSize + margin), startY + 2 * (btnSize + margin));
            this.btn8.Size = new System.Drawing.Size(btnSize, btnSize);
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.btnDigit_Click);

            this.btn9.Location = new System.Drawing.Point(startX + 2 * (btnSize + margin), startY + 2 * (btnSize + margin));
            this.btn9.Size = new System.Drawing.Size(btnSize, btnSize);
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.btnDigit_Click);

            // btnClear
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.Location = new System.Drawing.Point(300, startY);
            this.btnClear.Size = new System.Drawing.Size(80, btnSize);
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // btnEnter
            this.btnEnter.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEnter.Location = new System.Drawing.Point(300, startY + (btnSize + margin));
            this.btnEnter.Size = new System.Drawing.Size(80, btnSize);
            this.btnEnter.Text = "Enter";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);

            // btnRing
            this.btnRing.BackColor = System.Drawing.Color.Red;
            this.btnRing.Location = new System.Drawing.Point(300, startY + 2 * (btnSize + margin));
            this.btnRing.Size = new System.Drawing.Size(80, btnSize);
            this.btnRing.Text = "RING";
            this.btnRing.Click += new System.EventHandler(this.btnRing_Click);

            // dgvLog
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTime,
            this.colGroup,
            this.colResult});
            this.dgvLog.Location = new System.Drawing.Point(12, 230);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.RowTemplate.Height = 25;
            this.dgvLog.Size = new System.Drawing.Size(400, 150);
            this.dgvLog.TabIndex = 3;
            // 
            // colTime
            // 
            this.colTime.HeaderText = "Ngày giờ";
            this.colTime.Name = "colTime";
            this.colTime.Width = 120;
            // 
            // colGroup
            // 
            this.colGroup.HeaderText = "Nhóm";
            this.colGroup.Name = "colGroup";
            this.colGroup.Width = 120;
            // 
            // colResult
            // 
            this.colResult.HeaderText = "Kết quả";
            this.colResult.Name = "colResult";
            this.colResult.Width = 120;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(12, 210);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(63, 15);
            this.lblLog.TabIndex = 4;
            this.lblLog.Text = "Login Log:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(430, 400);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.dgvLog);
            this.Controls.Add(this.groupBoxKeyboard);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Name = "Form1";
            this.Text = "Security Panel";
            this.groupBoxKeyboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPassword;
        private Label lblPassword;
        private GroupBox groupBoxKeyboard;
        private Button btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9;
        private Button btnClear, btnEnter, btnRing;
        private DataGridView dgvLog;
        private DataGridViewTextBoxColumn colTime;
        private DataGridViewTextBoxColumn colGroup;
        private DataGridViewTextBoxColumn colResult;
        private Label lblLog;
    }
}
