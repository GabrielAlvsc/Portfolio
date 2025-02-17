using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGabrielAlvesFinal
{
    public class Lista<T> where T : class
    {
        private NohLista<T> INICIO;
        private NohLista<T> FIM;
        private int count;

        public int Count { get => count; set => count = value; }

        public Lista()
        {
            INICIO = null;
            FIM = null;
            Count = 0;
        }

        public bool estaVazia()
        {
            if (INICIO == null && FIM == null)
                return true;
            else
                return false;
        }

        public void insereInicio(T n)
        {
            NohLista<T> newNoh = new NohLista<T>(n);

            if (estaVazia())
            {
                INICIO = newNoh;
                FIM = newNoh;
            }

            else
            {
                INICIO.setPrior(newNoh);
                newNoh.setNext(INICIO);
                INICIO = newNoh;
            }
            Count++;
        }

        public void insereFim(T n)
        {
            NohLista<T> newNoh = new NohLista<T>(n);

            if (estaVazia())
            {
                INICIO = newNoh;
                FIM = newNoh;
            }

            else
            {
                FIM.setNext(newNoh);
                newNoh.setPrior(FIM);
                FIM = newNoh;
            }
            Count++;
        }

        public void Remove(T n) // não trata se a lista está vazia e considera que o elemento a ser removido está na lista!
        {
            NohLista<T> thisPtr = encontraNoh(n); // encontra o nó onde está o elemento a ser removido
            if (thisPtr == INICIO && thisPtr == FIM)
            {
                INICIO = null;
                FIM = null;
                Count = 0;
            }

            else if (thisPtr == INICIO) // remover do INICIO da lista
            {
                INICIO = INICIO.getNext(); // INICIO = thisPtr.getNext();
                INICIO.setPrior(null);
            }

            else if (thisPtr == FIM) // remover do FIM da lista
            {
                FIM = FIM.getPrior();
                FIM.setNext(null);
            }

            else // remove um elemento do MEIO da lista
            {
                (thisPtr.getPrior()).setNext(thisPtr.getNext());
                (thisPtr.getNext()).setPrior(thisPtr.getPrior());
            }
            Count--;

        } // fim do método Remove



        public NohLista<T> encontraNoh(T intEncontrado)
        {
            NohLista<T> foundNoh = INICIO;
            while (foundNoh != null) // percorre a lista a partir do INICIO 
            {
                if (foundNoh.getData() == intEncontrado)
                    return (foundNoh);
                else
                    foundNoh = foundNoh.getNext();
            }
            return null;
        }


        public void imprime()
        {
            if (estaVazia())
                Console.WriteLine("Lista Vazia");
            else
            {
                NohLista<T> temp = INICIO;
                while (temp != null) // while(temp)
                {
                    Console.Write(temp.getData() + "    ");
                    temp = temp.getNext();
                }

            } // fim do else 
        }

        public T get(int i)
        {
            int c = 0;
            NohLista<T> temp = INICIO;
            while (c != i)
            {
                temp = temp.getNext();
                c++;
            }
            return temp.getData();
        }

    }
}
