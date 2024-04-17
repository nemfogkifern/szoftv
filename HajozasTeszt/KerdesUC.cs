using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HajozasTeszt
{
    public partial class KerdesUC : UserControl
    {
        public KerdesUC()
        {
            InitializeComponent();
        }

        public KerdesUC(Kerdes kerdes)
        {
            InitializeComponent();
            label1.Text = kerdes.KerdesSzoveg;
            valaszGomb1.Text = kerdes.Valasz1;
            valaszGomb2.Text = kerdes.Valasz2;
            valaszGomb3.Text = kerdes.Valasz3;
            if (!string.IsNullOrEmpty(kerdes.URL))
            {
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kerdes.URL);
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }

        }

    }



}
