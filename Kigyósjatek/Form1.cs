using System.Windows.Forms.VisualStyles;

namespace Kigyósjatek
{
    public partial class Form1 : Form
    {
        int fejX = 100;
        int fejY = 100;
        int irányX = 1;
        int irányY = 0;
        int hossz = 5;
        int lépésszám;
        public Form1()
        {
            InitializeComponent();

            KeyDown += Form1_KeyDown;



        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && irányY != 1)
            {
                irányY = -1;
                irányX = 0;
            }
            if (e.KeyCode == Keys.Down && irányY != -1)
            {
                irányY = 1;
                irányX = 0;
            }
            if (e.KeyCode == Keys.Left && irányX != 1)
            {
                irányX = -1;
                irányY = 0;
            }
            if (e.KeyCode == Keys.Right && irányX != -1)
            {
                irányX = 1;
                irányY = 0;
            }
        }

        internal class KígyóElem : PictureBox
        {
            public static int Méret = 20;

            public KígyóElem()
            {
                Width = KígyóElem.Méret;
                Height = KígyóElem.Méret;
                BackColor = Color.Fuchsia;


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fejX += irányX * KígyóElem.Méret;
            fejY += irányY * KígyóElem.Méret;

            foreach(KígyóElem item in Controls)
            {
                if (item.Top == fejY && item.Left == fejX) 
                {
                        Application.Exit();
                }
            }
            if (Controls.Count > hossz)
            {
                Controls.RemoveAt(0);
            }

            KígyóElem újFej = new KígyóElem();
            if(lépésszám % 2 == 0)
            {
                újFej.BackColor = Color.Black;
            }

            Controls.Add(újFej);
            újFej.Left = fejX;
            újFej.Top = fejY;

            lépésszám++;
        }
    }
}
