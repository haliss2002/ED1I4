using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Eventos
    {
        private Evento[] osEventos;        

        public Eventos()
        {
            this.OsEventos = new Evento[6];
            for (int i = 0; i < 6; ++i)
                this.OsEventos[i] = new Evento();
        }

        internal Evento[] OsEventos { get => OsEventos1; set => OsEventos1 = value; }
        internal Evento[] OsEventos1 { get => osEventos; set => osEventos = value; }

        public void adicionarEvento(Evento e)
        {
            int conta = 0;
            foreach (Evento v in this.OsEventos)
            {
                if (v.Id != 0)
                {
                    conta++;
                }

            }

            if (conta != 6)
            {
                this.OsEventos[conta] = e;
            }
        }

        public string pesquisarParticipante(Participante p)
        {
            string texto = "";
            int i,a = 0;
            foreach (Evento e in this.OsEventos)
            {
                foreach(Participante c in e.Participantes)
                {
                    if(c.Email ==p.Email)
                    {
                        texto = texto + "\nNome:" + c.Nome + " Evento:" + e.Descricao;
                    }
                }
            }
            
            return texto;
        }
        public int qtdeParticipantes()
        {
            int conta = 0;
            foreach (Evento e in this.OsEventos)
            {
                foreach (Participante c in e.Participantes)
                {
                    if (c.Email != "")
                    {
                        conta++;
                    }
                }
            }
            return conta;
        }
        public string listaEventos()
        {
            string texto = "";
            foreach (Evento e in this.OsEventos)
            {
                texto = texto + e.ToString();
            }
            return texto;

        }
    }
}
