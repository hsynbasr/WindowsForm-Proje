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
    public partial class İlanlarım : Form
    {
        ProjectContext db;
        public İlanlarım()
        {
            InitializeComponent();
            db = new ProjectContext();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void İlanlarım_Load(object sender, EventArgs e)
        {
            
            List<Uyegirisi> a = db.uyegirisi.ToList();
            foreach (var item in a)
            {
                label_saticiAdi.Text = item.uyeadi;
                
            }
            List<Satici> s = db.Satici.ToList();
            foreach (var item in s)
            {
                if (label_saticiAdi.Text== item.SaticiAdi)
                {
                    lbl_saticiId.Text = item.Id.ToString();
                }
            }

            //comboBox_ilanTipi.DataSource = db.ilan.ToList();
           
            //comboBox_ilanTipi.DisplayMember = "ilanTipi";
            
            //var listeoto = from item in db.Otomobil select new {item.ilanId,item.Marka,item.Model,item.fiyat,
            //  item.il,item.Yıl    };
            //dataGridView_oto.DataSource = listeoto.ToList();
            //var listemotor = from item in db.Motosiklet
            //            select new
            //            {
            //                item.ilanId,
            //                item.Marka,
            //                item.Model,
            //                item.fiyat,
            //                item.il,
            //                item.Yıl
            //            };
            //dataGridView_motor.DataSource = listemotor.ToList();

        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            listilanlar.Items.Clear();
            foreach (ilan item in db.ilan.ToList())
            {
                if (item.saticiId==Convert.ToInt32(lbl_saticiId.Text)&& item.ilanTipi==comboBox_ilanTipi.Text)
                {
                    ListViewItem satir = new ListViewItem();
                    satir.Text =  item.ilanId.ToString();
                    satir.SubItems.Add(item.Marka);
                    satir.SubItems.Add(item.Seri);
                    satir.SubItems.Add(item.Model);
                    satir.SubItems.Add(item.fiyat);
                    satir.SubItems.Add(item.Acıklama);
                    satir.Tag = item.ilanId;
                    listilanlar.Items.Add(satir);

                }

            }
            
        }
        ilan update;
        private void listilanlar_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(listilanlar.SelectedItems[0].Tag);
            ilanId ilanid = new ilanId();
            ilanid.ilanNo = id;
            db.ilanId.Add(ilanid);
            db.SaveChanges();



            GuncellemeSayfasi m = new GuncellemeSayfasi();
            m.Show();
        }

        private ilan ListViewSeciliItem(int id)
        {
            
            update = db.ilan.Find(id);
            return update;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
