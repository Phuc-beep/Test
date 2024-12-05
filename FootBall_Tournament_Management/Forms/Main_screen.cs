using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootBall_Tournament_Management.Forms
{
    public partial class Main_screen : Form
    {
        public Main_screen()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Main_screen_Load(object sender, EventArgs e)
        {

        }
        private void Main_screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!panel5.Controls.Contains(Danh_Sách_Đội_Bóng.Instance))
            {
                panel5.Controls.Add(Danh_Sách_Đội_Bóng.Instance);
                Danh_Sách_Đội_Bóng.Instance.Dock = DockStyle.Fill;
                Danh_Sách_Đội_Bóng.Instance.BringToFront();
            }
            else
                Danh_Sách_Đội_Bóng.Instance.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
