using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Venda
    {
        private int qtde;
        private double valor;

        public Venda() { }

        public Venda(int qtde, double valor)
        {
            this.qtde = qtde;
            this.valor = valor;
        }
        public int Qtde
        {
            get { return qtde; }
            set { qtde = value; }
        }

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public double valorMedio()
        {
            return valor / qtde;
        }
    }
}
