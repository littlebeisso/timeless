using System;

class Program

{
    static void Main()
    {
        Console.WriteLine ("Calculadora de Área do Retângulo");

        Console.Write("Insira a altura do retângulo: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Insira a largura do retângulo: ");
        double largura = Convert.ToDouble(Console.ReadLine());

        double area = altura * largura;

        Console.WriteLine("A área do retângulo é " + area + "m2");
    }
}
