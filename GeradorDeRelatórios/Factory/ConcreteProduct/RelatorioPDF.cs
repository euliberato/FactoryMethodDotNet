using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeradorDeRelatórios.Factory.AbstractProduct;

namespace GeradorDeRelatórios.Factory.ConcreteProduct
{
    public class RelatorioPDF : RelatorioProduct
    {
        public RelatorioPDF()
        {
            _Name = "PDF";
            _Description = "PDF é um arquivo estático...";
        }

        public override void GerarRelatorio()
        {
            Console.WriteLine($"Relatório: {_Name}\nDescrição: {_Description}\nSendo gerado em PDF...");
        }
    }
}
