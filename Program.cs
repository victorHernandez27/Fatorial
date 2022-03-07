using System;

namespace Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int fatorial = 1, resp;

            Console.WriteLine("Digite um numero para saber seu fatorial:");
            do
            {
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero < 0)                {
                   
                    Console.WriteLine("Não é permitido numeros negativos! Digite Novamente:");
                }               

            } while (numero < 0);                        

            resp = Fatorial(numero);

            /*
            for (int i = numero; i >= 1; i--)
            {
                fatorial = fatorial * i;
                Console.WriteLine(i + "*");
            }*/

            Console.WriteLine("O fatorial de {0} é: {1}",numero,resp);
            Console.ReadKey();
        }

        
        static int Fatorial(int numero)
        {
            int fatorial = 1;

            for (int i = numero; i >= 1; i--)
            {
                fatorial = fatorial * i;
                //Console.WriteLine(i + "*");
            }

            return fatorial;
        }
    }
}
