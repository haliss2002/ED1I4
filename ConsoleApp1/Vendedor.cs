using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vendedor
    {
        private int id;
        private string nome;
        private double percComissao;
        private Venda[] asVendas;

        public Vendedor()
            : this(0, "", 0.0, new Venda[31])
        { }

        public Vendedor(int id, string nome, double percComissao, Venda[] asVendas)
        {
            this.asVendas = new Venda[31];
            for (int i = 0; i < 31; ++i)
            {
                this.asVendas[i] = new Venda(0, 0);
            }
            this.id = id;
            this.nome = nome;
            this.percComissao = percComissao;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double PercComissao
        {
            get { return percComissao; }
            set { percComissao = value; }
        }

        public Venda[] AsVendas
        {
            get { return asVendas; }
            set { asVendas = value; }
        }

        public void registrarVenda(int dia, Venda venda)
        {
            asVendas[id] = venda;
        }

        public double valorVendas()
        {
            double valorVendas = 0;
            foreach (Venda v in asVendas)
            {
                valorVendas += v.Valor;
            }
            return valorVendas;
        }

        public double valorComissao()
        {
            double valorComissao = valorVendas() * percComissao;
            return valorComissao;
        }
    }
}
