using Colegio;
using System;

class Program
{
    public static void Main (string[] args)
    {
        Aluno aluno = new Aluno();

        aluno.Matricula = 23;
        aluno.Nome = "Marcelo Oliveira";
        aluno.Email = "marcelo.oliveira@gmail.com";
        aluno.Status = true;
        aluno.TipoCurso = 1;

        Console.WriteLine($"Matricula: {aluno.Matricula}");
        Console.WriteLine($"Nome: {aluno.Nome}");
        Console.WriteLine($"E-mail: {aluno.Email}");
        Console.WriteLine($"Status: {aluno.Status}");
        Console.WriteLine($"Tipo do curso: {aluno.TipoCurso}");
    }
}