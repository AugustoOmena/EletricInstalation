using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EletricInstalation.Entities
{
    class Casa
    {
        public double Altura { get; set; } = 0;
        public double Largura { get; set; } = 0;
        public double Total { get; set; } = 0;
        public int Com { get; set; } = 0;
        public string Comod { get; set; }

        public void Comodos()
        {
            Console.WriteLine("Quantos comodos?");
            Com = int.Parse(Console.ReadLine());
            Comod = "do comodo";
        }
        public void Tot()
        {
            try
            {
                for (int i = 1; i <= Com; i++)
                {
                    Console.Write($"Digite a Altura {Comod} {i}: ");
                    Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write($"Digite a Largura {Comod} {i}: ");
                    Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Total += Altura * Largura;
                }
            }
            catch
            {
                Console.WriteLine("Valor não aceito");
            }
        }

        public string Write()
        {
            return "O total é: " + Total.ToString("F2", CultureInfo.InvariantCulture) + "M²";
        }
    }

}
