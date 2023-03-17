using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO.Compression;

namespace EletricInstalation.Entities
{
    class registroDaCasa
    {
        public double Altura { get; set; } = 0;
        public double Largura { get; set; } = 0;
        public double Total { get; set; } = 0;
        public int Com1 { get; set; } = 0;
        public int Com2 { get; set; } = 0;
        public int Com3 { get; set; } = 0;
        public int Com4 { get; set; } = 0;
        public int Com5 { get; set; } = 0;
        public int Repet { get; set; } = 0;
        public string Comod { get; set; } = null;
        public List<int> ComodList { get; set; } = new List<int> ();

        public void regNumeroDeComodos()
        {
            Console.WriteLine("Quantos salas?");
            Com1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos quartos?");
            Com2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas cozinhas?");
            Com3 = int.Parse(Console.ReadLine());

            ComodList.Add(Com1);
            ComodList.Add(Com2);
            ComodList.Add(Com3);
        }
        
        public void regCalculaArea()
        {
            try
            {
                int sal = ComodList[0];
                int qua = ComodList[1];
                int coz = ComodList[2];
                for (int go = 0; go <= 2; go++)
                {
                    int Q = ComodList[go] + 1;
                    if (go == 0)
                    {
                        Comod = "da Sala";
                    }
                    if (go == 1)
                    {
                        Comod = "do Quarto";
                    }
                    if (go == 2)
                    {
                        Comod = "da Cozinha";
                    }

                    for (int i = 1; i < Q; i++)
                    {

                        Console.Write($"Digite a Altitude A {Comod} {i}: ");
                        Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write($"Digite a Latitude L {Comod} {i}: ");
                        Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.WriteLine("--------------------------------------------------------------");
                        Total += Altura * Largura;

                    }
                }
            }
            catch
            {
                Console.WriteLine("Valor não aceito");
            }
        }

        public string regResultado()
        {
            return "O total é: " + Total.ToString("F2", CultureInfo.InvariantCulture) + "M²";
        }
    }

}
