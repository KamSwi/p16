using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s141163
{
    public class Sport
    {
        private string nazwa;

        private Sport(string nazwa)
        {
            this.nazwa = nazwa;
        }

        public static Sport Stworz(string nazwa)
        {
            return new Sport(nazwa);
        }
    }
}