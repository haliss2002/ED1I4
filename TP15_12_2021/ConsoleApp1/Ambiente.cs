using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ambiente
    {
        private int id;
        private string nome;
        public Queue<Log> logs;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public Ambiente(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
            this.logs = new Queue<Log>();
        }
        public void registrarLog(Log log)
        {
            if (this.logs.Count() <100)
            {
                this.logs.Enqueue(log);
            }
        }
    }
}
