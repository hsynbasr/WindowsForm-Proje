using Hüseyin_Proje.ORM.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hüseyin_Proje.ORM.Context
{
    internal class ProjectContext:DbContext
    {
        public ProjectContext():base("Server=(localdb)\\MSSQLLocalDB; Database=AracSitesi; Integrated Security=true")
        {

        }
        public DbSet<Satici> Satici { get; set; }
       
        public DbSet<ilan> ilan { get; set; }
        
        public DbSet<Uyegirisi> uyegirisi { get; set; }
        public DbSet<ilanId> ilanId { get; set; }
       
    }
}
