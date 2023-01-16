using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hüseyin_Proje.ORM.Entities
{
    internal class ilan
    {
        public int ilanId { get; set; }
        
        public string ilanAdi { get; set; }
        public string ilanTipi { get; set; }
        public string fiyat { get; set; }
        public string Acıklama { get; set; }
        public string il { get; set; }
        public string Yakit { get; set; }
        public string Marka { get; set; }
        public string Seri { get; set; }
        public string Model { get; set; }
        public string Vites { get; set; }
        public string MotorHacmi { get; set; }
        public string MotorGucu { get; set; }
        public string KM { get; set; }
        public string Yıl { get; set; }
        public string Foto { get; set; }
        public int saticiId { get; set; }
        public Satici satici { get; set; }
    }
}
