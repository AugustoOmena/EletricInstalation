using System;
using EletricInstalation.Entities;

namespace eletricArea
{
    class Program
    {
        public static void Main(string[] args)
        {
            registroDaCasa casa = new registroDaCasa();
            casa.regNumeroDeComodos();
            casa.regCalculaArea();
            Console.WriteLine(casa.regResultado());
            Console.WriteLine("Fim do Projeto");
        }
    }
}