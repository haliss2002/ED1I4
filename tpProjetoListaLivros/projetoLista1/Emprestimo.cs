using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLista1
{
    class Emprestimo
    {
        private DateTime dtEmprestimo;
        private DateTime dtDevolucao;

        public DateTime DtEmprestimo { get => dtEmprestimo; set => dtEmprestimo = value; }
        public DateTime DtDevolucao { get => dtDevolucao; set => dtDevolucao = value; }

        public Emprestimo()
        {
            this.DtEmprestimo = new DateTime(0, 0, 0, 0, 0, 0); ;
            this.DtDevolucao = new DateTime(0, 0, 0, 0, 0, 0);
        }
        public Emprestimo(DateTime dtEmprestimo)
        {
            this.DtEmprestimo = dtEmprestimo;
        }
    }
}
