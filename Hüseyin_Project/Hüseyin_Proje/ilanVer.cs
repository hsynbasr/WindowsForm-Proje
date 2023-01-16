using Hüseyin_Proje.ORM.Context;
using Hüseyin_Proje.ORM.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hüseyin_Proje
{
    public partial class ilanVer : Form
    {

        ProjectContext db;
        public ilanVer()
        {
            InitializeComponent();
            db = new ProjectContext();

        }

        private void ilanVer_Load(object sender, EventArgs e)
        {
            List<Uyegirisi> k = db.uyegirisi.ToList();

            foreach (var item in k)
            {
                lbl_SaticiAdi.Text = item.uyeadi;
            }

            List<Satici> s = db.Satici.ToList();
            foreach (var item in s)
            {
                if (lbl_SaticiAdi.Text == item.SaticiAdi)
                {
                    lbl_saticiID.Text = item.Id.ToString();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ilan o = new ilan();
            o.ilanAdi = txt_ilanAdi.Text;
            o.ilanTipi = comb_ilanTipi.Text;
            o.Marka = txt_Marka.Text;
            o.Model = txt_model.Text;
            o.Seri = txt_seri.Text;
            o.fiyat = txt_fiyat.Text;
            o.Yakit = txt_yakit.Text;
            o.Vites = txt_vites.Text;
            o.KM = txt_km.Text;
            o.MotorHacmi = txt_motorhacmi.Text;
            o.MotorGucu = txt_motorgucu.Text;
            o.Yıl = txt_yil.Text;
            o.il = cmb_il.Text;
            o.Acıklama = txt_aciklama.Text;
            o.Foto = txt_resim.Text;
            o.saticiId = Convert.ToInt32(lbl_saticiID.Text);
            
            //var context = new ProjectContext();
            //var satici = context.Satici.Where(i => i.Id == Convert.ToInt32(lbl_saticiID.Text)).FirstOrDefault();

            //o.satici = satici;

            db.ilan.Add(o);
            db.SaveChanges();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            picb_resimekle.ImageLocation = openFileDialog1.FileName;
            
            txt_resim.Text = openFileDialog1.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
    
}
