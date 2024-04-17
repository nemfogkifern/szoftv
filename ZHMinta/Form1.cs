using System.ComponentModel;
using System.Globalization;
using CsvHelper;

namespace ZHMinta
{
    public partial class Form1 : Form
    {
        BindingList<VizsgaKerdes> kerdesekLista = new();
        public Form1()
        {
            InitializeComponent();
            vizsgaKerdesBindingSource.DataSource = kerdesekLista;
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("Kerdesek/hajozasi_szabalyzat_coma.txt", true);
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var records = csv.GetRecords<VizsgaKerdes>();

                foreach (var record in records)
                {
                    kerdesekLista.Add(record);
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);

                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(kerdesekLista);

                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (vizsgaKerdesBindingSource.Current == null) return;

            if (MessageBox.Show("Szeretné törölni a kijelölt sort?", "Törlés", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                vizsgaKerdesBindingSource.RemoveCurrent();

            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            FormAddNew formAddNew = new FormAddNew();
            formAddNew.ShowDialog();
            if (formAddNew.DialogResult == DialogResult.OK)
            {
                var ujKerdes = new VizsgaKerdes();
                formAddNew.ujKerdes(ujKerdes);
                kerdesekLista.Add(ujKerdes);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (vizsgaKerdesBindingSource.Current == null) return;

            FormEdit formEdit = new FormEdit();
            formEdit.UjVizsgaKerdes = vizsgaKerdesBindingSource.Current as VizsgaKerdes;
            formEdit.Show();


        }
    }


    public class VizsgaKerdes
    {
        public int Szam { get; set; }
        public string Kerdes { get; set; }
        public string V1 { get; set; }
        public string V2 { get; set; }
        public string V3 { get; set; }
        public string Kep { get; set; }
        public int HelyesValasz { get; set; }
    }
}

