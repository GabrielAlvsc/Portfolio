using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lista1;

namespace Lista1
{
    class Fila<TAD> : Lista<TAD>
    {
        // atributos = INICIO e FIM, obtidos por heranca

        //metodos
        public Fila()
        {
            INICIO = null;
            FIM = null;
        }

        public void insereFila(TAD n)
        {
            insereFim(n);
        }

        public TAD removeFila()
        {   
            if (estaVazia())
            {
                Console.WriteLine("fila está vazia, impossível remover");
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

        public void imprimeFila()
        {
            if (estaVazia())
            {
                Console.Write("Fila ");
                imprimeEsqDireita();
            }
            else
            {
                imprimeEsqDireita();
            }
            
        }
    }


}
