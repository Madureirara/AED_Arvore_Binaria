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
            arvore.mostrarNumNodo();
            arvore.remover(13);
            arvore.remover(80);
            arvore.remover(15);
            arvore.remover(65);
            arvore.Mostrar();
            arvore.mostrarNumNodo();
            arvore.Inserir(100);
            arvore.Inserir(90);
            arvore.Mostrar();
            arvore.mostrarNumNodo();
            Console.ReadKey();
        }
    }
}
