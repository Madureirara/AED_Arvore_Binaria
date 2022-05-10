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
        int altura = 0;
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
            if (nodo != null)
            {              
                MostrarRecursivo(nodo.esquerda);
                Console.Write(nodo.elemento + " ");              
                MostrarRecursivo(nodo.direita);
            }
        }       
        public bool Pesquisar(int elemento)
        {
            return PesquisarRecursivo(elemento, raiz);
        }
        private bool PesquisarRecursivo(int elemento,Nodo nodo)
        {
            if (nodo==null)
            {
                return false;
            }
            else if(elemento<nodo.elemento)
            {   
                return PesquisarRecursivo(elemento, nodo.esquerda);
            }
            else if(elemento > nodo.elemento)
            {
                return PesquisarRecursivo(elemento, nodo.direita);
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
        public void QuantidadeFolha()
        {
            QuantidadeFolhaRecursivo(raiz);
        }
        private int QuantidadeFolhaRecursivo(Nodo nodo)
        {
            if (nodo==null)
            {
                return 0;
            }
            else if (nodo.esquerda==null&&nodo.direita==null)
            {
                return folhas++;
            }
            else
            {
                return QuantidadeFolhaRecursivo(nodo.esquerda) + QuantidadeFolhaRecursivo(nodo.direita);
            }
        }
        public void Altura()
        {          
            
            Console.WriteLine("A altura da Arvore é: "+AlturaRecursivo(raiz));
        }
        private int AlturaRecursivo(Nodo nodo)
        {
            if (nodo==null)
            {
                return -1;
            }
            else
            {
                int esquerda = 1+ AlturaRecursivo(nodo.esquerda);
                int direita = 1+ AlturaRecursivo(nodo.direita);
                if (esquerda > direita)
                {                                      
                    return esquerda ;
                }
                else
                {                                     
                    return direita ;
                }
            }
                   
        }
        public void Nivel(int elemento)
        {
           Console.WriteLine ($"O elemento {elemento} esta no nivel:"+ NivelRecursivo(elemento,raiz));
        }       
        public int NivelRecursivo(int elemento, Nodo nodo)
        {
            int nivel=0;
            if (nodo == null)
            {
               
                return 0;
            }
            else if(nodo.elemento == elemento)
            {
                return nivel;
            }
            else if (elemento < nodo.elemento)
            {
                nivel++;
                return  1+ NivelRecursivo(elemento, nodo.esquerda);
            }
            else
            {
                nivel++;
                return 1+ NivelRecursivo(elemento, nodo.direita);
            }
        }
        public void Grau(int elemento)
        {
            Console.WriteLine($"O nodo {elemento} tem grau :"+GrauRecursivo(elemento, raiz));
        }
        public int GrauRecursivo(int elemento, Nodo nodo)
        {
            int grau = 0;
            if (nodo == null)
            {
                return 0;
            }
            else if (nodo.elemento == elemento)
            {
                if (nodo.esquerda != null && nodo.direita!= null)
                {
                    return grau=2;
                }
                else if(nodo.esquerda != null && nodo.direita == null)
                {
                    return grau = 1;
                }
                else if(nodo.direita != null && nodo.esquerda == null)
                {
                    return grau = 1;
                }
            }
            else if (elemento < nodo.elemento)
            {
                
                return +GrauRecursivo(elemento, nodo.esquerda);
            }
            else
            {
                
                return GrauRecursivo(elemento, nodo.direita);
            }
            return grau;
        }
        //public void Elementos()
        //{
        //    ElementosRecursivo(raiz);
        //}
        //public int ElementosRecursivo(Nodo nodo) //Não consegui
        //{
        //    if (nodo != null)
        //    {
        //        if (nodo.elemento 
        //        {

        //        }
                
        //        MostrarRecursivo(nodo.direita);
        //    }
        //}

        public void mostrarNumNodo()
        {
            Console.WriteLine($"O numero de nós da Arvore é de:"+numNodo / 2);
            Console.WriteLine($"O numero de folhas da Arvore é de:"+folhas);
            //
        }

    }
}
