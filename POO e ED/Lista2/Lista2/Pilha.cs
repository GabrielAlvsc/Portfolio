
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lista2;

namespace Lista2
{
    public class Pilha : Object
    {

        private Noh topo;


        public Pilha()
        {
            topo = null;
        }

        public bool isEmpty()
        {
            if (topo == null)
                return true;
            else
                return false;
        }


        public void push(int insertItem)
        {
            if (isEmpty())
                topo = new Noh(insertItem);
            else
            {
                Noh next = new Noh(insertItem);
                next.setNext(topo);
                topo = next;
            }
        }

        public void print()
        {
            if (isEmpty())
                Console.WriteLine("Pilha Vazia");
            else
            {
                Console.WriteLine("Status atual da Pilha:");
                Noh temp = topo;

                while (temp != null)
                {
                    Console.WriteLine("\n" + temp.getData());
                    temp = temp.getNext();
                }
            }
        }

        public int pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Pilha Vazia");
                throw new Exception();

            }
            else
            {
                int temp = topo.getData();
                topo = topo.getNext();
                return (temp);
            }
        }

        public int getTopo()
        {
            return topo.getData();
        }

        public void setTopo(int value)
        {
            topo.setData(value);
        }

        

    }
}
