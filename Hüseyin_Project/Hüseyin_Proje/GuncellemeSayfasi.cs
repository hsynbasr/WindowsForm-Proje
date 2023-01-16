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
    public partial class GuncellemeSayfasi : Form
    {
       
        ProjectContext db;
        public GuncellemeSayfasi()
        {
            InitializeComponent();
            db = new ProjectContext();

        }

        private void GuncellemeSayfasi_Load(object sender, EventArgs e)
        {
            List<Uyegirisi> a = db.uyegirisi.ToList();
            foreach (var item in a)
            {
                lbl_SaticiAdi.Text = item.uyeadi;

            }
            List<ilanId> s = db.ilanId.ToList();
            foreach (var item in s)
            {
                lbl_uruniD.Text = item.ilanNo.ToString();
            }


            List<ilan> o = db.ilan.ToList();
            foreach (var item in o)
            {
                if (item.ilanId==Convert.ToInt32(lbl_uruniD.Text) )
                {
                    txt_ilanAdi.Text = item.ilanAdi;
                    comb_ilanTipi.Text = item.ilanTipi;
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
                    cmb_il.Text = item.il;
                    txt_aciklama.Text = item.Acıklama;
                    picb_resimekle.ImageLocation = item.Foto;
                    
                }
            }

        }

        private void btn_resimDegis_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();
            picb_resimekle.ImageLocation = openFileDialog1.FileName;
            txt_resim.Text = openFileDialog1.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ilannn = Convert.ToInt32(lbl_uruniD.Text);
            ilanId deletee = db.ilanId.FirstOrDefault(i => i.ilanNo == ilannn);
            db.ilanId.Remove(deletee);
            db.SaveChanges();
            this.Hide();
         
        }
        ilan update;
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lbl_uruniD.Text);
            update = db.ilan.Find(id);
            update.ilanAdi= txt_ilanAdi.Text;        
            update.ilanTipi= comb_ilanTipi.Text;      
            update.Marka= txt_Marka.Text;          
            update.Model= txt_model.Text;          
            update.Seri= txt_seri.Text;           
            update.fiyat= txt_fiyat.Text;          
            update.Yakit= txt_yakit.Text;          
            update.Vites= txt_vites.Text;          
            update.KM= txt_km.Text;             
            update.MotorHacmi= txt_motorhacmi.Text;     
            update.MotorGucu= txt_motorgucu.Text;      
            update.Yıl= txt_yil.Text;            
            update.il= cmb_il.Text;             
            update.Acıklama= txt_aciklama.Text;       
            update.Foto= txt_resim.Text;          
            var kisi = db.ilan.ToList();
            foreach (var item in kisi)
            {
                if (item.ilanId== Convert.ToInt32(lbl_uruniD.Text))
                {
                   update.saticiId = item.saticiId;  
                }
            }
            db.Entry(db.ilan.Find(update.ilanId)).CurrentValues.SetValues(update);
            db.SaveChanges();
            int ilannn = Convert.ToInt32(lbl_uruniD.Text);
            ilanId delete = db.ilanId.FirstOrDefault(i => i.ilanNo == ilannn);
            db.ilanId.Remove(delete);
            db.SaveChanges();


            this.Hide();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lbl_uruniD.Text);
            ilan delete = db.ilan.Find(id);
            db.ilan.Remove(delete);
            db.SaveChanges();

            int ilannn = Convert.ToInt32(lbl_uruniD.Text);
            ilanId deletee = db.ilanId.FirstOrDefault(i => i.ilanNo == ilannn);
            db.ilanId.Remove(deletee);
            db.SaveChanges();
            this.Hide();
        }
    }
}
