using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    class Senha
    {
        private int id;
        private DateTime dataGerac;
        private DateTime horaGerac;
        private DateTime dataAtend;
        private DateTime horaAtend;

        public int Id { get => id; set => id = value; }
        public DateTime DataGerac { get => dataGerac; set => dataGerac = value; }
        public DateTime HoraGerac { get => horaGerac; set => horaGerac = value; }
        public DateTime DataAtend { get => dataAtend; set => dataAtend = value; }
        public DateTime HoraAtend { get => horaAtend; set => horaAtend = value; }

        public Senha(int id)
        {
            this.id = id;
            this.dataGerac = DateTime.Now.Date;
            this.horaGerac = DateTime.Now;            
        }

        public string dadosParciais()
        {
            return this.id + "-" + this.dataGerac.Date + "-" + this.horaGerac.Hour;
        }

        public string dadosCompletos()
        {
            return this.id + "-" + this.dataGerac.Date + "-" + this.horaGerac.Hour + "-" + this.DataAtend.Date + "-" + this.HoraAtend.Hour;
        }
    }
}
