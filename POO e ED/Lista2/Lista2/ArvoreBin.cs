using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lista2;

namespace Lista2
{
    class ArvoreBin
    {
        // atributos 
        private NohArvore root;
        private Fila filarealoca;

        // métodos
        public ArvoreBin()
        {
            root = null;
            filarealoca = new Fila();
        }

        public bool isEmpty()
        {
            if (root == null)
                return true;
            else
                return false;
        }

        public void inserir(int n) // aridade 1
        {
            inserir(this.root, n); // aridade 2
        }

        public void inserir(NohArvore node, int valor) // aridade 2
        {                               // 10 e 15
            if (this.root == null)
            {
                this.root = new NohArvore(valor);
            }
            else
            {
                if (valor < node.getValor())
                { // insere a esquerda
                    if (node.getNoEsquerda() != null)
                    {
                        inserir(node.getNoEsquerda(), valor);
                    }
                    else // subarvore da esquerda está vazia
                    {
                        //Se nodo esquerdo vazio insere o novo no aqui 
                        node.setNoEsquerda(new NohArvore(valor));
                    }

                    //Verifica se o valor a ser inserido é maior que o noh corrente 
                    //da árrvore, se sim vai para subarvore direita 
                }
                else if (valor > node.getValor())
                {
                    //Se tiver elemento no no direito continua a busca 
                    if (node.getNoDireita() != null)
                    {
                        inserir(node.getNoDireita(), valor);
                    }
                    else // subárvore da direita está vazia
                    {
                        //Se nodo direito vazio insere o novo no aqui 
                        node.setNoDireita(new NohArvore(valor));
                    }
                } // fim do if para inserir a direita
            }

        } // fim do metodo inserir - aridade 2

        public void imprimirArvore()
        {
            if (this.root == null)
                Console.WriteLine("Árvore vazia");
            else
                imprimirArvore(this.root);
        }

        public void imprimirArvore(NohArvore node)
        {
            if (node.getNoEsquerda() != null)
            {
                imprimirArvore(node.getNoEsquerda());
            }

            Console.WriteLine("Noh: " + node.getValor());

            if (node.getNoDireita() != null)
            {
                imprimirArvore(node.getNoDireita());
            }

        }

        public NohArvore getRoot()
        {
            return root;
        }

        public NohArvore search(int n)
        {
            if (this.root == null)
            {
                Console.WriteLine("Árvore vazia");
                return new NohArvore(-1); //nao achou o no
            }
            else
            {
                return search(n, this.root);
            }
        }

        public NohArvore search(int n, NohArvore node)
        {
            if (node.getValor() == n)
            {
                return node;
            }
            else
            {
                if (node.getNoDireita() != null)
                {
                    if (n > node.getValor())
                    {
                        return search(n, node.getNoDireita());
                    }
                }
                if (node.getNoEsquerda() != null)
                {
                    if (n < node.getValor())
                    {
                        return search(n, node.getNoEsquerda());
                    }
                }
                
            }

            return new NohArvore(-1); //nao achou o no

        }
        public void remover(int n)
        {
            if (this.root == null)
                Console.WriteLine("Árvore vazia");
            else
            {
                NohArvore toremove = search(n);
                if (toremove.getValor() == -1)
                {
                    Console.WriteLine("Valor: " + n + " não encontrado");
                }
                else
                {
                   
                    transferqueue(toremove);
                    remocao(toremove, this.root);
                    filarealoca.dequeue();
                    //filarealoca.print();
                    Console.WriteLine();
                    //realocacao
                    while (!(filarealoca.isEmpty()))
                    {
                        inserir(filarealoca.getStart());
                        filarealoca.dequeue();
                    }
                }
            }
        }

        public void transferqueue(NohArvore node)
        {
            filarealoca.inqueue(node.getValor());
            if (node.getNoEsquerda() != null)
            {
                transferqueue(node.getNoEsquerda());
            }

            

            if (node.getNoDireita() != null)
            {
                transferqueue(node.getNoDireita());
            }

        }

        public void remocao(NohArvore r, NohArvore node)
        {
            if (r.getValor() == node.getValor()) //o no a ser removido é o root
            {
                this.root = null;
            }
            if (node.getNoDireita() != null)
            {
                if (node.getNoDireita() == r)
                {
                    node.setNoDireita(null);
                }
                else
                {
                    remocao(r, node.getNoDireita());
                }
            }
            if(node.getNoEsquerda() != null)
            {
                if (node.getNoEsquerda() == r)
                {
                    node.setNoEsquerda(null);
                }
                else
                {
                    remocao(r, node.getNoEsquerda());
                }
            }
            
            
        }


    } // fim da classe ArvoreBin
}
