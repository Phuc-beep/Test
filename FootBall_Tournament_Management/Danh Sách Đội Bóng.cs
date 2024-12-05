using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootBall_Tournament_Management
{
    public partial class Danh_Sách_Đội_Bóng : UserControl
    {
        public static Danh_Sách_Đội_Bóng _instance;
        public static Danh_Sách_Đội_Bóng Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Danh_Sách_Đội_Bóng();
                return _instance;
            }
        }
        public Danh_Sách_Đội_Bóng()
        {
            InitializeComponent();
        }

        private void Danh_Sách_Đội_Bóng_Load(object sender, EventArgs e)
        {

        }
    }
}
