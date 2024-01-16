using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje.PersonelGorevFormlari
{
    public partial class FrmPersonelFormu : Form
    {
        public FrmPersonelFormu()
        {
            InitializeComponent();
        }

        private void BtnAktifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           PersonelGorevFormlari.FrmAktifGorevler frm = new PersonelGorevFormlari.FrmAktifGorevler();
            frm.MdiParent = this;
            frm.mail2 = mail;
            frm.Show();
        }

        private void BtnPasifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmPasifGorevler frmv2 = new Formlar.FrmPasifGorevler();
            frmv2.MdiParent = this;
            frmv2.mail2 = mail;
            frmv2.Show();
        }
        public string mail;
        private void FrmPersonelFormu_Load(object sender, EventArgs e)
        {
            // this.Text = mail.ToString();
            this.Text = "Personel Sayfası";
           
        }
       
        private void BtnCagriListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          PersonelGorevFormlari.FrmCagriListesi frmv3 = new PersonelGorevFormlari.FrmCagriListesi();
            frmv3.MdiParent = this;
            frmv3.mail2 = mail;
            frmv3.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
