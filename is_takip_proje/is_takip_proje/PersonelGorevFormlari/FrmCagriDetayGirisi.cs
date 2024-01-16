using DevExpress.XtraEditors;
using is_takip_proje.Entity;
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
    public partial class FrmCagriDetayGirisi : Form
    {
        public FrmCagriDetayGirisi()
        {
            InitializeComponent();
        }
        public int id;
        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCagriDetayGirisi_Load(object sender, EventArgs e)
        {
            TxtCagrıId1.Enabled = false;
            TxtCagrıId1.Text = id.ToString();
            string saat , tarih;
            tarih = DateTime.Now.ToShortDateString();
            saat = DateTime.Now.ToShortTimeString();
            TxtTarih.Text = tarih;
            TxtSaat.Text = saat;
               
        }
        DbisTakipEntities db = new DbisTakipEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TblCagriDetay t = new TblCagriDetay();
            t.Cagri =int.Parse( TxtCagrıId1.Text);
            t.Saat = TxtSaat.Text;
            t.Tarih =DateTime.Parse(TxtTarih.Text);
            t.Aciklama = TxtAciklama.Text;
            db.TblCagriDetay.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Çağrı Detayı Sisteme Başarılı Bir Şekilde İletildi");

        }
    }
}
