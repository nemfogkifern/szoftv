using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZHMinta
{
    public partial class FormAddNew : Form
{
    public FormAddNew()
    {
        InitializeComponent();
    }
    public VizsgaKerdes ujKerdes(VizsgaKerdes uj)
        {
            uj.Szam = int.Parse(textBox1.Text);
            uj.V1 = textBox2.Text;
            uj.V2 = textBox3.Text;
            uj.V3 = textBox4.Text;
            uj.Kep = textBox5.Text;
            uj.HelyesValasz = int.Parse(textBox6.Text);

            return uj;
        }

}
}
