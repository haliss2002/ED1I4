using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Medicamento
{
    class Medicamento
    {
        private int id;
        private string nome;
        private string laboratorio;
        public Queue<Lote> lotes;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Laboratorio { get => laboratorio; set => laboratorio = value; }

        public Medicamento()
        {
            this.id = 0;
            this.nome = "";
            this.laboratorio = "";
            this.lotes = new Queue<Lote>(); 
        }
        public Medicamento(int id, string nome, string laboratorio)
        {
            this.Id = id;
            this.Nome = nome;
            this.Laboratorio = laboratorio;
            this.lotes = new Queue<Lote>();
        }
        public int qtdeDisponivel()
        {
            int conta=0;
            foreach (Lote a in this.lotes)
            {
                conta = conta + a.Qtde;
            }
            return conta;
        }
        
        public void comprar(Lote lote)
        {
            this.lotes.Enqueue(lote);
        }

        public bool vender(int qtde)
        {

            if (qtde > qtdeDisponivel())
            {
                return false;
            }
            else
            {
                do
                {
                    int qtdet = 0;
                    int indice = 0;
                    int indicevenc = 0;
                    Lote b = new Lote();
                    foreach (Lote a in this.lotes)
                    {
                        if (b.Id == 0)
                        {
                            b = a;
                            indicevenc = indice;
                        }
                        else
                        {
                            if (a.Venc < b.Venc)
                            {
                                b = a;
                                indicevenc = indice;
                            }
                        }
                        indice++;
                    }
                    qtdet = qtde;
                    qtde = qtde - this.lotes.ElementAt(indicevenc).Qtde;
                    if (this.lotes.ElementAt(indicevenc).Qtde <= qtdet)
                    {
                        this.lotes.ElementAt(indicevenc).Qtde = 0;
                        this.lotes = new Queue<Lote>(this.lotes.Where(x => x!= this.lotes.ElementAt(indicevenc)));
                    }
                    else
                    {
                        this.lotes.ElementAt(indicevenc).Qtde = this.lotes.ElementAt(indicevenc).Qtde - qtdet;
                    }
                    return true;
                } while (qtde != 0);

            }
        }
        public override string ToString()
        {
            return this.id + "-" + this.nome + "-" + this.laboratorio + "-" + qtdeDisponivel();
        }
        public override bool Equals(object obj)
        {
            return this.Equals(((Medicamento)obj).id);
        }
    }
}
