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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DBEntityUrunEntities db = new DBEntityUrunEntities();

        private void listeleBtn_Click(object sender, EventArgs e)
        {
            var kategoriler = db.TBLKATEGORI.ToList();
            dataGridView1.DataSource = kategoriler;
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            TBLKATEGORI tableObject = new TBLKATEGORI();
            tableObject.AD = adText.Text;
            db.TBLKATEGORI.Add(tableObject);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi");
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            //Silinicek kategorinin ID'sini elle girmek için.
            int x = Convert.ToInt32(idText.Text);
            var kategoriFind = db.TBLKATEGORI.Find(x);
            db.TBLKATEGORI.Remove(kategoriFind);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi");
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            //Güncellenecek kategorinin ID'sini elle girmek için.
            int x = Convert.ToInt32(idText.Text);
            var kategoriFind = db.TBLKATEGORI.Find(x);

            kategoriFind.AD = adText.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellendi");

        }
    }
}
