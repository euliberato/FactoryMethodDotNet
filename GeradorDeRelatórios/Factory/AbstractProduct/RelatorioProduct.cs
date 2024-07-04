using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeRelatórios.Factory.AbstractProduct
{
    public abstract class RelatorioProduct
    {
        protected string _Name { get; set; }

        protected string _Description { get; set; }

        public abstract void GerarRelatorio();
    }
}
