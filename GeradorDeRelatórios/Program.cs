using GeradorDeRelatórios;
using GeradorDeRelatórios.Factory.AbstractFactory;
using GeradorDeRelatórios.Factory.ConcreteFactory;

Console.WriteLine("Como deseja gerar o arquivo?\n1. HTML\n2. PDF\n3. CSV");
var opcao = Console.ReadLine();

switch (opcao)
{
	case "1":
        GeradorFactory geradorFactoryHTML = new GeradorDeArquivosHTML();
        var relatorioHTML = geradorFactoryHTML.GerarArquivo();
        relatorioHTML.GerarRelatorio();
        break;
	case "2":
        GeradorFactory geradorFactoryPDF = new GeradorDeArquivosPDF();
        var relatorioPDF = geradorFactoryPDF.GerarArquivo();
        relatorioPDF.GerarRelatorio();
        break;
	case "3":
        GeradorFactory geradorFactoryCSV = new GeradorDeArquivosCSV();
        var relatorioCSV = geradorFactoryCSV.GerarArquivo();
        relatorioCSV.GerarRelatorio();
        break;
}