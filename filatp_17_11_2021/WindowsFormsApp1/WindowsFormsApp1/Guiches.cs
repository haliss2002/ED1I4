using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    class Guiches
    {
        public Queue<Guiche> listaGuiches;

        public Guiches()
        {
            listaGuiches = new Queue<Guiche>();
        }

        public void adicionar(Guiche guiche)
        {
            listaGuiches.Enqueue(guiche);
        }
    }
}
