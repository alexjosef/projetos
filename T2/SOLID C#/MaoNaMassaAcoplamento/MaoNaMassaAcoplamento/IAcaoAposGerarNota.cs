﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaoNaMassaAcoplamento
{
    public interface IAcaoAposGerarNota
    {
        void Executa(NotaFiscal nf);
    }
}
