using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFProject
{
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }


        DBEntityUrunEntities db = new DBEntityUrunEntities();
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.TBLKATEGORI.Count().ToString();
            label3.Text = db.TBLURUN.Count().ToString();
            label13.Text = db.TBLURUN.Sum(y => y.STOK).ToString();
            label21.Text = db.TBLSATIS.Sum(z => z.FIYAT).ToString() + " TL";
            label11.Text = (from x in db.TBLURUN orderby x.FIYAT descending select x.URUNAD).FirstOrDefault();
            label9.Text = (from x in db.TBLURUN orderby x.FIYAT ascending select x.URUNAD).FirstOrDefault();
            label23.Text = (from x in db.TBLMUSTERI select x.SEHIR).Distinct().Count().ToString();
        }
    }
}
