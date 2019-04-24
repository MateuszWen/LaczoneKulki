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
        }

        List<MojWezel> sasiedzi = new List<MojWezel>();

    }
}
