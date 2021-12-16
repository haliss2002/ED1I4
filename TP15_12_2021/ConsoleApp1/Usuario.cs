using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Usuario
    {
        private int id;
        private string nome;
        private List<Ambiente> ambientes;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        internal List<Ambiente> Ambientes { get => ambientes; set => ambientes = value; }

        public Usuario(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
            this.Ambientes = new List<Ambiente>();
        }

        public bool concederPermissao(Ambiente ambiente)
        {
            foreach (Ambiente amb in Ambientes)
            {
                if (amb.Id == ambiente.Id)
                {                 
                    return false;
                }
            }
            this.Ambientes.Add(ambiente);
            return true;
        }
        public bool revogarPermissao(Ambiente ambiente)
        {
            foreach (Ambiente amb in Ambientes)
            {
                if (amb.Id == ambiente.Id)
                {
                    Ambientes.Remove(amb);
                    return true;
                }
            }
            return false;
        }
    }
}
