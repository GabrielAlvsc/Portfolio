using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lista1;

namespace Lista1
{
    class Pilha<TAD>: Lista<TAD>
    {
        public Pilha()
        {
            INICIO = null;
            FIM = null;
        }

        public void inserePilha(TAD n)
        {
            insereInicio(n);
        }

        public TAD removePilha()
        {
            if (estaVazia())
            {
                Console.WriteLine("pilha está vazia, impossível remover");
                return default(TAD);
            }
            else
            {
                TAD n = INICIO.getData();
                INICIO = INICIO.getNext();
                if (INICIO != null) //se não sobrou nenhum objeto na fila
                {
                    INICIO.setPrevio(null);
                }
                else
                {
                    FIM = null;
                }
                return n;
            }
        }

        public void imprimePilha()
        {
            if (estaVazia())
            {
                Console.Write("Pilha ");
                imprimeEsqDireita();
            }
            else
            {
                imprimeEsqDireita();
            }

        }


    }
}
