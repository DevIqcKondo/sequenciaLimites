using System;

namespace sequenciaLimites
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =0;
            int b =0;
            Console.WriteLine("+---------------------+");
            Console.WriteLine("|--Sequencia Limites--|");
            Console.WriteLine("+---------------------+");
            Console.Write("Inicio: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Fim: ");
            b = Convert.ToInt32(Console.ReadLine());
            if(a >= b)
            {
                Console.BackgroundColor=ConsoleColor.Red;
                Console.ForegroundColor=ConsoleColor.Black;
                Console.WriteLine("ERRO");
                Console.ResetColor();
                Console.WriteLine("Número inserido para inicio é maior que o número final!");
            }
            else
            {
                for( int i = a; i <=b ; i++)
                {
                    Console.WriteLine(i);    
                }
            }
        }
    }
}
