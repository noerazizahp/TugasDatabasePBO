using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabPBO
{
    public partial class Form1 : Form
    {
 
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIsi_Click(object sender, EventArgs e)
        {
            Form2 PasienForm = new Form2();
            PasienForm.ShowDialog();
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {

        }

        private void btnOke_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblName.Text = "-";
            lblID.Text = "-";
            lblJEK.Text = "-";
            lblJET.Text = "-";
            btnIsi.Enabled = false;
            using (var db = new PasienModel())
            {
                var query = from pasien in db.Pasiens where pasien.Nama == tbNP.Text select pasien;
                foreach (var item in query)
                {
                    lblName.Text = item.Nama;
                    lblID.Text = item.NIK;
                    lblJEK.Text = item.JenisKelamin;
                    lblJET.Text = item.JenisTes;
                    btnIsi.Enabled = true;
                }
            }
        }
        
    }
}
