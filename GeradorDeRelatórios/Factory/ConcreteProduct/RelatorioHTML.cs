using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeradorDeRelatórios.Factory.AbstractProduct;

namespace GeradorDeRelatórios.Factory.ConcreteProduct
{
    public class RelatorioHTML : RelatorioProduct
    {
        public RelatorioHTML()
        {
            _Name = "HTML";
            _Description = "HTML é uma linguagem de marcação que pode ser lido através do navegador...";
        }


        public override void GerarRelatorio()
        {
            Console.WriteLine($"Relatório: {_Name}\nDescrição: {_Description}\nSendo gerado em HTML...");
        }
    }
}
