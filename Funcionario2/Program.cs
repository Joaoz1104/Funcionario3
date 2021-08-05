using System;

namespace Funcionario2
{
    class Program
    {
        static void Main(string[] args)
        {
            Salario s = new Salario();
            Console.WriteLine("Dados do primeiro funcionário:");

            Console.WriteLine("Nome:");
            s.Nome1 = Console.ReadLine();

            Console.WriteLine("Salário:");
            s.Salario1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário:");
            Console.WriteLine("Nome:");
            s.Nome2 = Console.ReadLine();

            Console.WriteLine("Salário:");
            s.Salario2 = int.Parse(Console.ReadLine());

            Console.WriteLine(s);

        }
    }
}
