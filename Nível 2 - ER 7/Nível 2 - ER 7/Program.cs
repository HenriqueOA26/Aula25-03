using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nível_2___ER_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n1, n2, n3, n4, n5, total;

            Console.WriteLine("Digite o 1º Valor: ");
            int.TryParse(Console.ReadLine(), out n1);
            Console.WriteLine("Digite o 2º alor: ");
            int.TryParse(Console.ReadLine(), out n2);
            Console.WriteLine("Digite o 3º Valor ");
            int.TryParse(Console.ReadLine(), out n3);
            Console.WriteLine("Digite o 4º Valor ");
            int.TryParse(Console.ReadLine(), out n4);
            Console.WriteLine("Digite o 5º Valor ");
            int.TryParse(Console.ReadLine(), out n5);

            total = n1 + n2 + n3 + n4 + n5;

            Console.WriteLine("O total de valores digitados é : " + total);
        }
    }
}
