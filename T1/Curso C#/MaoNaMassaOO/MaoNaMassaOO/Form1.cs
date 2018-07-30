using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaoNaMassaOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta ContaAlex = new Conta();
            ContaAlex.numero = 1;
            ContaAlex.saldo = 1000.0;

            Cliente ClienteAlex = new Cliente();
            ClienteAlex.nome = "Alex José";
            ClienteAlex.idade = 17;

            ContaAlex.titular = ClienteAlex;

            bool sacou = ContaAlex.Saca(200.0);
            if (sacou)
            {
                MessageBox.Show("Saldo da conta após saque: " + ContaAlex.saldo);
            }
            else
            {
                MessageBox.Show("Não foi possível sacar da conta");
            }

        }
    }
}
