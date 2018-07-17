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
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            conta.Numero = 1;
            conta.Depositar(250.0);

            conta.Titular = new Cliente();
            conta.Titular.Nome = "Victor";

            TextoTitular.Text = conta.Titular.Nome;
            TextoSaldo.Text = Convert.ToString(conta.Saldo);
            TextoNumero.Text = Convert.ToString(conta.Numero);
        }

    }
}
