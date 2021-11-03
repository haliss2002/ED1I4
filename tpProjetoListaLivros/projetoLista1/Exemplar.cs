using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLista1
{
    class Exemplar
    {
        private int tombo;
        private List<Emprestimo> emprestimos;

        public int Tombo { get => tombo; set => tombo = value; }
        internal List<Emprestimo> Emprestimos { get => emprestimos; set => emprestimos = value; }

        public Exemplar()
        {
            this.Tombo = 0;
            this.Emprestimos = new List<Emprestimo>();
        }
        public Exemplar(int tombo)
        {
            this.Tombo = tombo;
            this.emprestimos = new List<Emprestimo>();
        }

        public bool emprestar(){            
          if (disponivel())
            {
                Emprestimos.Add(new Emprestimo(DateTime.Now));
                return true;
            }
            else
            {
                return false;
            }
                }
        public bool booldevolver() {
            if (!disponivel())
            {
                Emprestimos.Last().DtDevolucao = DateTime.Now;
                return true;
            }
            else
            {
                return false;
            }
        }
    
        public bool disponivel() {
            if (emprestimos.Count != 0)
            {
                DateTime d = new DateTime(0, 0, 0, 0, 0, 0);
                if (Emprestimos.Last().DtDevolucao == d)
                { return false; }
                else { return true; };
            }
            else
            {
                return true;
            }
        }
        public int qtdeEmprestimos() { return Emprestimos.Count; }
    }
}
