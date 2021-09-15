using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class2
    {
    private Class1[] coisas;
        private int max;
        private int qtde;

        public int Max { get => max;}
        public int Qtde { get => qtde;}

        public Class2(int max) 
        {
            this.max = max;
            this.qtde = 0;
            this.coisas = new Class1[this.max];
            for(int i = 0; i < this.max; ++i)
            {
                this.coisas[i] = new Class1(-1, "...");
            }

        }

        public string mostraCoisas()
        {
            string ret = "";
            foreach(Class1 c in this.coisas)
            {
                ret += c.dados();
            }
            return ret;
        }
    }
}
