using System;
using EletricInstalation.Entities;

namespace eletricArea
{
    class Program
    {
        public static void Main(string[] args)
        {
            Casa casa = new Casa();
            casa.Comodos();
            casa.Tot();
            Console.WriteLine(casa.Write());
        }
    }
}