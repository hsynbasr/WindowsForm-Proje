using Hüseyin_Proje.ORM.Context;
using Hüseyin_Proje.ORM.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hüseyin_Proje
{
    public partial class uyeKaydi : Form
    {
        ProjectContext db;
       
        public uyeKaydi()
        {
            InitializeComponent();
            db = new ProjectContext();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_kayitSifre.Text==txt_TekrarSifre.Text)
            {
                Satici s = new Satici();
                s.SaticiAdi = txt_kayitAdSoyad.Text;
                s.SaticiTelno = txt_kayittel.Text;
                s.KullaniciAdi = txt_kayıtKulAdi.Text;
                s.sifre = txt_kayitSifre.Text;

                db.Satici.Add(s);
                db.SaveChanges();

                MessageBox.Show("Kayıt Başarılı");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor!!!!");
            }
            
        }
    }
}
