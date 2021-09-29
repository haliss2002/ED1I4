using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Evento
    {
        private int id;
        private string descricao;
        private int qtdeMaxParticipantes;
        private Participante[] participantes;

        public string Descricao { get => descricao; set => descricao = value; }
        public int QtdeMaxParticipantes { get => qtdeMaxParticipantes; set => qtdeMaxParticipantes = value; }
        public int Id { get => id; set => id = value; }
        internal Participante[] Participantes { get => participantes; set => participantes = value; }

        public Evento(int id, string qtde, int valor)
        {
            this.Id = id;
            this.descricao = qtde;
            this.qtdeMaxParticipantes = valor;
            this.Participantes = new Participante[this.qtdeMaxParticipantes];
            for (int i = 0; i < this.qtdeMaxParticipantes; ++i)
                this.Participantes[i] = new Participante();
        }

        public Evento()
            : this(0, "",0)
        { }     
        
        public int inscreverParticipante(Participante p)
        {
            int conta = qtdeParticipantes();
            if(conta == qtdeMaxParticipantes) 
            {
                return 1;
            }
            else
            {
                this.Participantes[conta] = p;
                return 0;
            }            
        }
        public int qtdeParticipantes()
        {
            int conta = 0;
            foreach (Participante v in this.Participantes)
            {
                if (v.Email != "")
                {
                    conta++;
                }

            }
            return conta;
        }
        public string  listaParticipantes()
        {
            string texto = "";
            foreach (Participante v in this.Participantes)
            {
                if (v.Email != "")
                {
                    texto = texto + v.ToString();
                }
            }
            return texto;
        }


        public override bool Equals(object obj)
        {
            return this.Id.Equals(((Evento)obj).Id);
        }

        public override string ToString()
        {
            string texto = "";
            texto = "\nid:" + Id + "\nDescricao:" + descricao + "\nqtdeMaxParticipantes:" + qtdeMaxParticipantes;
            texto = texto + listaParticipantes();
            return texto;
        }
        
    }
}
