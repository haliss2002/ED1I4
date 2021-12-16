using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Log
    {
        private DateTime dtAcesso;
        private string usuario;
        private bool tipoAcesso;

        public bool TipoAcesso { get => tipoAcesso; set => tipoAcesso = value; }
        public DateTime DtAcesso { get => dtAcesso; set => dtAcesso = value; }
        public string Usuario { get => usuario; set => usuario = value; }

        public Log(DateTime dtAcesso, string usuario, bool tipoAcesso)
        {
            this.dtAcesso = dtAcesso;
            this.usuario = usuario;
            this.tipoAcesso = tipoAcesso;
        }
    }
}
