using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteConta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            Cliente cliente1 = new Cliente();
            c.titular = cliente1;
            c.titular.nome = "Alex José";
            c.numero = 1;
            c.saldo = 500.0;
            c.agencia = 10;
            cliente1.cpf = "074.242.589.40";
            cliente1.rg = "5861798";

            Conta c2 = new Conta();
            Cliente cliente2 = new Cliente();
            c2.titular = cliente2;
            c2.titular.nome = "Lucas Lopes";
            c2.numero = 2;
            c2.saldo = 1000.0;
            c2.agencia = 20;
            cliente2.cpf = "111.444.555.40";
            cliente2.rg = "1115557";

            c2.Transfere(250, c);

            MessageBox.Show("Conta: " + cliente1.nome + " Saldo: " + c.saldo);
            MessageBox.Show("Conta: " + cliente2.nome + " Saldo: " + c2.saldo);

            Cliente Alex = new Cliente();
            Alex.nome = "Alex Jose";    

            Conta Conta = new Conta();
            Conta.cliente = Alex;
            Alex.rg = "5861798";

            MessageBox.Show(Conta.cliente.nome);
        }
    }
}
