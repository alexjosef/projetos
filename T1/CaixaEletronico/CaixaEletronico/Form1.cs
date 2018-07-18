﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        Conta conta;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.conta = new ContaPoupanca();
            // this.conta = new ContaPoupanca(); TESTE PARA CONTA POUPANÇA
            this.conta.Titular = new Cliente();

            this.conta.Titular.Nome = "Victor";
            this.conta.Numero = 1;
            this.conta.Deposita(200.0);
            this.conta.Titular.idade = 17;
            

            this.MostraConta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoDoValorDoDeposito = textoValor.Text;
            double valorDeposito = Convert.ToDouble(textoDoValorDoDeposito);
            this.conta.Deposita(valorDeposito);

            this.MostraConta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textoDoValorDoSaque = textoValor.Text;
            double valorSaque = Convert.ToDouble(textoDoValorDoSaque);
            this.conta.Saca(valorSaque);

            this.MostraConta();
        }

        private void MostraConta()
        {
            textoTitular.Text = conta.Titular.Nome;
            textoSaldo.Text = Convert.ToString(conta.Saldo);
            textoNumero.Text = Convert.ToString(conta.Numero);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conta c1 = new Conta();
            c1.Deposita(10);
            ContaCorrente c2 = new ContaCorrente();
            c2.Deposita(100);

            TotalizadorDeContas t = new TotalizadorDeContas();
            t.Adiciona(c1);
            t.Adiciona(c2);

            MessageBox.Show("O Total é: " + t.saldoTotal);

        }
    }
}