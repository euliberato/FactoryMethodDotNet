using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeradorDeRelatórios.Factory.AbstractProduct;

namespace GeradorDeRelatórios.Factory.AbstractFactory
{
    public abstract class GeradorFactory
    {
        public abstract RelatorioProduct GerarArquivo();
    }
}
