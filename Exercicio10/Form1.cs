using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int MAX = 50;

        class LLS_Pilha
        {
            public int topo = 0;
            public char[] vetor = new char[50];
        }

        bool EstaVazia(LLS_Pilha p)
        {
            if (p.topo == 0)
                return true;
            else
                return false;
        }
        bool EstaCheia(LLS_Pilha p)
        {
            if (p.topo == MAX)
                return true;
            else
                return false;
        }
        void Insere(LLS_Pilha p, char valor)
        {
            p.vetor[p.topo] = valor;
            p.topo = p.topo + 1;
        }

        char Remove(LLS_Pilha p)
        {
            p.topo = p.topo - 1;
            return (p.vetor[p.topo]);
        }

        LLS_Pilha pilha = new LLS_Pilha();

        private void BT_processar_Click(object sender, EventArgs e)
        {
            String textoNormal;
            String textoInverso = "";
            textoNormal = TB_fraseOriginal.Text;
            int contador = 0;
            while(contador < textoNormal.Length)
            {

                Insere(pilha, textoNormal[contador]);
                contador = contador + 1;

            }
            while(EstaVazia(pilha) == false)
            {
                textoInverso += Convert.ToString(Remove(pilha)) ;
                
                

            }
            TB_fraseInvertida.Text = textoInverso;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
