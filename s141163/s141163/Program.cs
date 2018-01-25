using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s141163
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasaTest klasa = new KlasaTest(1);
            Console.WriteLine(klasa.Druga());
            Console.WriteLine(klasa.TestMetoda(2));
            LinkedList<double> lista = new LinkedList<double>();
            lista.AddFirst(3);
            lista.AddAfter(lista.Find(3), 4);
            lista.AddAfter(lista.Find(4), 5);
            lista.AddAfter(lista.Find(3), 3.5);
            lista.AddAfter(lista.Find(4), 4.5);
            foreach (var d in lista)
            {
                Console.WriteLine(d);
            }
            List<Bohater> postacie = new List<Bohater>();
            postacie.Add(new Bohater(2));
            postacie.Add(new Bohater(4));
            postacie.Add(new Elf(30, "sdsadsa"));
            postacie.Add(new Elf(40, "asdad"));
            postacie.Add(new Ork(50, 70));
            postacie.Add(new Ork(30, 90));
            postacie.Sort();
            postacie.Reverse();
            
            foreach (var item in postacie)
            {
                Console.WriteLine(item.ToString());
            }
            try
            {
                int hp = Convert.ToInt32(Console.ReadLine());
                Bohater uzytkownik = new Bohater(hp);
            }
            catch
            {
                Console.WriteLine();
            }
            
            List<int> ab = new List<int>();
            ab.Add(5);
            List<int> ac = new List<int>();
            ac.Add(3);
            Sport sport = Sport.Stworz("Pilka Nozna");
            Dictionary<string, List<int>> aa = new Dictionary<string, List<int>>();
            aa.Add("Eded", ab);
            aa.Add("dsadas", ac);
            Console.ReadKey();
        
        }
    }
}
