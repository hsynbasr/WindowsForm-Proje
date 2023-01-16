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
    
    public partial class Form1 : Form
    {
        ProjectContext db;
        public Form1()
        {
            InitializeComponent();
           db = new ProjectContext();
          
        }

        private void btn_UyeGirisi_Click(object sender, EventArgs e)
        {
            grp_uyeGiris.Visible = true;
        }

        private void btn_UyeOl_Click(object sender, EventArgs e)
        {
            uyeKaydi kayit = new uyeKaydi();
            kayit.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Uyegirisi> a = db.uyegirisi.ToList();
            foreach (var item in a)
            {
                var context = new ProjectContext();
                var kisi = context.uyegirisi.FirstOrDefault(i => i.uyeadi == item.uyeadi);
                context.uyegirisi.Remove(kisi);
                context.SaveChanges();
            }
            
            List<Uyegirisi> k = db.uyegirisi.ToList();
            grp_uyeGiris.Visible = false;
            grp_uyelikSecim.Visible = false;
           
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            var context = new ProjectContext();
            var satici = context.Satici.Where(i => i.KullaniciAdi == txt_girisAdi.Text &&
             i.sifre == txt_girisSifre.Text).FirstOrDefault();

            if (satici == null)
            {
                MessageBox.Show("Kullanıcı adi veya şifre hatalı");
            }
            else
            {
                MessageBox.Show("Giriş başarılı");
                grp_uyeGiris.Visible = false;

                List<Satici> sat = db.Satici.ToList();
                foreach (Satici item in sat)
                {
                    if (item.KullaniciAdi== txt_girisAdi.Text)
                    {
                        lbl_hesapAdi.Text = item.SaticiAdi;
                        lbl_hesapAdi.Visible = true;
                        btn_UyeGirisi.Visible = false;
                        btn_UyeOl.Visible = false;
                        grp_uyelikSecim.Visible = true;

                        List<Uyegirisi> a = db.uyegirisi.ToList();
                       
                            if (a.Count==0)
                            {
                                Uyegirisi girisad = new Uyegirisi();
                                girisad.uyeadi = item.SaticiAdi;
                                db.uyegirisi.Add(girisad);
                                db.SaveChanges();
                            }
                        
                       

                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grp_uyeGiris.Visible = false;
        }

        private void btn_uyeCikis_Click(object sender, EventArgs e)
        {
            
            btn_UyeOl.Visible = true;
            btn_UyeGirisi.Visible = true;
            grp_uyelikSecim.Visible = false;
            var context = new ProjectContext();
            var kisi = context.uyegirisi.FirstOrDefault(i => i.uyeadi == lbl_hesapAdi.Text);
            context.uyegirisi.Remove(kisi);
            context.SaveChanges();


        }

        private void btn_ilanVer_Click(object sender, EventArgs e)
        {
            ilanVer m = new ilanVer();
            m.Show();
           
        }

       

        private void btn_uyeIlanListeleme_Click(object sender, EventArgs e)
        {
            İlanlarım i = new İlanlarım();
            i.Show();
        }

        private void Btn_iLanlar_Click(object sender, EventArgs e)
        {
            KullaniciiLanListeleme m = new KullaniciiLanListeleme();
            m.Show();
        }
    }
}
