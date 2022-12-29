using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Livro
    {
        public string Titulo { get; private set; }
        public string Autor { get; set; }
        public string ISBN { get; private set; }
        public int Ano { get; set; }
        public string Estilo { get; set; }
        public int Paginas { get; set; }
        public string Pais { get; set; }
        public Livro(string titulo, string isbn) 
        {
            this.Titulo = titulo;
            this.ISBN = isbn;
        }

        public void ExibeInformacoes()
        {
            Console.WriteLine($"Título {Titulo}");
            Console.WriteLine($"Autor {Autor}");
            Console.WriteLine($"ISBN {ISBN}");
            Console.WriteLine($"Ano {Ano}");
            Console.WriteLine($"Páginas {Paginas}");
            Console.WriteLine($"Estilo {Estilo}");
            Console.WriteLine($"País {Pais}");
        }
    }
}
