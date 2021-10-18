using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiObjektnoOrijentiranogProgramiranjaZadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sport nogomet = new Sport("Nogomet", true, 11);
            Sport vaterpolo = new Sport("Vaterpolo", true, 7);
            Sport curling = new Sport("Curling", false, 5);

            Console.ReadKey();
        }
    }
}
