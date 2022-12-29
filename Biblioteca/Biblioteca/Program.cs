using Biblioteca;
using System;

class Program
{
    public static void Main(string[] args)
    {
        Livro livro = new Livro("Introdução ao SQL", "9788575225011");
        livro.Autor = "Thomas Nield";
        livro.Ano = 2016;
        livro.Estilo = "Programação";
        livro.Pais = "Estados Unidos";
        livro.Paginas = 144;

        livro.ExibeInformacoes();
    }
}