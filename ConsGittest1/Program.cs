using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsGittest1
{
    class Program
    {
        static void Main(string[] args)
        {
            gClass tut = new gClass() { id=3, navn="kurt"} ;
            Console.WriteLine("Hello 1.0 {0}", tut.navn);
            Console.ReadLine();

        }
    }
}
