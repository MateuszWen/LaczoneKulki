using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaczoneKulki
{
    public partial class Form1 : Form
    {
        int klikX;
        int klikY;

        public static List<MojWezel> lista = new List<MojWezel>();

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            Pen pioro = new Pen(Color.Black, 3);
            Graphics g = e.Graphics;

            for (int i = 0; i < lista.Count; i++)
            {
                Rectangle rect = new Rectangle(lista[i].klikX-15, lista[i].klikY-15, 30, 30);
                g.DrawEllipse(pioro, rect);
                for (int j = 0; j < lista[i].sasiedzi.Count; j++)
                {
                    g.DrawLine(pioro, lista[i].klikX, lista[i].klikY, lista[j].klikX, lista[j].klikY);
                }
            }
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            label1_WyswietlPozycje.Text = e.X + " " + e.Y;
        }

        private void splitContainer1_Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            klikX = e.X;
            klikY = e.Y;
            MojWezel nowaKuleczka = new MojWezel(klikX, klikY);
            lista.Add(nowaKuleczka);
            splitContainer1.Panel2.Refresh();
        }
    }
}
