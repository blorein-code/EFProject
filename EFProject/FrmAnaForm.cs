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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void kategoriBtn_Click(object sender, EventArgs e)
        {
            Form1 kategoriForm = new Form1();
            kategoriForm.Show();
            
        }

        private void urunBtn_Click(object sender, EventArgs e)
        {
            FrmUrunlerForm urunlerForm = new FrmUrunlerForm();
            urunlerForm.Show();
        }

        private void istatistikBtn_Click(object sender, EventArgs e)
        {
            FrmIstatistik istatistikorm = new FrmIstatistik();
            istatistikorm.Show();
        }
    }
}
