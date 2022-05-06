using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvore
{
    class Arvore
    {
        Nodo raiz;
        int numNodo;
        int folhas;
        public Arvore()
        {
            this.raiz = null;
        }         
        public void Mostrar() 
        {
            Console.WriteLine("[ ");
            MostrarRecursivo(raiz);
            Console.WriteLine("]");
            
        }
        private void MostrarRecursivo(Nodo nodo)
        {
            if (nodo!=null)
            {
                MostrarRecursivo(nodo.esquerda);             
                Console.Write(nodo.elemento+" ");           
                MostrarRecursivo(nodo.direita);                
            }        
        }      
        public bool Pesquisar(int elemento)
        {
            return Pesquisar(elemento, raiz);
        }
        private bool Pesquisar(int elemento,Nodo nodo)
        {
            if (nodo==null)
            {
                return false;
            }
            else if(elemento<nodo.elemento)
            {   
                return Pesquisar(elemento, nodo.esquerda);
            }
            else if(elemento > nodo.elemento)
            {
                return Pesquisar(elemento, nodo.direita);
            }
            else 
            {
                return true;
            }             
        }
        public Nodo InserirRecursivo(int elemento, Nodo nodo) 
        {
            if (nodo == null)
            {
                nodo = new Nodo(elemento, null, null);
                numNodo++;
                return nodo;
            }
            else if (elemento < nodo.elemento)
            {
                nodo.esquerda = InserirRecursivo(elemento, nodo.esquerda);
                
                return nodo;
            }
            else if (elemento > nodo.elemento)
            {
                nodo.direita = InserirRecursivo(elemento, nodo.direita);
                
                return nodo;
            }
            else
            {
                throw new Exception($"ERRO: O elemento {elemento} já existe na árvore!");
            }
        }
        public void Inserir(int elemento)
        {
            raiz = InserirRecursivo(elemento, raiz);
            numNodo++;
        }
        public void remover(int elemento)
        {
            RemoverRecursivo(elemento, raiz);
        }
        public Nodo RemoverRecursivo(int elemento,Nodo nodo)
        {
            if (nodo.elemento == elemento)
            {
                if (nodo.direita == null)
                {
                   nodo  = nodo.esquerda;
                   numNodo--;
                }
                else if (nodo.esquerda==null)
                {
                    nodo = nodo.direita;
                   numNodo--;
                }
                numNodo--;
                return nodo;
            }
            else if (elemento<nodo.elemento)
            {
                nodo.esquerda = RemoverRecursivo(elemento, nodo.esquerda);
                return nodo;
            }
            else if (elemento>nodo.elemento)
            {
                nodo.direita=RemoverRecursivo(elemento, nodo.direita);
                return nodo;
            }
            else
            {
                throw new Exception("Não foi possivel encontrar este elemento");
            }
        }
        public void mostrarNumNodo()
        {
            Console.Write(numNodo / 2);
        }
    }
}
