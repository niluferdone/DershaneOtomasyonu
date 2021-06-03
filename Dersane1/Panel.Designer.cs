namespace Dersane1
{
    partial class Panel
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
            this.öğrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğretmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKayıtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtGüncelleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtSilToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersKaldırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümKaldırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciToolStripMenuItem,
            this.öğretmenToolStripMenuItem,
            this.dersToolStripMenuItem,
            this.bölümToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(497, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // öğrenciToolStripMenuItem
            // 
            this.öğrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKayıtToolStripMenuItem,
            this.kayıtSilToolStripMenuItem,
            this.kayıtGüncelleToolStripMenuItem});
            this.öğrenciToolStripMenuItem.Name = "öğrenciToolStripMenuItem";
            this.öğrenciToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.öğrenciToolStripMenuItem.Text = "Öğrenci";
            // 
            // yeniKayıtToolStripMenuItem
            // 
            this.yeniKayıtToolStripMenuItem.Name = "yeniKayıtToolStripMenuItem";
            this.yeniKayıtToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.yeniKayıtToolStripMenuItem.Text = "Yeni Kayıt";
            this.yeniKayıtToolStripMenuItem.Click += new System.EventHandler(this.yeniKayıtToolStripMenuItem_Click);
            // 
            // kayıtSilToolStripMenuItem
            // 
            this.kayıtSilToolStripMenuItem.Name = "kayıtSilToolStripMenuItem";
            this.kayıtSilToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.kayıtSilToolStripMenuItem.Text = "Kayıt Sil";
            this.kayıtSilToolStripMenuItem.Click += new System.EventHandler(this.kayıtSilToolStripMenuItem_Click);
            // 
            // kayıtGüncelleToolStripMenuItem
            // 
            this.kayıtGüncelleToolStripMenuItem.Name = "kayıtGüncelleToolStripMenuItem";
            this.kayıtGüncelleToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.kayıtGüncelleToolStripMenuItem.Text = "Kayıt Güncelle";
            // 
            // öğretmenToolStripMenuItem
            // 
            this.öğretmenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKayıtToolStripMenuItem1,
            this.kayıtGüncelleToolStripMenuItem1,
            this.kayıtSilToolStripMenuItem1});
            this.öğretmenToolStripMenuItem.Name = "öğretmenToolStripMenuItem";
            this.öğretmenToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.öğretmenToolStripMenuItem.Text = "Öğretmen";
            // 
            // yeniKayıtToolStripMenuItem1
            // 
            this.yeniKayıtToolStripMenuItem1.Name = "yeniKayıtToolStripMenuItem1";
            this.yeniKayıtToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.yeniKayıtToolStripMenuItem1.Text = "Yeni kayıt";
            // 
            // kayıtGüncelleToolStripMenuItem1
            // 
            this.kayıtGüncelleToolStripMenuItem1.Name = "kayıtGüncelleToolStripMenuItem1";
            this.kayıtGüncelleToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.kayıtGüncelleToolStripMenuItem1.Text = "Kayıt Güncelle";
            // 
            // kayıtSilToolStripMenuItem1
            // 
            this.kayıtSilToolStripMenuItem1.Name = "kayıtSilToolStripMenuItem1";
            this.kayıtSilToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.kayıtSilToolStripMenuItem1.Text = "Kayıt sil";
            // 
            // dersToolStripMenuItem
            // 
            this.dersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dersEkleToolStripMenuItem,
            this.dersKaldırToolStripMenuItem});
            this.dersToolStripMenuItem.Name = "dersToolStripMenuItem";
            this.dersToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.dersToolStripMenuItem.Text = "Ders";
            // 
            // dersEkleToolStripMenuItem
            // 
            this.dersEkleToolStripMenuItem.Name = "dersEkleToolStripMenuItem";
            this.dersEkleToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.dersEkleToolStripMenuItem.Text = "Ders ekle";
            // 
            // dersKaldırToolStripMenuItem
            // 
            this.dersKaldırToolStripMenuItem.Name = "dersKaldırToolStripMenuItem";
            this.dersKaldırToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.dersKaldırToolStripMenuItem.Text = "Ders Kaldır";
            // 
            // bölümToolStripMenuItem
            // 
            this.bölümToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bölümEkleToolStripMenuItem,
            this.bölümKaldırToolStripMenuItem});
            this.bölümToolStripMenuItem.Name = "bölümToolStripMenuItem";
            this.bölümToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.bölümToolStripMenuItem.Text = "Bölüm";
            // 
            // bölümEkleToolStripMenuItem
            // 
            this.bölümEkleToolStripMenuItem.Name = "bölümEkleToolStripMenuItem";
            this.bölümEkleToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.bölümEkleToolStripMenuItem.Text = "Bölüm Ekle";
            // 
            // bölümKaldırToolStripMenuItem
            // 
            this.bölümKaldırToolStripMenuItem.Name = "bölümKaldırToolStripMenuItem";
            this.bölümKaldırToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.bölümKaldırToolStripMenuItem.Text = "Bölüm Kaldır";
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Panel";
            this.Text = "Panel";
            this.Load += new System.EventHandler(this.Panel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğretmenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniKayıtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kayıtGüncelleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kayıtSilToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersKaldırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümKaldırToolStripMenuItem;

    }
}