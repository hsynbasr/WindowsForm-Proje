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
    public partial class KullaniciiLanListeleme : Form
    {
        ProjectContext db;
        public KullaniciiLanListeleme()
        {
            InitializeComponent();
            db = new ProjectContext();

        }
        ListViewItem lvi;
        private void btn_Listele_Click(object sender, EventArgs e)
        {
            listilanlar.Items.Clear();
            foreach (var item in db.ilan.ToList())
            {
                if (item.ilanTipi==comboBox_ilanTipi.Text)
                {
                    lvi = new ListViewItem();
                    lvi.Text = item.ilanId.ToString();
                    lvi.SubItems.Add(item.Marka);
                    lvi.SubItems.Add(item.Seri);
                    lvi.SubItems.Add(item.Model);
                    lvi.SubItems.Add(item.fiyat);
                    lvi.SubItems.Add(item.il);
                    lvi.SubItems.Add(item.Acıklama);
                    lvi.Tag = item.ilanId;
                    listilanlar.Items.Add(lvi);
                    
                }

            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void KullaniciiLanListeleme_Load(object sender, EventArgs e)
        {

        }

        private void listilanlar_DoubleClick(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(listilanlar.SelectedItems[0].Tag) ;
            ilanId n = new ilanId();
            n.ilanNo = a;
            db.ilanId.Add(n);
            db.SaveChanges();
           

            ilanOzellikleri m = new ilanOzellikleri();
            m.Show();

        }
    }
}
