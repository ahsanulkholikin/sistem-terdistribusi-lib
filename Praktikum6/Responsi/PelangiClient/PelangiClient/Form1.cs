using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PelangiClient
{
    public partial class Form1 : Form
    {
        LayananPelangi.WebService1 MyService;
        string no;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyService = new LayananPelangi.WebService1();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            if (tNo.Text == "")
            {
                MessageBox.Show("Semua data menu harus diisi", "Peringatan");
                return;
            }

            int intNo;
            if (!int.TryParse(tNo.Text, out intNo))
            {
                MessageBox.Show("Isi Harga Harus Diisi Menggunakan Angka");
                return;
            }
            no = MyService.Pelangi(int.Parse(tNo.Text));
            tWarna.Text = no.ToString();
        }
    }
}
