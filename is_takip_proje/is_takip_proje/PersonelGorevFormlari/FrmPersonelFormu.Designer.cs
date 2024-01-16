namespace is_takip_proje.PersonelGorevFormlari
{
    partial class FrmPersonelFormu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelFormu));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnAktifGorevler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPasifGorevler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnCagriListe = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.BtnAktifGorevler,
            this.BtnPasifGorevler,
            this.BtnCagriListe,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(984, 150);
            // 
            // BtnAktifGorevler
            // 
            this.BtnAktifGorevler.Caption = "Aktif Görevler";
            this.BtnAktifGorevler.Id = 1;
            this.BtnAktifGorevler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAktifGorevler.ImageOptions.Image")));
            this.BtnAktifGorevler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAktifGorevler.ImageOptions.LargeImage")));
            this.BtnAktifGorevler.Name = "BtnAktifGorevler";
            this.BtnAktifGorevler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAktifGorevler_ItemClick);
            // 
            // BtnPasifGorevler
            // 
            this.BtnPasifGorevler.Caption = "Pasif Görevler";
            this.BtnPasifGorevler.Id = 2;
            this.BtnPasifGorevler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPasifGorevler.ImageOptions.Image")));
            this.BtnPasifGorevler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnPasifGorevler.ImageOptions.LargeImage")));
            this.BtnPasifGorevler.Name = "BtnPasifGorevler";
            this.BtnPasifGorevler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPasifGorevler_ItemClick);
            // 
            // BtnCagriListe
            // 
            this.BtnCagriListe.Caption = "Çağrı Listesi";
            this.BtnCagriListe.Id = 4;
            this.BtnCagriListe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCagriListe.ImageOptions.Image")));
            this.BtnCagriListe.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnCagriListe.ImageOptions.LargeImage")));
            this.BtnCagriListe.Name = "BtnCagriListe";
            this.BtnCagriListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCagriListe_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Görevler";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnAktifGorevler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnPasifGorevler);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnCagriListe);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "ÇIKIŞ";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // FrmPersonelFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FrmPersonelFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Formu";
            this.Load += new System.EventHandler(this.FrmPersonelFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BtnAktifGorevler;
        private DevExpress.XtraBars.BarButtonItem BtnPasifGorevler;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem BtnCagriListe;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}