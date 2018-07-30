using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForsEncadeados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensagem = " ";
            int linhas = 5;
            for (int linha = 1; linha <= linhas; linha++)
            {
                for (int coluna = 1; coluna <= linha; coluna++)
                {
                    mensagem += (linha * coluna) + " ";
                }
                mensagem += "\n";
            }
            
            MessageBox.Show(mensagem);
        }
    }
}
