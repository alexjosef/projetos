using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap9
{
    class EmpresaFacadeSingleton
    {
        private static EmpresaFacade facede = new EmpresaFacade();

        public EmpresaFacade Instancia
        {
            get
            {
                return facede;
            }
        }
    }
}
