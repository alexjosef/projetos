using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns01
{
    public class Reprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamento reprovado não pode receber desconto.");
        }
        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento reprovado não pode ser aprovado.");
        }
        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento reprovado.");
        }
        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
