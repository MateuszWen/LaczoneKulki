using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaczoneKulki
{
    public class MojWezel 
    {
        public int klikX;
        public int klikY;

        public MojWezel(int klikX, int klikY)
        {
            this.klikX = klikX;
            this.klikY = klikY;

            checkNeighbours(); //check neighbours (function below)
        }

        public List<MojWezel> sasiedzi = new List<MojWezel>();

        void checkNeighbours()
        {
            double c = 0; //variable of distance between two elipse

            for(int i=0; i< Form1.lista.Count; i++)
            {
                c = Math.Sqrt(Math.Pow(Math.Abs(this.klikX - Form1.lista[i].klikX), 2) + Math.Pow(Math.Abs(this.klikY - Form1.lista[i].klikY), 2));

                if(c < 150)
                {
                    sasiedzi.Add(Form1.lista[i]);
                    Form1.lista[i].sasiedzi.Add(this);
                }
            }
        }

    }
}
