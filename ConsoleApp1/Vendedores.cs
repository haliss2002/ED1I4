using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vendedores
    {
        private Vendedor[] osVendedores;
        private int max = 10;
        private int qtde;

        public Vendedores()
        : this(0, new Vendedor[10])
        { }

        public Vendedores(int qtde, Vendedor[] osVendedores)
        {
            this.qtde = qtde;
            this.osVendedores = new Vendedor[this.max];
            for (int i = 0; i < this.max; ++i)
            {
                this.osVendedores[i] = new Vendedor();
            }
        }

        public Vendedor[] OsVendedores
        {
            get { return osVendedores; }
            set { osVendedores = value; }
        }

        public int Max
        {
            get { return max; }
        }

        public int Qtde
        {
            get { return qtde; }
            set { qtde = value; }
        }

        public bool addVendedor(Vendedor v)
        {
            bool podeAdd = (this.qtde < this.Max);
            if (podeAdd)
            {
                this.osVendedores[qtde] = v;
                this.qtde++;
            }
            return podeAdd;
        }

        public bool delVendedor(Vendedor v)
        {
            bool podeDel = false;
            foreach (Vendedor ve in this.osVendedores)
            {
                if (ve.Equals(v))
                {
                    ve.Id = -1;
                    ve.Nome = "";
                    podeDel = true;
                }
            }
            return podeDel;
        }
        public Vendedor searchVendedor(Vendedor v)
        {
            Vendedor ve = new Vendedor();
            int i = 0;
            while (i < this.Max && this.osVendedores[i].Equals(v))
            {
                i++;
            }
            while (i < this.Max)
                ve = this.osVendedores[i];
            return ve;
        }
        public double valorVendas()
        {
            double valorTotal = 0;
            foreach (Vendedor v in this.osVendedores)
            {
                valorTotal += v.valorVendas();
            }
            return valorTotal;
        }
        public double valorComissao()
        {
            double valorTotal = 0;
            foreach (Vendedor v in this.osVendedores)
            {
                valorTotal += v.valorComissao();
            }
            return valorTotal;
        }
    }
    }
