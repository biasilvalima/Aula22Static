using System;

namespace Aula22Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue
            ;

            Conversor.CotacaoDolar = 5.25f;
            System.Console.WriteLine("O valor de U$15 em r$ é de: ");
            System.Console.WriteLine( Conversor.ConverterDolarParaReal (15));

            System.Console.WriteLine("O valor de r$50 em U$ é de: ");
            System.Console.WriteLine( Conversor.ConverterRealParaDolar (50));

            System.Console.WriteLine();

            Conversor.CotacaoEuro = 5.89f;
            System.Console.WriteLine("O valor de £15 em r$ é de: ");
            System.Console.WriteLine( Conversor.CoverterEuroParaReal (15));

            System.Console.WriteLine("O valor de r$50 em £ é de: ");
            System.Console.WriteLine( Conversor.ConverterRealParaEuro(50));

            Console.ResetColor();
        }
    }
}
