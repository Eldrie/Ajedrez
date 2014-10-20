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

            for (int i = 0; i <= 3; i++) 
            {

                for (int x = 1; x <= 4; x++) 
                {
                    for (int y = 1; y <= 3; y++)
                    {
                        Console.Write(negra);
                    }
                    Console.Write(negra + "\n");
                }

                for (int y = 1; y <= 4; y++) 
                {
                    for (int z = 1; z <= 3; z++) 
                    {
                        Console.Write(blanca);
                    }
                    Console.Write(blanca + "\n");
                }
       
            }
            Console.Read();
        }
    }
}
