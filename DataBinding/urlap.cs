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
using CsvHelper;

namespace DataBinding
{
    public partial class urlap : Form
    {
        public CountryData countryData;
        public urlap()
        {
            InitializeComponent();

            bindingSource1.DataSource = countryData;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            using (var writer = new StreamWriter("countries.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                // Write records to the CSV file
                csv.WriteRecords(countryList);
            };
        }
    }
}
