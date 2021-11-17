using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    class Senhas
    {
        private int proximoAtendimento;
        private Queue<Senha> filaSenhas;

        public int ProximoAtendimento { get => proximoAtendimento; set => proximoAtendimento = value; }
        internal Queue<Senha> FilaSenhas { get => filaSenhas; set => filaSenhas = value; }
        
        public Senhas()
        {
            this.proximoAtendimento = 1;
            this.filaSenhas = new Queue<Senha>();
        }
        public void gerar() 
        {
            filaSenhas.Enqueue(new Senha(this.proximoAtendimento));
            this.proximoAtendimento++;
        }
    }
}
