using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaIdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idadeLucas = 20;
            int idadeBryan = 21;
            int idadeFelipe = 17;

            double mediaidade = (idadeBryan + idadeFelipe + idadeLucas) / 3;
            MessageBox.Show("A média das idades entre eles é:" + mediaidade);
        }
    }
}
