using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeradorDeRelatórios.Factory.AbstractFactory;
using GeradorDeRelatórios.Factory.AbstractProduct;
using GeradorDeRelatórios.Factory.ConcreteProduct;

namespace GeradorDeRelatórios.Factory.ConcreteFactory
{
    public class GeradorDeArquivosHTML : GeradorFactory
    {
        public override RelatorioProduct GerarArquivo()
        {
            return new RelatorioHTML();
        }
    }
}
