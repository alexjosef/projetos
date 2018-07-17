using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaoNaMassaWF
{
    public partial class Form1 : Form
    {
        private Conta conta;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.conta = new Conta();
            this.conta.Titular = new Cliente();

            this.conta.Numero = 1;
            this.conta.Saldo = 250.0;
            this.conta.Titular.Nome = "Victor";

            this.MostraConta();
           
        }

        private void MostraConta()
        {
            TextoTitular.Text = conta.Titular.Nome;
            TextoSaldo.Text = Convert.ToString(conta.Saldo);
            TextoNumero.Text = Convert.ToString(conta.Numero);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Valordepositar = TextoValor.Text;
            double valor = Convert.ToDouble(Valordepositar);
            this.conta.Depositar(valor + this.conta.Saldo);

            this.MostraConta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Valorsacar = TextoValor.Text;
            double valor = Convert.ToDouble(Valorsacar);
            this.conta.Sacar(valor);

            this.MostraConta();
        }
        
    }
}
