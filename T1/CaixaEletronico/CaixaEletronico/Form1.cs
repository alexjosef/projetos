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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();

            conta.Depositar(1000);

            conta.Sacar(100);
            conta.Sacar(200);
            Cliente alex = new Cliente("Alex José");
            MessageBox.Show("O saldo atual é: " + alex.Nome);


        }
    }
}
