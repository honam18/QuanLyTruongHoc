using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TieuLuanXML.Views
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            frmQLSV frm = new frmQLSV();
            frm.ShowDialog();
        }

        private void btnQLGV_Click(object sender, EventArgs e)
        {
            frmQLGV frm = new frmQLGV();
            frm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (tb == DialogResult.Yes) Application.Exit();
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            frmLop frm = new frmLop();
            frm.ShowDialog();
        }
    }
}
