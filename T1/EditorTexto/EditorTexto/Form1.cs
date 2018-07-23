using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("entrada.txt")) //confirmando existência do arquivo.
            {
                Stream entrada = File.Open("entrada.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = leitor.ReadToEnd();

                while (linha != null) // enquanto leitor diferente de nulo.
                {
                    texto.Text += linha;
                    linha = leitor.ReadToEnd();
                }
                leitor.Close();
                entrada.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream saida = File.Open("entrada.txt", FileMode.Create);
            StreamWriter escritor = new StreamWriter(saida);
            escritor.Write(texto.Text);
            escritor.Close();
            saida.Close();
        }
    }
}
