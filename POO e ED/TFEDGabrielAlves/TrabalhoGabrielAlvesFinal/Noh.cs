using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGabrielAlvesFinal
{
  
        public class Noh
        {
            private string nome;
            private int dist;
            private Noh prev;

            public Noh(string _nome)
            {
                Nome = _nome;
            }

            public override string ToString()
            {
                if (prev != null)
                {
                    return Nome + ", distancia: " + dist + "\n anterior: " + prev.Nome + "\n\n";
                }
                else
                {
                    return Nome + ", distancia: " + dist + "\n anterior: null\n\n";
                }

            }

            public string Nome { get => nome; set => nome = value; }
            public int Dist { get => dist; set => dist = value; }
            internal Noh Prev { get => prev; set => prev = value; }
        }
    }

