using System.ComponentModel;
using System.Globalization;
using CsvHelper;

namespace DataBinding
{
    public partial class Form1 : Form
    {
        public BindingList<CountryData> countryList = new BindingList<CountryData>();
        public Form1()
        {
            InitializeComponent();
            countryDataBindingSource.DataSource = countryList;
            dataGridView1.DataSource = countryDataBindingSource;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("european_countries.csv");

            var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
            var tomb = csv.GetRecords<CountryData>();

            foreach (var record in tomb)
            {
                countryList.Add(record);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            countryDataBindingSource.RemoveCurrent();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            urlap szerkesztes = new urlap();
            szerkesztes.countryData = countryDataBindingSource.Current as CountryData;
            szerkesztes.Show();
        }
    }

}
