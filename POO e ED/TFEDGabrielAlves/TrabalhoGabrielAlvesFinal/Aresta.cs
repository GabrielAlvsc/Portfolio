using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGabrielAlvesFinal
{
    public class Aresta
    {
        private Noh no1;
        private Noh no2;
        private int peso;

        public Aresta(Noh no1, Noh no2, int peso)
        {
            No1 = no1;
            No2 = no2;
            Peso = peso;
        }

        public override string ToString()
        {
            return no1 + "-----" + no2;
        }

        public int Peso { get => peso; set => peso = value; }
        internal Noh No1 { get => no1; set => no1 = value; }
        internal Noh No2 { get => no2; set => no2 = value; }
    }
}
