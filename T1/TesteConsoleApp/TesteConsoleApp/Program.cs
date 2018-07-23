using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TextReader leitor = Console.In)
            {
                string linha = Console.ReadLine();

                while (linha != null)
                {
                    linha = Console.ReadLine();
                }
            }
        }
    }
}
