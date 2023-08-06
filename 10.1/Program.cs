using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберте роль:\r\n" +
                "1. Консультант;");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Consultant();
                    break;
                default:
                    Console.CursorLeft = 0;
                    Console.WriteLine("Вы ничего не выбрали");
                    Exit();
                    break;
            }
            void Exit()
            {
                Console.ReadKey();
                Environment.Exit(0);
            }

            void Consultant()
            {
                Consultant consultant = new Consultant();
                consultant.Handler();
            }
        }

    }
}
