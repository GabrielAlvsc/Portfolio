using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoGabrielAlvesFinal
{
    public partial class Form1 : Form
    {
        Grafo mapa = new Grafo();

        public void inicializa()
        {
            Noh a = mapa.addNoh("Itumbiara");
            Noh b = mapa.addNoh("Centralina");
            Noh c = mapa.addNoh("Campinopolis");
            Noh d = mapa.addNoh("Ituiutaba");
            Noh e = mapa.addNoh("Douradinhos");
            Noh f = mapa.addNoh("Monte Alegre");
            Noh g = mapa.addNoh("Tupaciguara");
            Noh h = mapa.addNoh("Araguari");
            Noh i = mapa.addNoh("Uberlandia");
            Noh j = mapa.addNoh("Cascalho Rico");
            Noh k = mapa.addNoh("Grupiara");
            Noh l = mapa.addNoh("Estrela do Sul");
            Noh m = mapa.addNoh("Romaria");
            Noh n = mapa.addNoh("Indianapolis");
            Noh o = mapa.addNoh("Sao Juliana");

            mapa.addEdge(a, b, 20);
            mapa.addEdge(a, g, 55);
            mapa.addEdge(b, f, 75);
            mapa.addEdge(b, c, 40);
            mapa.addEdge(c, d, 30);
            mapa.addEdge(d, f, 85);
            mapa.addEdge(d, e, 90);
            mapa.addEdge(e, f, 28);
            mapa.addEdge(e, i, 63);
            mapa.addEdge(f, g, 44);
            mapa.addEdge(f, i, 60);
            mapa.addEdge(g, i, 60);
            mapa.addEdge(h, j, 28);
            mapa.addEdge(h, l, 34);
            mapa.addEdge(i, h, 30);
            mapa.addEdge(i, m, 78);
            mapa.addEdge(i, n, 45);
            mapa.addEdge(j, k, 32);
            mapa.addEdge(k, l, 38);
            mapa.addEdge(l, m, 27);
            mapa.addEdge(m, o, 28);
            mapa.addEdge(n, o, 40);

        }
        
        public Form1()
        {


            inicializa();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        

        public void button3_Click(object sender, EventArgs ev)
        {
            Grafo mapa = new Grafo();
            Noh a = mapa.addNoh("Itumbiara");
            Noh b = mapa.addNoh("Centralina");
            Noh c = mapa.addNoh("Campinopolis");
            Noh d = mapa.addNoh("Ituiutaba");
            Noh e = mapa.addNoh("Douradinhos");
            Noh f = mapa.addNoh("Monte Alegre");
            Noh g = mapa.addNoh("Tupaciguara");
            Noh h = mapa.addNoh("Araguari");
            Noh i = mapa.addNoh("Uberlandia");
            Noh j = mapa.addNoh("Cascalho Rico");
            Noh k = mapa.addNoh("Grupiara");
            Noh l = mapa.addNoh("Estrela do Sul");
            Noh m = mapa.addNoh("Romaria");
            Noh n = mapa.addNoh("Indianapolis");
            Noh o = mapa.addNoh("Sao Juliana");

            mapa.addEdge(a, b, 20);
            mapa.addEdge(a, g, 55);
            mapa.addEdge(b, f, 75);
            mapa.addEdge(b, c, 40);
            mapa.addEdge(c, d, 30);
            mapa.addEdge(d, f, 85);
            mapa.addEdge(d, e, 90);
            mapa.addEdge(e, f, 28);
            mapa.addEdge(e, i, 63);
            mapa.addEdge(f, g, 44);
            mapa.addEdge(f, i, 60);
            mapa.addEdge(g, i, 60);
            mapa.addEdge(h, j, 28);
            mapa.addEdge(h, l, 34);
            mapa.addEdge(i, h, 30);
            mapa.addEdge(i, m, 78);
            mapa.addEdge(i, n, 45);
            mapa.addEdge(j, k, 32);
            mapa.addEdge(k, l, 38);
            mapa.addEdge(l, m, 27);
            mapa.addEdge(m, o, 28);
            mapa.addEdge(n, o, 40);
            

            textBox1.Text = "";
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            button1.Enabled = true;
            button3.Enabled = false;
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button1.Enabled = false;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string a = comboBox1.Text;
            string b = comboBox2.Text;
            textBox1.Enabled = true;

            textBox1.Text = "Origem: " + a + "   " + " Destino: " + b + "  " + mapa.achaCaminho(a, b) ;

            button3.Enabled = true;
            button2.Enabled = false;
            textBox1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
