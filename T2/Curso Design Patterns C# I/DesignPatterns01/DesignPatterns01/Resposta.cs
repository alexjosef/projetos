﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns01
{
    public interface Resposta
    {
        void Responde(Requisicao req, Conta conta);
    }
}
