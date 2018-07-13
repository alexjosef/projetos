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
            c.numero = 1;
            c.titular = "Alex José";
            c.saldo = 500.0;
            c.agencia = 20;
            c.CPF = "074.242.589.40";

            Conta c2 = new Conta();
            c2.numero = 2;
            c2.titular = "Lucas Lopes";
            c2.saldo = 1000.0;
            c2.agencia = 10;
            c2.CPF = "111.444.555.40";

            MessageBox.Show(c.titular + " - " + c.CPF + " - " + c.agencia);
            MessageBox.Show(c2.titular + " - " + c2.CPF + " - " + c2.agencia);
            
        }
    }
}
