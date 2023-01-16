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
    public partial class ilanOzellikleri : Form
    {
        ProjectContext db;
        public ilanOzellikleri()
        {
            InitializeComponent();
            db = new ProjectContext();

        }
      
        private void ilanOzellikleri_Load(object sender, EventArgs e)
        {
            List<ilanId> o = db.ilanId.ToList();
            foreach (var item in o)
            {
                lbl_UruniD.Text=item.ilanNo.ToString();

            }
            int a = Convert.ToInt32(lbl_UruniD.Text);
            foreach (var item in db.ilan.ToList())
            {
                if (item.ilanId==a)
                {
                    lbl_İlanAdi.Text = item.ilanAdi;
                    txt_Marka.Text = item.Marka;
                    txt_model.Text = item.Model;
                    txt_seri.Text = item.Seri;
                    txt_fiyat.Text = item.fiyat;
                    txt_yakit.Text = item.Yakit;
                    txt_vites.Text = item.Vites;
                    txt_km.Text = item.KM;
                    txt_motorhacmi.Text = item.MotorHacmi;
                    txt_motorgucu.Text = item.MotorGucu;
                    txt_yil.Text = item.Yıl;
                    txt_il.Text = item.il;
                    txt_aciklama.Text = item.Acıklama;
                    picb_resimekle.ImageLocation = item.Foto;

                    foreach (var kisi in db.Satici.ToList())
                    {
                        if (kisi.Id==item.saticiId)
                        {
                            lbl_saticiAd.Text = kisi.SaticiAdi;
                            lbl_saticiTel.Text = kisi.SaticiTelno;
                        }
                    }
                
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ilannn = Convert.ToInt32(lbl_UruniD.Text);
            ilanId deletee = db.ilanId.FirstOrDefault(i => i.ilanNo == ilannn);
            db.ilanId.Remove(deletee);
            db.SaveChanges();
            this.Hide();
            
        }
    }
}
