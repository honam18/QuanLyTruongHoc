
namespace TieuLuanXML.Views
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLSV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLGV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(392, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThoat});
            this.hệThốngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.hệThốngToolStripMenuItem.Image = global::TieuLuanXML.Properties.Resources.System;
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(115, 29);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::TieuLuanXML.Properties.Resources.turn_off1;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 22);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQLSV,
            this.btnQLGV,
            this.btnLop});
            this.quảnLýToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.quảnLýToolStripMenuItem.Image = global::TieuLuanXML.Properties.Resources.notes;
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(101, 29);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // btnQLSV
            // 
            this.btnQLSV.Image = global::TieuLuanXML.Properties.Resources.user_group;
            this.btnQLSV.Name = "btnQLSV";
            this.btnQLSV.Size = new System.Drawing.Size(123, 22);
            this.btnQLSV.Text = "Sinh Viên";
            this.btnQLSV.Click += new System.EventHandler(this.btnQLSV_Click);
            // 
            // btnQLGV
            // 
            this.btnQLGV.Image = global::TieuLuanXML.Properties.Resources.user_group1;
            this.btnQLGV.Name = "btnQLGV";
            this.btnQLGV.Size = new System.Drawing.Size(123, 22);
            this.btnQLGV.Text = "Giáo viên";
            this.btnQLGV.Click += new System.EventHandler(this.btnQLGV_Click);
            // 
            // btnLop
            // 
            this.btnLop.Image = global::TieuLuanXML.Properties.Resources.user_group2;
            this.btnLop.Name = "btnLop";
            this.btnLop.Size = new System.Drawing.Size(123, 22);
            this.btnLop.Text = "Lớp học";
            this.btnLop.Click += new System.EventHandler(this.btnLop_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 210);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Trang chủ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnThoat;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnQLSV;
        private System.Windows.Forms.ToolStripMenuItem btnQLGV;
        private System.Windows.Forms.ToolStripMenuItem btnLop;
    }
}