using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s141163
{
    public class KlasaTest : IBbb
    {
        private int numer;

        internal KlasaTest(int numer)
        {
            this.numer = numer;
        }

        public string TestMetoda(int Parametr)
        {
            return Parametr.ToString();
        }

        public int Druga()
        {
            return numer;
        }
    }
}
