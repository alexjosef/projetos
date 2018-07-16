using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaoNaMassaOO
{
    class Conta
    {
        public int numero;
        public double saldo;
        public Cliente titular;


        public bool Saca(double ValorASacar)
        {

            if (ValorASacar < 0 && ValorASacar > this.saldo)
            {
                return false;
            }
            else
            {
                if (this.titular.EhMaiorDeIdade())
                {
                    this.saldo -= ValorASacar;
                    return true;
                }
                else
                {
                    if (ValorASacar <= 200)
                    {
                        this.saldo -= ValorASacar;
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                }

            }  
            
        }
       
    }
}
