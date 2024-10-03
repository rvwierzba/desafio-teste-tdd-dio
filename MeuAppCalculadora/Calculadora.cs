using System;

namespace MeuAppCalculadora
{
    public class Calculadora
    {
        public int Somar(int a, int b) => a + b;
        public int Subtrair(int a, int b) => a - b;
        public int Multiplicar(int a, int b) => a * b;
        public double Dividir(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Não é possível dividir por zero.");
            return (double)a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var calculadora = new Calculadora();
            Console.WriteLine($"A soma de 5 e 3 é: {calculadora.Somar(5, 3)}");
            Console.WriteLine($"A subtração de 5 e 3 é: {calculadora.Subtrair(5, 3)}");
            Console.WriteLine($"A multiplicação de 5 e 3 é: {calculadora.Multiplicar(5, 3)}");
            Console.WriteLine($"A divisão de 5 por 3 é: {calculadora.Dividir(5, 3)}");
        }
    }
}
