using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLista1
{
    class Contato
    {
        public string email { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public Data dtNasc { get; set; }

        public Contato()
        {
            this.email = "";
            this.nome = "";
            this.telefone = "";
            this.dtNasc = new Data();
        }

        public Contato(string email, string nome, string telefone, Data dtNasc)
        {
            this.email = email;
            this.nome = nome;
            this.telefone = telefone;
            this.dtNasc = dtNasc;
        }

        public int getIdade()
        {
            int idadeDia, idadeMes, idadeAno;
            idadeDia = DateTime.Now.Day - this.dtNasc.dia;
            idadeMes = DateTime.Now.Month - this.dtNasc.mes;
            idadeAno = DateTime.Now.Year - this.dtNasc.ano;
            if (idadeDia < 0)
            {
                idadeDia = idadeDia * (-1);
                idadeMes--;
            }
            if (idadeMes < 0)
            {
                idadeMes = idadeMes * (-1);
                idadeAno--;
            }
            return idadeAno;
        }
        public override string ToString()
        {
            return ("[Email=" + this.email + "][Nome=" + this.nome + "][Telefone=" + this.telefone + "][Data de nascimento: " + dtNasc.ToString() + "][Idade=" + this.getIdade() + ']');
        }
    }
}
