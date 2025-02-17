using System;
using System.Collections.Generic;
using System.Text;

namespace Tfinal
{
    class Cliente
    {
        private int id;
        private string name;
        private string surname;

        public Cliente()
        {
            id = 0;
            name = surname = "";
        }

        public Cliente(int _id, string _name, string _surname)
        {
            id = _id;
            name = _name;
            surname = _surname;
        }

        public void setId(int _id)
        {
            id = _id;
        }
        public void setN(string _n)
        {
            name = _n;
        }
        public void setSN(string _sn)
        {
            surname = _sn;
        }

        public int getId()
        {
            return id;
        }
        public string getN()
        {
            return name;
        }
        public string getSN()
        {
            return surname;
        }
    }
}
