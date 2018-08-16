﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaoNaMassaSRP
{
    public abstract class Cargo
    {
        public IRegraDeCalculo Regra { get; private set; }
        
        public Cargo(IRegraDeCalculo regra)
        {
            this.Regra = regra;
        }
    }
}
