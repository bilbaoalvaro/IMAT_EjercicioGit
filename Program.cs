
using System;

namespace IMAT_GitTest
{
    internal class Program
    {
        static int Add(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            int primerDigito = 2; // Primer dígito de tu ID
            int ultimoDigito = 3; // Último dígito de tu ID

            Console.WriteLine($"Suma: {Add(primerDigito, ultimoDigito)}");
        }
    }
}
