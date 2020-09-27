using System;

namespace formulaheron
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            double C;
            double perimetro;
            double area;
             
             Console.Write("Digite o valor A: ");
             A = double.Parse(Console.ReadLine());

             Console.Write("Digite o valor de B: ");
             B = double.Parse(Console.ReadLine());

             Console.Write("Digite o valor de C: ");
             C = double.Parse( Console.ReadLine());
            Console.Write("\n");

            perimetro = (A + B + C ) / 2;
            area = Math.Sqrt(perimetro * (perimetro - A) * (perimetro - B) * (perimetro - C ));

           Console.WriteLine("Semiperimetro = {0}",perimetro);
           Console.WriteLine("Area = {0}(cm²)", A);
           Console.Write("\n");

           Console.WriteLine("Pressione ENTER sair!");
           Console.ReadKey();
        }
    }
}