using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Seja bem vindo usuário 01!");
        Console.WriteLine("Está calor na sua cidade ?");
        
        Console.Write("Digite a temperatura em  °C: ");
        double temperatureCelsius = Convert.ToDouble(Console.ReadLine());

        double temperatureFahrenreit = (temperatureCelsius * 9 / 5) + 32;

        Console.WriteLine("A temperatura na sua cidade em Fahrenheit está em:" + temperatureFahrenreit + "°F" );


    }


}
