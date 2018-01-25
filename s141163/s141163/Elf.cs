using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s141163
{
    public class Elf : Bohater
    {
        private string magia;

        public Elf(int hp, string magia)
            : base(hp)
        {
            this.magia = magia;
        }

        public override bool ZadajCios(int obrazenia)
        {
            if (obrazenia > 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}