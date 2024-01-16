using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje.Formlar
{
    public partial class FrmHesapMakinesi : Form
    {
        public FrmHesapMakinesi()
        {
            InitializeComponent();
        }
        private void HesapVeGoster(string operatorSecim)
        {
            double sayi1, sayi2, sonuc;

            if (double.TryParse(textBox1.Text, out sayi1) && double.TryParse(textBox2.Text, out sayi2))
            {
                switch (operatorSecim)
                {
                    case "+":
                        sonuc = sayi1 + sayi2;
                        break;
                    case "-":
                        sonuc = sayi1 - sayi2;
                        break;
                    case "*":
                        sonuc = sayi1 * sayi2;
                        break;
                    case "/":
                        if (sayi2 != 0)
                            sonuc = sayi1 / sayi2;
                        else
                        {
                            MessageBox.Show("Hata: Bölen sıfır olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    default:
                        MessageBox.Show("Geçersiz operatör seçimi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                labelSonuc.Text = $"Sonuç: {sonuc}";
            }
            else
            {
                MessageBox.Show("Geçersiz sayı girişi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmHesapMakinesi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HesapVeGoster("+");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HesapVeGoster("-");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HesapVeGoster("*");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HesapVeGoster("/");
        }
    }
}
