using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    class Guiche
    {
        private int id;
        private Queue<Senha> atendimentos;

        public Guiche()
        {
            this.id = 0;
            this.atendimentos = new Queue<Senha>();
        }
        public Guiche( int id)
        {
            this.id = id;
            this.atendimentos = new Queue<Senha>();
        }

        public int Id { get => id; set => id = value; }
        internal Queue<Senha> Atendimentos { get => atendimentos; set => atendimentos = value; }

        public bool chamar(Queue<Senha> filaSenhas)
        {
            if (filaSenhas.Count != 0)
            {
                filaSenhas.Peek().DataAtend = DateTime.Now.Date;
                filaSenhas.Peek().HoraAtend = DateTime.Now;
                this.atendimentos.Enqueue(filaSenhas.Peek());
                filaSenhas.Dequeue();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
