using DesignPatterns2.Cap4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap5
{
    class ImpressoraVisitor : IVisitor
    {
        public void VisitaSoma(Soma soma)
        {
            Console.Write("(");
            soma.Esquerda.Aceita(this);
            Console.Write("+");
            soma.Direita.Aceita(this);
            Console.Write(")");
        }
        public void VisitaSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            subtracao.Esquerda.Aceita(this);
            Console.Write("+");
            subtracao.Direita.Aceita(this);
            Console.Write(")");
        }

        public void VisitaDivisao(Divisao divisao)
        {
            Console.Write("(");
            divisao.Esquerda.Aceita(this);
            Console.Write("/");
            divisao.Direita.Aceita(this);
            Console.Write(")");
        }

        public void VisitaMultiplicacao(Multiplicacao multiplicacao)
        {
            Console.Write("(");
            multiplicacao.Esquerda.Aceita(this);
            Console.Write("*");
            multiplicacao.Direita.Aceita(this);
            Console.Write(")");
        }

        public void VisitaRaizQuadrada(RaizQuadrada raizquadrada)
        {
            
        }

        public void VisitaNumero(Numero numero)
        {
            Console.Write(numero.Valor);
        }
    }
}
