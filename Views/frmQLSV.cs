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
    public partial class frmQLSV : Form
    {
        public frmQLSV()
        {
            InitializeComponent();
            LoadSinhVien();
        }
        private void LoadSinhVien()
        {
            cbbLop.Items.Add("LTM1");
            cbbLop.Items.Add("LTM2");
            cbbLop.Items.Add("QTM");
            cbbLop.Items.Add("TKW");
            cbbLop.Items.Add("ANM");
            lvSinhVien.FullRowSelect = true;
            lvSinhVien.GridLines = true;
            lvSinhVien.View = View.Details;
            lvSinhVien.Columns.Add("Mã sinh viên", 150);
            lvSinhVien.Columns.Add("Họ và tên", 200);
            lvSinhVien.Columns.Add("Ngày sinh", 150);
            lvSinhVien.Columns.Add("Lớp", 150);
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien(txtMaSinhVien.Text, txtHoTen.Text, Convert.ToDateTime(dtpNgaySinh.Text), cbbLop.Text);
            SinhVien frms = new SinhVien();
            frms.Them(sv);
            frmQLSV_Load(sender, e);
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien(txtMaSinhVien.Text, txtHoTen.Text, Convert.ToDateTime(dtpNgaySinh.Text), cbbLop.Text);
            SinhVien frms = new SinhVien();
            frms.Sua(sv);
            frmQLSV_Load(sender, e);
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.MaSinhVien = txtMaSinhVien.Text;
            SinhVien frms = new SinhVien();
            frms.Xoa(sv);
            frmQLSV_Load(sender, e);
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void btSearch_Click(object sender, EventArgs e)
        {
            SinhVien frms = new SinhVien();
            var list = frms.Search(txtSearch.Text);
            lvSinhVien.Items.Clear();
            foreach (var item in list)
            {
                ListViewItem it = new ListViewItem(item.MaSinhVien);
                it.SubItems.Add(item.HoTen);
                it.SubItems.Add(item.NgaySinh.ToShortDateString());
                it.SubItems.Add(item.Lop);
                lvSinhVien.Items.Add(it);
            }
        }
        private void frmQLSV_Load(object sender, EventArgs e)
        {
            lvSinhVien.Items.Clear();
            SinhVien frms = new SinhVien();
            List<SinhVien> listSV = frms.Load();
            foreach (var item in listSV)
            {
                ListViewItem it = new ListViewItem(item.MaSinhVien);
                it.SubItems.Add(item.HoTen);
                it.SubItems.Add(item.NgaySinh.ToShortDateString());
                it.SubItems.Add(item.Lop);
                lvSinhVien.Items.Add(it);
            }
        }
    }
}
