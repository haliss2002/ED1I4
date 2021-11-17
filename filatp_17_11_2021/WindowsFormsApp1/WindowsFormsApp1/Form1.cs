using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Guiches guiche = new Guiches();
        Senhas senhas = new Senhas();
        private void button1_Click(object sender, EventArgs e)
        {           
                senhas.gerar();                       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Senha a in senhas.FilaSenhas)
                listBox1.Items.Add(a.dadosParciais());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            guiche.adicionar(new Guiche());
            label3.Text = Convert.ToString(guiche.listaGuiches.Count());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            guiche.listaGuiches.ElementAt(Convert.ToInt32(textBox1.Text)-1).chamar(senhas.FilaSenhas);
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (Senha a in guiche.listaGuiches.ElementAt(Convert.ToInt32(textBox1.Text)-1).Atendimentos)
                listBox2.Items.Add(a.dadosCompletos());
        }
    }
}
