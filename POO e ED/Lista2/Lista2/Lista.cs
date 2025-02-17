using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lista2;

namespace Lista2
{
    class Lista
    {
        // atributos
        protected Noh INICIO;
        protected Noh FIM;

        // métodos
        public Lista() // construtor default
        {
            INICIO = null;
            FIM = null;
        }

        public bool estaVazia()
        {
            if (INICIO == null && FIM == null)
                return true;
            else
                return false;
        }

        public void insereInicio(int n)
        {
            Noh newNoh = new Noh(n);

            if (estaVazia()) // newNoh é o primeiro elemento da Lista
            {
                INICIO = newNoh;
                FIM = newNoh;
            }

            else
            {
                INICIO.setPrevio(newNoh);
                newNoh.setNext(INICIO);
                INICIO = newNoh;
            }
        } // fim do metodo insereInicio()

        public void insereFim(int n)
        {
            Noh newNoh = new Noh(n);

            if (estaVazia())
            {
                INICIO = newNoh;
                FIM = newNoh;
            }

            else
            {
                FIM.setNext(newNoh);
                newNoh.setPrevio(FIM);
                FIM = newNoh;
            }
        } // fim do metodo insereFim()

        public void imprimeListaE()
        {
            if (estaVazia())
            {
                Console.Write("Lista ");
                imprimeEsqDireita();
            }
            else
            {
                imprimeEsqDireita();
            }
        }

        public void imprimeListaD()
        {
            if (estaVazia())
            {
                Console.Write("Lista ");
                imprimeDirEsquerda();
            }
            else
            {
                imprimeDirEsquerda();
            }
        }
        protected void imprimeEsqDireita()
        {
            if (estaVazia())
                Console.WriteLine("Vazia");
            else
            {
                Noh temp = INICIO;
                while (temp != null) // while(temp)
                {
                    Console.Write(temp.getData() + " ");
                    temp = temp.getNext();
                }

            } // fim do else 

        } // fim do metodo imprimeEsqDireita()

        protected void imprimeDirEsquerda()
        {
            if (estaVazia())
                Console.WriteLine("Lista Vazia");
            else
            {
                Noh temp = FIM;
                while (temp != null) // while(temp)
                {
                    Console.Write(temp.getData() + " ");
                    temp = temp.getPrevio();
                }

            } // fim do else 

        } // fim do metodo imprimeDirEsquerda()

        public void Remove(int n) // não trata se a lista está vazia e considera que o elemento a ser removido está na lista!
        {
            Noh thisPtr = encontraNoh(n); // encontra o nó onde está o elemento a ser removido

            if (thisPtr == INICIO) // remover do INICIO da lista
            {
                INICIO = INICIO.getNext(); // INICIO = thisPtr.getNext();
                INICIO.setPrevio(null);
            }

            else if (thisPtr == FIM) // remover do FIM da lista
            {
                FIM = FIM.getPrevio();
                FIM.setNext(null);
            }

            else // remove um elemento do MEIO da lista
            {
                (thisPtr.getPrevio()).setNext(thisPtr.getNext());
                (thisPtr.getNext()).setPrevio(thisPtr.getPrevio());
            }

        } // fim do método Remove



        public Noh encontraNoh(int intEncontrado)
        {
            Noh foundNoh = INICIO;
            while (foundNoh != null) // percorre a lista a partir do INICIO 
            {
                if (Convert.ToString((foundNoh.getData())) == Convert.ToString(intEncontrado))
                    return (foundNoh);
                else
                    foundNoh = foundNoh.getNext();
            }
            return null;
        } // fim do método encontraNoh

        public Noh getI()
        {
            return INICIO;
        }

    }
}
