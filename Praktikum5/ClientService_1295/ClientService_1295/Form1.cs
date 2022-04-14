using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClientService_1295
{
    public partial class Form1 : Form
    {
        LayananKonversi.WebService1 MyService;
        double CtoR, CtoF, CtoK;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyService = new LayananKonversi.WebService1();
        }
        private void btnKonversi_Click(object sender, EventArgs e)
        {
            CtoR = MyService.CelCiusToReamur(int.Parse(txtCel.Text));
            CtoF = MyService.CelCiusToFahrenheit(int.Parse(txtCel.Text));
            CtoK = MyService.CelCiusToKelvin(int.Parse(txtCel.Text));

            txtRe.Text = CtoR.ToString() + " R";
            txtFa.Text = CtoF.ToString() + " F";
            txtKe.Text = CtoK.ToString() + " K";
        }

    }
}
