using DevExpress.XtraEditors;
using is_takip_proje.Entity;
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

namespace is_takip_proje.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelGorevFormlari.FrmPersonelFormu fr = new PersonelGorevFormlari.FrmPersonelFormu();
            fr.Show();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textEdit1_Click(object sender, EventArgs e)
        {
           
        }
        DbisTakipEntities db = new DbisTakipEntities();
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            var adminvalue = db.TblAdmin.Where(x => x.Kullanici == TxtKullanici.Text && x.Sifre == TxtSifre.Text).FirstOrDefault();
            if(adminvalue!=null)
            {
                XtraMessageBox.Show("Hoşgeldiniz");
               Form1 frAna = new Form1();
                frAna.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı veya Yanlış Giriş Yaptınız");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var personel = db.TblPersonel.Where(x => x.Mail == TxtKullanici.Text && x.Sifre == TxtSifre.Text).FirstOrDefault();
            if (personel != null)
            {
                PersonelGorevFormlari.FrmPersonelFormu fr = new PersonelGorevFormlari.FrmPersonelFormu();
                fr.mail = TxtKullanici.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı veya Yanlış Giriş Yaptınız");
            }
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            string hedefLink = "https://mail.google.com/mail/u/0/#inbox?compose=new";

            // Tarayıcıyı başlatma
            Process.Start(hedefLink);
        }

        private void hyperlinkLabelControl2_Click(object sender, EventArgs e)
        {
            string hedefLink = "https://www.example.com";

            
            Process.Start(hedefLink);
        }

        private void hyperlinkLabelControl4_Click(object sender, EventArgs e)
        {
           // string hedefLink = @"C:\Users\yusuf\source\repos\MvcFirmaCagri\MvcFirmaCagri.sln";
          string hedefLink2 = @"http://localhost:49917/Login/Index";


          
          //  Process.Start(hedefLink);
         Process.Start(hedefLink2);
        }
    }
}
