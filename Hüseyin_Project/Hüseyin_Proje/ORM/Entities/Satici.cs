using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hüseyin_Proje.ORM.Entities
{
    internal class Satici
    {

        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string sifre { get; set; }
        public string SaticiAdi { get; set; }
        public string SaticiTelno { get; set; }
        

       
        public List<ilan> ilan { get; set; }

    }

}
