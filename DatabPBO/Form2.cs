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
    public partial class Form2 : Form
    {
        Pasien pasien;
        public enum Mode { Insert}
        Mode mode;
        public Form2()
        {
            InitializeComponent();
            mode = Mode.Insert;
            btnDaftar.Text = "Daftar";
        }
        private void InputData()
        {
            if (tbNama.Text != "" && tbNIK.Text != "" && tbJK.Text != "")
            {
                using (var db = new PasienModel())
                {
                    pasien = new Pasien
                    {
                        Nama = tbNama.Text,
                        NIK = tbNIK.Text,
                        JenisKelamin = tbJK.Text,
                        JenisTes = tbJT.Text,
                    };
                    db.Pasiens.Add(pasien);
                    db.SaveChanges();
                    MessageBox.Show("Pasien telah terdaftar");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Data pasien harus diisi");
            }
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Insert)
                InputData();
        }
    }
}
