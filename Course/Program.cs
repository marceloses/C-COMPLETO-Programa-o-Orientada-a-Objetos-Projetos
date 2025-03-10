using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// CTRL + F5 para executar
// Overflow é quando um calculo estrapola o limite da variável

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números");// Este bloco chama o método WriteLine com o argumento "Dig..."
            
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            //
            if (n1 > n2 && n1 > n3) {
                Console.WriteLine("Maior = " + n1);
            }

            else if (n2 > n3)
            {
                Console.WriteLine("Maior é o = " + n2);
            }

            else {
                Console.WriteLine("Maior é o = " + n3);
                 }


        }
    }
}
