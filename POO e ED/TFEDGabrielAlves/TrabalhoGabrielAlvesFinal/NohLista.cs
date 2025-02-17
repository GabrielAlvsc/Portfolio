using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGabrielAlvesFinal
{
    public class NohLista<T>
    {
        private T data;
        private NohLista<T> next;
        private NohLista<T> prior;


        public NohLista()
        {
            Prior = null;
            Next = null;
        }
        public NohLista(T valor)
        {
            Data = valor;
            Prior = null;
            Next = null;

        }

        public T Data { get => data; set => data = value; }
        internal NohLista<T> Next { get => next; set => next = value; }
        internal NohLista<T> Prior { get => prior; set => prior = value; }

        public NohLista<T> getPrior()
        {
            return Prior;
        }

        public void setPrior(NohLista<T> _Prior)
        {
            Prior = _Prior;
        }

        public T getData()
        {
            return data;
        }

        public void setData(T _data)
        {
            data = _data;
        }


        public NohLista<T> getNext()
        {
            return Next;
        }

        public void setNext(NohLista<T> _next)
        {
            Next = _next;
        }
    }
}
