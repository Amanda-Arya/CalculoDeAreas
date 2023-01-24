// Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
// a) a área do triângulo retângulo que tem A por base e C por altura.
// b) a área do círculo de raio C. (pi = 3.14159)
// c) a área do trapézio que tem A e B por bases e C por altura.
// d) a área do quadrado que tem lado B.
// e) a área do retângulo que tem lados A e B.

using System;
namespace CalculoDeAreas
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }
    static void Menu()
    {
      Console.WriteLine(" De Qual forma geométrica você deseja calcular a área? ");
      Console.WriteLine("1- Triângulo Retângulo.");
      Console.WriteLine("2- Círculo.");
      Console.WriteLine("3- Trapézio.");
      Console.WriteLine("4- Quadrado.");
      Console.WriteLine("5- Retângulo.");
      Console.WriteLine("6- Sair");

      int opcao = int.Parse(Console.ReadLine());
      Console.WriteLine();
      
      switch(opcao)
      {
        case 1: AreaTrianguloRetangulo(); break;
        case 2: AreaCirculo(); break;
        case 3: AreaTrapezio(); break;
        case 4: AreaQuadrado(); break;
        case 5: AreaRetangulo(); break;
        case 6: System.Environment.Exit(0); break;
        default: Menu(); break;
      }    
    }
    static void AreaTrianguloRetangulo()
    {
      Console.WriteLine("Digite o valor da base A: ");
      float A = float.Parse(Console.ReadLine());
      Console.WriteLine("Digite o valor da altura C: ");
      float C = float.Parse(Console.ReadLine());

      float Ar = (A * C)/2;
      double Area = Math.Round(Ar, 2);
      Console.WriteLine($"A área é: {Area}");
    }
    static void AreaCirculo()
    {
      Console.WriteLine("Digite o valor do raio C: ");
      float C = float.Parse(Console.ReadLine());

      double Ar = 3.14 * (Math.Pow(C,2));
      double Area =Math.Round(Ar, 2);
      Console.WriteLine($"A área é: {Area}");
    }
    static void AreaTrapezio()
    {
      Console.WriteLine("Digite o valor da base A: ");
      float A = float.Parse(Console.ReadLine());
      Console.WriteLine("Digite o valor da outra base B: ");
      float B = float.Parse(Console.ReadLine());
      Console.WriteLine("Digite o valor da altura C: ");
      float C = float.Parse(Console.ReadLine());

      double Ar = ((A + B)*C)/2;
      double Area = Math.Round(Ar, 2);
      Console.WriteLine($"A área é: {Area}");
    }
    static void AreaQuadrado()
    {
      Console.WriteLine("Digite o valor da base A: ");
      float B = float.Parse(Console.ReadLine());
      
      float Ar = B * B;
      double Area = Math.Round(Ar, 2);
      Console.WriteLine($"A área é: {Area}");
    } 
    static void AreaRetangulo()
    {
      Console.WriteLine("Digite o valor da base A: ");
      float A = float.Parse(Console.ReadLine());
      Console.WriteLine("Digite o valor da altura B: ");
      float B = float.Parse(Console.ReadLine());

      float Ar = A * B;
      double Area = Math.Round(Ar, 2);
      Console.WriteLine($"A área é: {Area}");
    }

  }
}
