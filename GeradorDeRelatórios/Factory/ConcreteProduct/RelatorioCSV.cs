using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeradorDeRelatórios.Factory.AbstractProduct;

namespace GeradorDeRelatórios.Factory.ConcreteProduct
{
    public class RelatorioCSV : RelatorioProduct
    {
        public RelatorioCSV()
        {
            _Name = "CSV";
            _Description = "Esse relatório poderá ser aberto em uma planilha...";
        }

        public override void GerarRelatorio()
        {
            Console.WriteLine($"Relatório: {_Name}\nDescrição: {_Description}\nSendo gerado em CSV...");
        }
    }
}
