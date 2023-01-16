using Hüseyin_Proje.ORM.Context;
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
    public partial class Otomobil : Form
    {
        ProjectContext db;
        public Otomobil()
        {
            InitializeComponent();
            db = new ProjectContext();
        }

        
    }
}
