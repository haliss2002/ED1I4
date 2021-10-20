using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLista1
{
    class Contatos
    {
        public List<Contato> agenda { get; }

        public Contatos()
        {
            this.agenda = new List<Contato>();
        }
        public bool adicionar(Contato c)
        {
            if (Equals(c))
            {
                return false;
            }
            agenda.Add(c);
            return true;
        }
        public Contato pesquisar(Contato c)
        {
            foreach (Contato contato in agenda)
            {
                if (c.email == contato.email)
                {
                    return contato;
                }
            }
            return null;
        }

        public bool alterar(Contato c)
        {
            bool podeAlterar = false;
            Console.Write("Digite o email da pessoa a ser alterada: ");
            string resp = Console.ReadLine();
            foreach (Contato ct in agenda)
            {
                if (c.email == resp)
                {
                    Console.Write("Digite o telefone a ser alterado: ");
                    c.telefone = Console.ReadLine();
                    podeAlterar = true;
                }
            }
            return podeAlterar;
        }
        public bool remover(Contato c)
        {
            bool podeRemover = false;
            Console.Write("Digite o email da pessoa a ser removida: ");
            string emailDelete = Console.ReadLine();
            for (int i = 0; i < agenda.Count; ++i)
            {
                if (c.email == emailDelete)
                {
                    agenda.Remove(c);
                    podeRemover = true;
                }
            }
            return podeRemover;
        }
        public override bool Equals(object obj)
        {
            return this.agenda.Equals(((Contato)obj).email);
        }
    }
}
