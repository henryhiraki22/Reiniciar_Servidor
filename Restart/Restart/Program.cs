using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Restart
{
    class Program
    {
        static void Main(string[] args)
        {

            int contador = 11;
            string aux;
            Console.WriteLine("Vamos reiniciar o seu pc em 10 segundos: ");

            for (int x = 0; x < contador; x++)
            {
                Thread.Sleep(100);
                Console.WriteLine(x);
            }
            Console.WriteLine("Se você quiser reiniciar MESMO o seu pc, digite: s, senao digite qualquer outra tecla pra sair. ");
            // Console.ReadKey();
            aux = Console.ReadLine();

            if (aux == "s")
            {
                Thread.Sleep(1000);
                Console.WriteLine("voce vai reiniciar");
                Thread.Sleep(1000);
                Process.Start("shutdown", "/r /t 10");
            }
            else
            {
                Thread.Sleep(1000);
                Console.WriteLine("voce nao vai reiniciar");
                Thread.Sleep(500);
                Environment.Exit(0);

            }
        }
    }
}
