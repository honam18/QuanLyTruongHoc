
namespace TieuLuanXML.Views
{
    partial class frmLop
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lvLop = new System.Windows.Forms.ListView();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtSiSo = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblSiSo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbQLLOP = new System.Windows.Forms.GroupBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbQLLOP.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 22);
            this.label6.TabIndex = 48;
            this.label6.Text = "Nhập lớp";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(97, 235);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(409, 27);
            this.txtSearch.TabIndex = 44;
            // 
            // lvLop
            // 
            this.lvLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLop.HideSelection = false;
            this.lvLop.Location = new System.Drawing.Point(12, 269);
            this.lvLop.Margin = new System.Windows.Forms.Padding(2);
            this.lvLop.Name = "lvLop";
            this.lvLop.Size = new System.Drawing.Size(612, 340);
            this.lvLop.TabIndex = 43;
            this.lvLop.UseCompatibleStateImageBehavior = false;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(85, 66);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(490, 27);
            this.txtMaLop.TabIndex = 19;
            // 
            // txtSiSo
            // 
            this.txtSiSo.Location = new System.Drawing.Point(85, 97);
            this.txtSiSo.Margin = new System.Windows.Forms.Padding(2);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.Size = new System.Drawing.Size(490, 27);
            this.txtSiSo.TabIndex = 21;
            // 
            // lblSiSo
            // 
            this.lblSiSo.AutoSize = true;
            this.lblSiSo.Location = new System.Drawing.Point(28, 100);
            this.lblSiSo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSiSo.Name = "lblSiSo";
            this.lblSiSo.Size = new System.Drawing.Size(53, 22);
            this.lblSiSo.TabIndex = 20;
            this.lblSiSo.Text = "Sỉ Số";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(200, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 26);
            this.label5.TabIndex = 47;
            this.label5.Text = "QUẢN LÝ LỚP HỌC";
            // 
            // gbQLLOP
            // 
            this.gbQLLOP.Controls.Add(this.txtKhoa);
            this.gbQLLOP.Controls.Add(this.label1);
            this.gbQLLOP.Controls.Add(this.txtMaLop);
            this.gbQLLOP.Controls.Add(this.txtSiSo);
            this.gbQLLOP.Controls.Add(this.btXoa);
            this.gbQLLOP.Controls.Add(this.btThoat);
            this.gbQLLOP.Controls.Add(this.lblMaLop);
            this.gbQLLOP.Controls.Add(this.btThem);
            this.gbQLLOP.Controls.Add(this.btSua);
            this.gbQLLOP.Controls.Add(this.lblSiSo);
            this.gbQLLOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQLLOP.Location = new System.Drawing.Point(12, 40);
            this.gbQLLOP.Name = "gbQLLOP";
            this.gbQLLOP.Size = new System.Drawing.Size(612, 186);
            this.gbQLLOP.TabIndex = 46;
            this.gbQLLOP.TabStop = false;
            this.gbQLLOP.Text = "Quản lý lớp học";
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btXoa.ForeColor = System.Drawing.Color.White;
            this.btXoa.Image = global::TieuLuanXML.Properties.Resources.delete;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(210, 128);
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
            this.btThoat.Location = new System.Drawing.Point(489, 128);
            this.btThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(86, 41);
            this.btThoat.TabIndex = 28;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(28, 69);
            this.lblMaLop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(40, 22);
            this.lblMaLop.TabIndex = 18;
            this.lblMaLop.Text = "Lớp";
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btThem.ForeColor = System.Drawing.Color.White;
            this.btThem.Image = global::TieuLuanXML.Properties.Resources.add;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(30, 128);
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
            this.btSua.Location = new System.Drawing.Point(120, 128);
            this.btSua.Margin = new System.Windows.Forms.Padding(2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(86, 41);
            this.btSua.TabIndex = 26;
            this.btSua.Text = "Sửa";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.ForeColor = System.Drawing.Color.White;
            this.btSearch.Image = global::TieuLuanXML.Properties.Resources.view;
            this.btSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSearch.Location = new System.Drawing.Point(510, 231);
            this.btSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(114, 34);
            this.btSearch.TabIndex = 45;
            this.btSearch.Text = "Tìm kiếm";
            this.btSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(85, 35);
            this.txtKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(490, 27);
            this.txtKhoa.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Khoa";
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 619);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lvLop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbQLLOP);
            this.Name = "frmLop";
            this.Text = "Quản lý lớp học";
            this.Load += new System.EventHandler(this.frmLop_Load);
            this.gbQLLOP.ResumeLayout(false);
            this.gbQLLOP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListView lvLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtSiSo;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Label lblSiSo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbQLLOP;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.Label label1;
    }
}