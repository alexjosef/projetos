using DesignPatterns2.Cap4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap5
{
    interface IVisitor
    {
        void VisitaSoma(Soma soma);

        void VisitaSubtracao(Subtracao subtracao);

        void VisitaMultiplicacao(Multiplicacao multiplicacao);

        void VisitaDivisao(Divisao divisao);

        void VisitaRaizQuadrada(RaizQuadrada raizQuadrada);

        void VisitaNumero(Numero numero);
    }
}
