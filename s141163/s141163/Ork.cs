using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s141163
{
    public class Ork : Bohater
        {
            private int walka;

            public Ork(int hp, int walka)
                : base(hp)
            {
                this.walka = walka;
            }

            public override bool ZadajCios(int obrazenia)
            {
                if (obrazenia > 20)
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

