using Calculadora;
using System;

class Program
{
    public static void Main(string[] args)
    {
        Operacoes operacoes= new Operacoes();
        Console.WriteLine($"Soma: {operacoes.Soma.Calcular(10,19)}");
        Console.WriteLine($"Multiplicar: {operacoes.Multiplicar.Calcular(10, 19)}");
        Console.WriteLine($"Dividir: {operacoes.Dividir.Calcular(10, 19)}");
        Console.WriteLine($"Subtrair: {operacoes.Subtrair.Calcular(10, 19)}");
    }
}