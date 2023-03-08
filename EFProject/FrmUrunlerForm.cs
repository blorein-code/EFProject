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
    public partial class FrmUrunlerForm : Form
    {
        public FrmUrunlerForm()
        {
            InitializeComponent();
        }

        private void FrmUrunlerForm_Load(object sender, EventArgs e)
        {
            //Linq yapısı foreach'e benzemekte. Değer olarak id'yi, görüntülecek isim olarak AD verildi.
            var kategoriler = (from x in db.TBLKATEGORI
                               select new
                               {
                                   x.ID,
                                   x.AD
                               }
                               ).ToList();

            kategoriCombo.ValueMember = "ID";
            kategoriCombo.DisplayMember = "AD";
            kategoriCombo.DataSource = kategoriler;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        DBEntityUrunEntities db = new DBEntityUrunEntities();
        private void listeleBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLURUN select new
            {
                x.URUNID,
                x.URUNAD,
                x.MARKA,
                x.STOK,
                x.FIYAT,
                x.TBLKATEGORI.AD,
                x.DURUM
            }).ToList();
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            TBLURUN tableObject = new TBLURUN();
            tableObject.URUNAD = urunAdText.Text;
            tableObject.MARKA = markaText.Text;
            tableObject.STOK = short.Parse(stokText.Text);
            tableObject.FIYAT = decimal.Parse(fiyatText.Text);
            tableObject.DURUM = true;
            tableObject.KATEGORI = int.Parse(kategoriCombo.SelectedValue.ToString());

            db.TBLURUN.Add(tableObject);
            db.SaveChanges();

            MessageBox.Show("Ürün Sisteme Kaydedildi");
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(idText.Text);
            var urunFind = db.TBLURUN.Find(x);
            db.TBLURUN.Remove(urunFind);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi");
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(idText.Text);
            var urunFind = db.TBLURUN.Find(x);

            urunFind.URUNAD = urunAdText.Text;
            urunFind.STOK = short.Parse(stokText.Text);
            urunFind.MARKA = markaText.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi");
        }
    }
}
