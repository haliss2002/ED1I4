using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Medicamento
{
    class Medicamentos
    {
        public Queue<Medicamento> listaMedicamentos;

        public Medicamentos()
        {
            listaMedicamentos = new Queue<Medicamento>();
        }

        public void adicionar(Medicamento medicamento)
        {
            this.listaMedicamentos.Enqueue(medicamento);
        }
        public bool deletar(Medicamento medicamento)
        {
            Medicamento b = new Medicamento();
            foreach (Medicamento a in listaMedicamentos)
            {
                if (a.Equals(medicamento))
                {
                    b = a;
                }
            }
            if (b.qtdeDisponivel() != 0)
            {
                this.listaMedicamentos = new Queue<Medicamento>(listaMedicamentos.Where(x => x != b));
                return true;
            }
            else
            {
                return false;
            }
        }

        public Medicamento pesquisar(Medicamento medicamento)
        {
            Medicamento b = new Medicamento();
            foreach (Medicamento a in listaMedicamentos)
            {
                if (a.Equals(medicamento))
                {
                    b = a;
                }
            }
            return b;
        } 
    }
}
