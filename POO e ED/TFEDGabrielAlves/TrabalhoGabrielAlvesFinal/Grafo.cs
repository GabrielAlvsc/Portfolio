using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGabrielAlvesFinal
{
    public class Grafo
    {
        private Lista<Noh> nos = new Lista<Noh>();
        private Lista<Aresta> arestas = new Lista<Aresta>();
        int alt;

        public Grafo()
        {
        }

        public Noh addNoh(string nome)
        {
            Noh novo = new Noh(nome);
            nos.insereFim(novo);
            return novo;
        }

        public void imprime()
        {
            nos.imprime();
            arestas.imprime();
        }

        public void addEdge(Noh no1, Noh no2, int peso)
        {
            Aresta nova = new Aresta(no1, no2, peso);
            arestas.insereFim(nova);
        }

        public string print()
        {
            string retorno = "";
            for (int i = 0; i < nos.Count; i++)
            {
                retorno += (nos.get(i).Nome + "  ");
            }
            retorno += "\n";
            for (int i = 0; i < arestas.Count; i++)
            {
                retorno += (arestas.get(i).Peso + "  ");
            }
            return retorno;
        }

        public Lista<Noh> getVizinhos(Noh n)
        {
            Lista<Noh> v = new Lista<Noh>();
            for (int i = 0; i < arestas.Count; i++)
            {
                if (arestas.get(i).No1 == n)
                {
                    v.insereFim(arestas.get(i).No2);
                }
                if (arestas.get(i).No2 == n)
                {
                    v.insereFim(arestas.get(i).No1);
                }
            }
            return v;
        }

        public int getPeso(Noh n1, Noh n2)
        {
            int r = 10000;
            for (int i = 0; i < arestas.Count; i++)
            {
                if (arestas.get(i).No1 == n1 && arestas.get(i).No2 == n2 ||
                    arestas.get(i).No1 == n2 && arestas.get(i).No2 == n1)
                {
                    r = arestas.get(i).Peso;
                }
            }
            return r;
        }

        public string achaCaminho(string n1, string n2)
        {
            
            Lista<Noh> Q = new Lista<Noh>();
            Noh destino = null, origem = null;


            for (int i = 0; i < nos.Count; i++)
            {
                Noh v = nos.get(i);
                if (v.Nome == n1)
                {
                    origem = v;
                    v.Dist = 0;
                }
                else v.Dist = 10000;
                Q.insereFim(v);
            }

            while (Q.Count > 0)
            {
                Noh u = null;
                int d = 10000;

                for (int i = 0; i < Q.Count; i++)
                {
                    Noh v = Q.get(i);
                    if (v.Dist < d)
                    {
                        d = v.Dist;                      
                        u = v;
                    }
                }


                if (u.Nome == n2)
                {
                    destino = u;
                    break;
                }
                Q.Remove(u);



                Lista<Noh> vizinhos = getVizinhos(u);
                for (int j = 0; j < vizinhos.Count; j++)
                {
                    Noh v = vizinhos.get(j);


                    if (Q.encontraNoh(v) != null)
                    {
                        alt = u.Dist + getPeso(u, v);
                        if (alt < v.Dist)
                        {
                            v.Dist = alt;
                            v.Prev = u;
                        }
                    }
                }

               


            }
            
            // lista_nos.imprime();
            
            string rota = "";
            Noh c = destino;
            while (c != origem)
            {
                if (c == destino){rota = c.Nome + rota;}
                else{rota = c.Nome + " >>>>> " + rota;}
                c = c.Prev;
            }
            rota = c.Nome + " >>>>> " + rota;
            

            return rota;

        }
    }
}
