namespace HajozasTeszt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Kerdes> �sszesK�rd�s = new List<Kerdes>();
            List<Kerdes> Akt�vK�rd�sek = new List<Kerdes>();

            �sszesK�rd�s = KerdesBeolvas();

            for (int i = 0; i < 7; i++)
            {
                Akt�vK�rd�sek.Add(�sszesK�rd�s[0]);

                �sszesK�rd�s.RemoveAt(0);
            }
            KerdesUC feladat = new KerdesUC(Akt�vK�rd�sek[6]);
            Controls.Add(feladat);


        }

        List<Kerdes> KerdesBeolvas()
        {
            List<Kerdes> kerdesek = new List<Kerdes>();
            StreamReader sr = new StreamReader("Kerdesek/hajozasi_szabalyzat_kerdessor_BOM.txt", true);

            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine() ?? string.Empty;
                string[] tomb = sor.Split('\t');
                if (tomb.Length != 7) continue;

                Kerdes k = new Kerdes();
                k.KerdesSzoveg = tomb[1];
                k.Valasz1 = tomb[2];
                k.Valasz2 = tomb[3];
                k.Valasz3 = tomb[4];
                k.URL = tomb[5];

                int.TryParse(tomb[6], out int JoValasz);

                k.HelyesValasz = JoValasz;


                kerdesek.Add(k);
            }
            sr.Close();

            return kerdesek;

        }

        
    }





    public class Kerdes()
    {
        public String KerdesSzoveg { get; set; }
        public String Valasz1 { get; set; }
        public String Valasz2 { get; set; }
        public String Valasz3 { get; set; }
        public String URL { get; set; }
        public int HelyesValasz { get; set; }
        public int HelyesValaszokSzama { get; set; }



    }

    internal class ValaszGomb : TextBox
    {
        public ValaszGomb()
        {
            BackColor = Color.LightGray;
            Multiline = true;
            ReadOnly = true;

            MouseEnter += V�laszGomb_MouseEnter;
            MouseLeave += V�laszGomb_MouseLeave;

            BorderStyle = BorderStyle.None;
            Cursor = Cursors.Hand;
        }

        private void V�laszGomb_MouseLeave(object? sender, EventArgs e)
        {
            BorderStyle = BorderStyle.None;
        }

        private void V�laszGomb_MouseEnter(object? sender, EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
