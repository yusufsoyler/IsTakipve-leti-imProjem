using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmDepartmanlar frm = new Formlar.FrmDepartmanlar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnPersonel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmPersoneller frm2 = new Formlar.FrmPersoneller();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void BtnPersonelİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmPersonelİstatistik frm3 = new Formlar.FrmPersonelİstatistik();
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void BtnGorevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGorevListesi frm4 = new Formlar.FrmGorevListesi();
            frm4.MdiParent = this;
            frm4.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGorev fr = new Formlar.FrmGorev();
            fr.Show();
        }

        private void BtnGorevDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGorevDetay fr2 = new Formlar.FrmGorevDetay();
            fr2.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmAnaform frm5= new Formlar.FrmAnaform();
            frm5.MdiParent = this;
            frm5.Show();
        }

        private void BtnAktifCagrılar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmAktifCagrilar frm6 = new Formlar.FrmAktifCagrilar();
            frm6.MdiParent = this;
            frm6.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string hedefLink = "https://www.youtube.com/";

            
            Process.Start(hedefLink);
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Formlar.FrmHesapMakinesi frm6 = new Formlar.FrmHesapMakinesi();
           
            frm6.Show();

        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        
            string hedefLink = "https://news.google.com/home?hl=tr&gl=TR&ceid=TR:tr";


            Process.Start(hedefLink);
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string hedefLink = "https://bigpara.hurriyet.com.tr/doviz/";


            Process.Start(hedefLink);
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string hedefLink = "https://www.google.com.tr/maps/place/%C4%B0skenderun+Teknik+%C3%9Cniversitesi+(%C4%B0STE)/@36.5775291,36.151712,17z/data=!3m1!4b1!4m6!3m5!1s0x152f58e76c45ad8b:0xf98a91f01da61525!8m2!3d36.5775248!4d36.1542869!16s%2Fg%2F11b7_m4m15?hl=tr&entry=ttu";


            Process.Start(hedefLink);
        }

        private void BtnPasifCagrılar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGorevListesi frm6 = new Formlar.FrmGorevListesi();
            frm6.MdiParent = this;
            frm6.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelGorevFormlari.FrmAktifGorevler fraktif = new PersonelGorevFormlari.FrmAktifGorevler();
            fraktif.MdiParent = this;
            fraktif.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmPasifGorevler fraktif = new Formlar.FrmPasifGorevler();
            fraktif.MdiParent = this;
            fraktif.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmDepartmanlar fra = new Formlar.FrmDepartmanlar();
            fra.MdiParent = this;
            fra.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmPersonelİstatistik fra = new Formlar.FrmPersonelİstatistik();
            fra.MdiParent = this;
            fra.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmPersoneller fra2 = new Formlar.FrmPersoneller();
            fra2.MdiParent = this;
            fra2.Show();
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
