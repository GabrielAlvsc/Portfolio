using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lista1;

namespace Lista1
{
    class Noh<TAD>
    {
        // atributos
        private Noh<TAD> previo;
        private TAD data;
        private Noh<TAD> next;

        // metodos
        public Noh() // construtor default 
        {
            previo = null;
            //data = 0;
            next = null;
        }

        public Noh(TAD n)
        {
            previo = null;
            data = n;
            next = null;
        }

        public Noh<TAD> getPrevio()
        {
            return previo;
        }

        public void setPrevio(Noh<TAD> _previo)
        {
            previo = _previo;
        }

        public TAD getData()
        {
            return data;
        }

        public void setData(TAD _data)
        {
            data = _data;
        }


        public Noh<TAD> getNext()
        {
            return next;
        }

        public void setNext(Noh<TAD> _next)
        {
            next = _next;
        }
    }
}