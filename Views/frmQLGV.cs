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
    public partial class frmQLGV : Form
    {
        public frmQLGV()
        {
            InitializeComponent();
            LoadGiaoVien();
        }
        private void LoadGiaoVien()
        {
            cbbLop.Items.Add("LTM1");
            cbbLop.Items.Add("LTM2");
            cbbLop.Items.Add("QTM");
            cbbLop.Items.Add("TKW");
            cbbLop.Items.Add("ANM");
            lvGiaoVien.FullRowSelect = true;
            lvGiaoVien.GridLines = true;
            lvGiaoVien.View = View.Details;
            lvGiaoVien.Columns.Add("Mã sinh viên", 150);
            lvGiaoVien.Columns.Add("Họ và tên", 200);
            lvGiaoVien.Columns.Add("Ngày sinh", 150);
            lvGiaoVien.Columns.Add("Lớp", 150);
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(txtMaGiaoVien.Text, txtHoTen.Text, Convert.ToDateTime(dtpNgaySinh.Text), cbbLop.Text);
            GiaoVien frms = new GiaoVien();
            frms.Them(gv);
            frmQLGV_Load(sender, e);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(txtMaGiaoVien.Text, txtHoTen.Text, Convert.ToDateTime(dtpNgaySinh.Text), cbbLop.Text);
            GiaoVien frms = new GiaoVien();
            frms.Sua(gv);
            frmQLGV_Load(sender, e);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien();
            gv.MaGiaoVien = txtMaGiaoVien.Text;
            GiaoVien frms = new GiaoVien();
            frms.Xoa(gv);
            frmQLGV_Load(sender, e);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            GiaoVien frms = new GiaoVien();
            var list = frms.Search(txtSearch.Text);
            lvGiaoVien.Items.Clear();
            foreach (var item in list)
            {
                ListViewItem it = new ListViewItem(item.MaGiaoVien);
                it.SubItems.Add(item.HoTen);
                it.SubItems.Add(item.NgaySinh.ToShortDateString());
                it.SubItems.Add(item.Lop);
                lvGiaoVien.Items.Add(it);
            }
        }

        private void frmQLGV_Load(object sender, EventArgs e)
        {
            lvGiaoVien.Items.Clear();
            GiaoVien frms = new GiaoVien();
            List<GiaoVien> listSV = frms.Load();
            foreach (var item in listSV)
            {
                ListViewItem it = new ListViewItem(item.MaGiaoVien);
                it.SubItems.Add(item.HoTen);
                it.SubItems.Add(item.NgaySinh.ToShortDateString());
                it.SubItems.Add(item.Lop);
                lvGiaoVien.Items.Add(it);
            }
        }
    }
}
