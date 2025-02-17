using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lista2;

namespace Lista2
{
    class Noh
    {
        // atributos
        private Noh previo;
        private int data;
        private Noh next;

        // metodos
        public Noh() // construtor default 
        {
            previo = null;
            //data = 0;
            next = null;
        }

        public Noh(int n)
        {
            previo = null;
            data = n;
            next = null;
        }

        public Noh getPrevio()
        {
            return previo;
        }

        public void setPrevio(Noh _previo)
        {
            previo = _previo;
        }

        public int getData()
        {
            return data;
        }

        public void setData(int _data)
        {
            data = _data;
        }


        public Noh getNext()
        {
            return next;
        }

        public void setNext(Noh _next)
        {
            next = _next;
        }
    }
}