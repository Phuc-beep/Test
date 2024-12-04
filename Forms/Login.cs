using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;
using FootBall_Tournament_Management.DAO;
using FootBall_Tournament_Management.NewFolder1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootBall_Tournament_Management.DAO;


namespace FootBall_Tournament_Management.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                button1_Click(sender, e);
            }
            if (e.KeyCode == Keys.Enter && !String.IsNullOrEmpty(txtLogin.Text.Trim())) 
            {
                e.SuppressKeyPress = true; 
                TxtPassword.Focus();       
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLogin.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập usename!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Focus();
                return;
            }
            if (String.IsNullOrEmpty(TxtPassword.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập password!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPassword.Focus();
                return;
            }
            if (!String.IsNullOrEmpty(txtLogin.Text.Trim()) && !String.IsNullOrEmpty(TxtPassword.Text.Trim()))
            {
                MessageBox.Show("Bạn đã đăng nhập thành công hihi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Main_screen main_Screen = new Main_screen();
                main_Screen.Show();
            }
        }
            private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
    }

