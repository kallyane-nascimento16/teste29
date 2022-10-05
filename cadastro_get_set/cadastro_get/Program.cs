using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_get
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cad p = new cad();
            p.Nome1= "lucas";
            Console.WriteLine(p.Nome1);

            cad a = new cad();
            a.Nome2 = "romulo";
            Console.WriteLine(a.Nome2);

            cad b = new cad();
            b.Nome3 = "kallyane";
            Console.WriteLine(a.Nome3);

            cad c = new cad();
            c.Nome4 = "vitor";
            Console.WriteLine(c.Nome4);

            cad d = new cad();
            d.Nome5 = "jaqueline";
            Console.WriteLine(d.Nome5);




        }
    }
}
