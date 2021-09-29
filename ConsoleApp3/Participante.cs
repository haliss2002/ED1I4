using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Participante
    {
        private string email;
        private string nome;

        public string Email { get => email; }
        public string Nome { get => nome; set => nome = value; }

        public Participante(string qtde, string valor)
        {
            this.email = qtde;
            this.nome = valor;
        }

        public Participante()
            : this("", "")
        { }

        public override string ToString()
        {
            return "\nEmail:"+email+"\nNome:"+nome;
        }

        public override bool Equals(object obj)
        {
            return this.email.Equals(((Participante)obj).email);
        }

        public bool podeInscrever( Eventos e)
        {
            int conta = 0;
            foreach (Evento a in e.OsEventos)
            {
                foreach (Participante c in a.Participantes)
                {
                    if (c.Email == this.email)
                    {
                        conta++;
                    }
                }
            }
            if(conta==2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
