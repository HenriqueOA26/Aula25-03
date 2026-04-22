using System;
class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());
        if (numero >= 10 && numero <= 50)
            Console.WriteLine("O número está entre 10 e 50");
        else
            Console.WriteLine("O número NÃO está entre 10 e 50");
    }
}