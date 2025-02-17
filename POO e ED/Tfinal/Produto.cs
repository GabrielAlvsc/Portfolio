using System;
using System.Collections.Generic;
using System.Text;

namespace Tfinal
{
    class Produto
    {
        private int id;
        private string name;
        private double price;
        private string description; ///

        public Produto()
        {
            id  =  0;
            name = description= "";
            price = 0.0;
            
        }

        public Produto(int _id, string _name, double _price, string _description)
        {
            id = _id;
            name = _name;
            price = _price;
            description = _description;
        }

        public void setId(int _id)
        {
            id = _id;
        }
        public void setN(string _n)
        {
            name = _n;
        }
        public void setP(double _p)
        {
            price = _p;
        }
        public void setD(string _d)
        {
            description = _d;
        }///

        public int getId()
        {
            return id;
        }
        public string getN()
        {
            return name;
        }
        public double getP()
        {
            return price;
        }
        public string getD()
        {
            return description;
        }///

    }

}
