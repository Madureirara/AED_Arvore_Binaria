using System;

namespace Arvore
{
    class Program
    {
        static void Main(string[] args)
        {
            Arvore arvore = new Arvore();
            arvore.Inserir(20);
            arvore.Inserir(12);
            arvore.Inserir(10);
            arvore.Inserir(13);
            arvore.Inserir(24);
            arvore.Inserir(70);
            arvore.Inserir(60);
            arvore.Inserir(65);
            arvore.Inserir(80);
            arvore.Inserir(15);         
            arvore.Mostrar();
            arvore.QuantidadeFolha();
            arvore.mostrarNumNodo();           
            arvore.Nivel(65);
            arvore.Grau(13);
            arvore.Altura();                     
            Console.ReadKey();
        }
    }
}
