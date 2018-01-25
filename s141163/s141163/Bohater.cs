using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s141163
{
    public class Bohater : IComparable
    {
        private int hp;

        public Bohater(int hp)
        {
            this.hp = hp;
        }

        public override string ToString()
        {
            return hp.ToString();
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Bohater otherBohater = obj as Bohater;
            if (otherBohater != null)
                return this.hp.CompareTo(otherBohater.hp);
            else
                return 0;
        }

        public virtual bool ZadajCios(int obrazenia)
        {
            if (obrazenia < 20)
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