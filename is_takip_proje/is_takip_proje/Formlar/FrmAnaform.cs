﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using is_takip_proje.Entity;

namespace is_takip_proje.Formlar
{
    public partial class FrmAnaform : Form
    {
        public FrmAnaform()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();
        private void FrmAnaform_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblGorevler select new

            {
                x.Aciklama,
         personel= x.TblPersonel.Ad+" "+x.TblPersonel.Soyad,
         x.Durum
                
            }
                                       
                                       
                                       
                                       ).Where(y =>y.Durum==true).ToList();
            gridView1.Columns["Durum"].Visible = false;
            //bugün yapılan görevler
            DateTime bugun =DateTime.Parse( DateTime.Now.ToShortDateString());



            gridControl2.DataSource = (from x in db.TblGorevDetaylar
                                       select new
                                       {
                                           Gorev = x.TblGorevler.Aciklama,
                                           x.Aciklama,
                                           x.Tarih

                                       }


                                     ).Where(x => x.Tarih == bugun).ToList();


            gridControl3.DataSource = (from x in db.TblCagrilar
                                       select new
                                       {
                                           x.TblFirmalar.Ad,
                                           x.Konu,
                                           x.Tarih,
                                           x.Durum
                                       }



                                     ).Where(x => x.Durum == true).ToList();




            gridView3.Columns["Durum"].Visible = false;
            //chart kısmı
            gridControl4.DataSource = (from x in db.TblFirmalar
                                       select new
                                       {
                                           x.Ad,
                                           x.Telefon,
                                           x.Mail
                                       }



                                     ).ToList();
            //
            int aktif_cagrilar = db.TblCagrilar.Where(x => x.Durum == true).Count();
            int pasif_cagrilar = db.TblCagrilar.Where(x => x.Durum == false).Count();




            chartControl1.Series["Series 1"].Points.AddPoint("Aktif Çağrılar",aktif_cagrilar);
            chartControl1.Series["Series 1"].Points.AddPoint("Pasif Çağrılar", pasif_cagrilar);



        }

        private void groupControl5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
