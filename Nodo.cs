using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvore
{
    public class Nodo
    {
        public int elemento;
        public Nodo esquerda;
        public Nodo direita;
        public Nodo(int elemento, Nodo esquerda, Nodo direita) {
            this.elemento = elemento;
            this.esquerda = esquerda;
            this.direita = direita;
        }
    }
}
