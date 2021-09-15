using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        private int id;
        private string descricao;

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        
        public Class1(int id, string descricao)
        {
            this.id = id;
            this.descricao = descricao;
        }
        public Class1()
            : this(0, "")
        { }

        public string dados()
        {
            return this.id.ToString() + " - " + this.descricao + '\n';
        }

    }
}
