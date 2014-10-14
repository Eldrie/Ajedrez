using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string negra = "####    ";
            string blanca = "    ####";
            string negra2 = "####    \n";
            string blanca2 = "    ####\n";

            for (int i = 0; i <= 2; i++) 
            {

                for (int x = 1; x <= 4; x++) 
                {
                    Console.Write(negra);
                    Console.Write(negra);
                    Console.Write(negra);
                    Console.Write(negra2);
                }

                for (int y = 1; y <= 4; y++) 
                {
                    Console.Write(blanca);
                    Console.Write(blanca);
                    Console.Write(blanca);
                    Console.Write(blanca2);
                }
       
            }
            Console.Read();
        }
    }
}
