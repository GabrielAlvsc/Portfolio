using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lista2;


namespace Lista2
{
    public class Fila : Object
    {

        private Noh start;
        private Noh end;


        public Fila()
        {
            start = null;
            end = null;
        }


        public bool isEmpty()
        {
            if (start == null)
                return true;
            else
                return false;

        }




        public void inqueue(int valor)
        {
            Noh novonoh = new Noh(valor);

            if (isEmpty())
            {
                start = novonoh;
                end = novonoh;
            }
            else
            {
                end.setNext(novonoh);
                end = novonoh;
            }

        }

        public void inqueue(int search, int valor)
        {
            Noh novonoh = new Noh(valor);
            if (isEmpty())
            {
                start = novonoh;
                end = novonoh;
            }
            else
            {
                Noh aux = start;
                while (aux != null)
                {
                    if (aux.getData() == search)
                    {
                        Noh aux0 = aux.getNext();
                        novonoh.setNext(aux0);
                        aux.setNext(novonoh);
                        return;
                    }
                    aux = aux.getNext();

                }
                inqueue(valor);
            }
        }

        public void print()
        {
            if (isEmpty())
            {
                Console.WriteLine("Fila vazia");
            }
            else
            {
                Noh aux = start;
                while (aux != null)
                {
                    Console.Write(aux.getData() + " ");
                    aux = aux.getNext();
                }
            }
        }

        public int dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Fila Vazia");
                throw new Exception();
            }

            else
            {
                int aux = start.getData();
                start = start.getNext();
                return (aux);

            }
        }

        /*public int dequeue(int num)
        {
            if (isEmpty())
            {
                Console.WriteLine("Fila vazia");
                throw new Exception();
            }

            else
            {

                Noh aux = start;
                if (start.getData() == num)
                {
                    start = start.getNext();
                    return num;

                }
                while (aux != null)
                {
                    Noh aux0 = aux.getNext();
                    if (aux0 != null)
                    {
                        if (aux0.getData() == num)
                        {
                            aux0 = aux0.getNext();
                            aux.setNext(aux0);
                            return num;
                        }
                    }
                    aux = aux.getNext();
                }
                return num;
            }
        }
        */
        public int getStart()
        {
            return start.getData();
        }

        public void setStart(int value)
        {
            start.setData(value);
        }

        public int getEnd()
        {
            return end.getData();
        }

        public void setEnd(int value)
        {
            end.setData(value);
        }

    }
}
