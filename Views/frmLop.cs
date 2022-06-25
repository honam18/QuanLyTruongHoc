using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TieuLuanXML.Models;

namespace TieuLuanXML.Views
{
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
            LoadLop();
        }
        private void LoadLop()
        {
            lvLop.FullRowSelect = true;
            lvLop.GridLines = true;
            lvLop.View = View.Details;
            lvLop.Columns.Add("Khoa", 200);
            lvLop.Columns.Add("Lớp", 200);
            lvLop.Columns.Add("Sỉ số", 200);
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            Lop l = new Lop(txtKhoa.Text, txtMaLop.Text, txtSiSo.Text);
            Lop frms = new Lop();
            frms.Them(l);
            frmLop_Load(sender, e);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Lop l = new Lop(txtKhoa.Text, txtMaLop.Text, txtSiSo.Text);
            Lop frms = new Lop();
            frms.Sua(l);
            frmLop_Load(sender, e);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Lop l = new Lop(txtKhoa.Text, txtMaLop.Text, txtSiSo.Text);
            l.MaLop = txtMaLop.Text;
            Lop frms = new Lop();
            frms.Xoa(l);
            frmLop_Load(sender, e);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            Lop frms = new Lop();
            var list = frms.Search(txtSearch.Text);
            lvLop.Items.Clear();
            foreach (var item in list)
            {
                ListViewItem it = new ListViewItem(item.MaLop);
                it.SubItems.Add(item.Khoa);
                it.SubItems.Add(item.SiSo);
                lvLop.Items.Add(it);
            }
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            lvLop.Items.Clear();
            Lop frms = new Lop();
            List<Lop> listLop = frms.Load();
            foreach (var item in listLop)
            {
                ListViewItem it = new ListViewItem(item.MaLop);
                it.SubItems.Add(item.Khoa);
                it.SubItems.Add(item.SiSo);
                lvLop.Items.Add(it);
            }
        }
    }
}
