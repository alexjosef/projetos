using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns01
{
    public class Finalizado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamento finalizado não pode receber desconto.");
        }
        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento finalizado.");
        }
        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento finalizado.");
        }
        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento finalizado.");
        }
    }
}
