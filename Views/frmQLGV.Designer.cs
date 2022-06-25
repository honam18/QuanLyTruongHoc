
namespace TieuLuanXML.Views
{
    partial class frmQLGV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtMaGiaoVien = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.gbQLGV = new System.Windows.Forms.GroupBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.lblMaGiaoVien = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lvGiaoVien = new System.Windows.Forms.ListView();
            this.btSearch = new System.Windows.Forms.Button();
            this.gbQLGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(148, 97);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(427, 27);
            this.dtpNgaySinh.TabIndex = 29;
            // 
            // cbbLop
            // 
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(148, 128);
            this.cbbLop.Margin = new System.Windows.Forms.Padding(2);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(427, 28);
            this.cbbLop.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(200, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 26);
            this.label5.TabIndex = 41;
            this.label5.Text = "QUẢN LÝ GIÁO VIÊN";
            // 
            // txtMaGiaoVien
            // 
            this.txtMaGiaoVien.Location = new System.Drawing.Point(148, 35);
            this.txtMaGiaoVien.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaGiaoVien.Name = "txtMaGiaoVien";
            this.txtMaGiaoVien.Size = new System.Drawing.Size(427, 27);
            this.txtMaGiaoVien.TabIndex = 19;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(148, 66);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(427, 27);
            this.txtHoTen.TabIndex = 21;
            // 
            // gbQLGV
            // 
            this.gbQLGV.Controls.Add(this.txtMaGiaoVien);
            this.gbQLGV.Controls.Add(this.txtHoTen);
            this.gbQLGV.Controls.Add(this.dtpNgaySinh);
            this.gbQLGV.Controls.Add(this.btXoa);
            this.gbQLGV.Controls.Add(this.btThoat);
            this.gbQLGV.Controls.Add(this.cbbLop);
            this.gbQLGV.Controls.Add(this.lblMaGiaoVien);
            this.gbQLGV.Controls.Add(this.btThem);
            this.gbQLGV.Controls.Add(this.btSua);
            this.gbQLGV.Controls.Add(this.lblHoTen);
            this.gbQLGV.Controls.Add(this.lblNgaySinh);
            this.gbQLGV.Controls.Add(this.lblLop);
            this.gbQLGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQLGV.Location = new System.Drawing.Point(12, 40);
            this.gbQLGV.Name = "gbQLGV";
            this.gbQLGV.Size = new System.Drawing.Size(612, 208);
            this.gbQLGV.TabIndex = 40;
            this.gbQLGV.TabStop = false;
            this.gbQLGV.Text = "Quản lý giáo viên";
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btXoa.ForeColor = System.Drawing.Color.White;
            this.btXoa.Image = global::TieuLuanXML.Properties.Resources.delete;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(210, 160);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(86, 41);
            this.btXoa.TabIndex = 27;
            this.btXoa.Text = "Xoá";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btThoat.ForeColor = System.Drawing.Color.White;
            this.btThoat.Image = global::TieuLuanXML.Properties.Resources.turn_off;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(489, 160);
            this.btThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(86, 41);
            this.btThoat.TabIndex = 28;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // lblMaGiaoVien
            // 
            this.lblMaGiaoVien.AutoSize = true;
            this.lblMaGiaoVien.Location = new System.Drawing.Point(28, 38);
            this.lblMaGiaoVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaGiaoVien.Name = "lblMaGiaoVien";
            this.lblMaGiaoVien.Size = new System.Drawing.Size(111, 22);
            this.lblMaGiaoVien.TabIndex = 18;
            this.lblMaGiaoVien.Text = "Mã giáo viên";
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btThem.ForeColor = System.Drawing.Color.White;
            this.btThem.Image = global::TieuLuanXML.Properties.Resources.add;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(30, 160);
            this.btThem.Margin = new System.Windows.Forms.Padding(2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(86, 41);
            this.btThem.TabIndex = 25;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSua.ForeColor = System.Drawing.Color.White;
            this.btSua.Image = global::TieuLuanXML.Properties.Resources.modify;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(120, 160);
            this.btSua.Margin = new System.Windows.Forms.Padding(2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(86, 41);
            this.btSua.TabIndex = 26;
            this.btSua.Text = "Sửa";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(28, 69);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(63, 22);
            this.lblHoTen.TabIndex = 20;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(28, 102);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(90, 22);
            this.lblNgaySinh.TabIndex = 22;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(28, 131);
            this.lblLop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(40, 22);
            this.lblLop.TabIndex = 23;
            this.lblLop.Text = "Lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 22);
            this.label6.TabIndex = 42;
            this.label6.Text = "Nhập mã giáo viên";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(175, 257);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(331, 27);
            this.txtSearch.TabIndex = 38;
            // 
            // lvGiaoVien
            // 
            this.lvGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvGiaoVien.HideSelection = false;
            this.lvGiaoVien.Location = new System.Drawing.Point(12, 291);
            this.lvGiaoVien.Margin = new System.Windows.Forms.Padding(2);
            this.lvGiaoVien.Name = "lvGiaoVien";
            this.lvGiaoVien.Size = new System.Drawing.Size(612, 318);
            this.lvGiaoVien.TabIndex = 37;
            this.lvGiaoVien.UseCompatibleStateImageBehavior = false;
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.ForeColor = System.Drawing.Color.White;
            this.btSearch.Image = global::TieuLuanXML.Properties.Resources.view;
            this.btSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSearch.Location = new System.Drawing.Point(510, 253);
            this.btSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(114, 34);
            this.btSearch.TabIndex = 39;
            this.btSearch.Text = "Tìm kiếm";
            this.btSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // frmQLGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 621);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbQLGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lvGiaoVien);
            this.Name = "frmQLGV";
            this.Text = "Quản lý giáo viên";
            this.Load += new System.EventHandler(this.frmQLGV_Load);
            this.gbQLGV.ResumeLayout(false);
            this.gbQLGV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.GroupBox gbQLGV;
        private System.Windows.Forms.Label lblMaGiaoVien;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListView lvGiaoVien;
        private System.Windows.Forms.TextBox txtMaGiaoVien;
    }
}