using Microsoft.VisualBasic.ApplicationServices;
using Projeto.Venda.Lolxss.Controle;
using Projeto.Venda.Lolxss.model;
using Projeto.Venda.Lolxss.repository;
using Projeto.Venda.Lolxss.view;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
namespace Projeto.Venda.Lolxss.controller
{
    internal class Relatorio
    {
       
       

        public Document gerarNota(List<Item> itens)
        {
            DateTime data = DateTime.Now;
            var documento = Document.Create(conteudo => { // criando o documento

                conteudo.Page(pagina => {

                    pagina.Size(PageSizes.A6);
                    pagina.PageColor(QuestPDF.Infrastructure.Color.FromHex("f7f7c7"));
                    pagina.Margin(1, QuestPDF.Infrastructure.Unit.Centimetre);

                    // repete em todas as paginas.
                    pagina.Header().Column(coluna =>
                    {
                        coluna.Item().PaddingBottom(8).AlignCenter().Text("Cupom de Venda").FontSize(19);
                        coluna.Item().AlignLeft().Text("Empresa: ...").FontSize(10);
                        coluna.Item().AlignLeft().Text("CNPJ: ...").FontSize(10);
                        coluna.Item().LineHorizontal(2);
                        coluna.Item().AlignCenter().Text("Hollow Nest").Bold();
                        coluna.Item().AlignCenter().Text("Panteão - 1001 - Sorocaba/SP");

                    });
                    //conteudo principal
                    pagina.Content().Column(coluna =>
                    {
                        //cabeçalho dos itens
                        coluna.Item().Row(linha =>
                        {
                            linha.RelativeItem(1).Text("Item").FontSize(7);
                            linha.RelativeItem(3).Text("Descrição").FontSize(7);
                            linha.RelativeItem().Text("Qtd").FontSize(7);
                            linha.RelativeItem().Text("preço").FontSize(7);
                            linha.RelativeItem().Text("Total").FontSize(7);
                        });
                        //itens da venda
                        coluna.Item().LineHorizontal(0.5f);
                        for(int i = 0; i < itens.Count; i++){

                            coluna.Item().Row(linha =>
                            {
                                Item item = itens[i];
                                linha.RelativeItem(1).Text($"{i+1}").FontSize(7);
                                linha.RelativeItem(3).Text(item.nome_produto).FontSize(7);
                                linha.RelativeItem().Text(item.quantidade).FontSize(7);
                                linha.RelativeItem().Text(item.preco_real).FontSize(7);
                               
                            });

                        }
                        coluna.Item().LineHorizontal(0.5f);
                        coluna.Item().Row(linha =>
                        {
                            decimal total = itens.Sum(item => item.sub_total);
                            linha.RelativeItem().AlignRight().Text($"Total: {total}").FontSize(7);
                            
                        });

                    });

                    // repete em todas as paginas.
                    pagina.Footer().Column(coluna =>
                    {

                        coluna.Item().LineHorizontal(0.5f);
                        coluna.Item().AlignLeft().Text($"Data: {data:dd/MM//yyyy HH:mm:ss}");
                        coluna.Item().AlignLeft().Text("Compre Mais").Italic();
                        coluna.Item().AlignLeft().Text($"Funcionario: ");
                        coluna.Item().AlignLeft().Text("Todos os Produtos são de providência duvidosa").FontSize(0.10f);


                    });
                });
            
            
            
            
            
            });
            
            return documento;
        }



        public void salvarPdf(Document documento)
        {
            //var dialogo = new SaveFileDialog 
            //{ 
            //    Title = "Salvar Documento",
            // FileName = "nota.pdf",
            // Filter =  "PDF|*.pdf",


            //};
            //if (dialogo.ShowDialog() == DialogResult.OK)
            //{


            //}
            string pasta = Path.GetTempPath();
            string nomeArquivo = $"doc_{Guid.NewGuid().ToString()}.pdf";
            string caminho = Path.Combine(pasta, nomeArquivo);

          
            documento.GeneratePdf(caminho);

            //abre o documento
            Process.Start(new ProcessStartInfo
            {
                FileName = caminho,
                UseShellExecute = true
            });
        }

        private void resumo(IContainer conteudo, List<Vendas> listadevendas)
        {
            int quantidadeDevendas = listadevendas.Count();
            Vendas? maiorVenda = listadevendas.OrderByDescending(venda=>venda).FirstOrDefault();
            Vendas? menorVenda = listadevendas.OrderBy(venda=>venda.total).FirstOrDefault();
            conteudo.Column(coluna =>
            {
                coluna.Item().Background(Colors.LightBlue.Darken2)
                .Padding(8)
                .Border(Colors.LightGreen.Darken2)
                .DefaultTextStyle(e => e.FontColor(Colors.White))
                .Text("Resumo Geral");

                coluna.Item().Row(linha =>
                {
                    linha.RelativeItem().Text($"Maior Venda : {maiorVenda.total:c2}");
                    linha.RelativeItem().Text($"Menor Venda : {menorVenda.total:c2}");
                });
            });
        }

        public Document gerarRelatorioMensal(List<Item> listadevendas)
        {
            DateTime data = DateTime.Now;

            DateTime dataInicial = listadevendas.Min(vendas => vendas.data);
            DateTime dataFinal = listadevendas.Max(vendas => vendas.data);

            var documento = Document.Create(conteudo => 
            {
                conteudo.Page(pagina => {
                    pagina.Size(PageSizes.A4);
                    pagina.Margin(10);
                    pagina.DefaultTextStyle(estilo => estilo.FontSize(12));

                    //cabeçalho
                    pagina.Header().Column(coluna =>
                    {
                        
                        coluna.Item().Text("Relatório Mensal").AlignCenter().FontSize(18); 
                        coluna.Item().Text("Panteão store"); 
                        coluna.Item().Text($"Periodo: {dataInicial:dd/MM/yyyy} a {dataFinal:dd//MM/yyyy}"); 
                        coluna.Item().LineHorizontal(1f); ;
                    });

                    //conteudo principal
                    pagina.Content().Column(coluna =>
                    {
                        coluna.Item().Element(conteudo => resumo() (conteudo, listadevendas));
                        coluna.Item().Element(conteudo => RankFuncionario() (conteudo, listadevendas));
                        coluna.Item().Element(conteudo => demonstrativo()(conteudo, listadevendas));
                    });

                    //header
                    pagina.Footer().Column(coluna =>
                    {

                        coluna.Item().LineHorizontal(1f); coluna.Item().Row(linha =>
                        {
                            linha.RelativeItem().Text($"{data:dd:MM:yyyy HH:mm:ss}");

                            linha.RelativeItem().Text(texto =>
                            {
                                texto.Span("Pagina ");

                                texto.CurrentPageNumber();

                                texto.Span(" de ");

                                texto.TotalPages();

                            });
                        });

                    });

                });

            });
            return documento;
        }


        private void RankFuncionario(IContainer conteudo, List<Vendas> listadevendas)
        {
          
            conteudo.Column(coluna =>
            {
                var funcionario = listadevendas.GroupBy(venda => new
                {
                    venda.id_funcionario,
                    venda.nomefuncionario
                }).Select(grupo => new
                {
                    id_funcionario = grupo.Key.id_funcionario,
                    nome = grupo.Key.nomefuncionario,
                    quantidadevendas = grupo.Count(),
                    total = grupo.Sum(venda => venda.total)
                }).OrderByDescending(funcionario=>funcionario.total).ToList();

                coluna.Item().Background(Colors.LightBlue.Darken2)
                .Padding(8)
                .Border(Colors.LightGreen.Darken2)
                .DefaultTextStyle(e => e.FontColor(Colors.White))
                .Text("Funcionario Do Mes");
                coluna.Item().Spacing(10);
                coluna.Item().Table(tabela =>
                {
                    tabela.ColumnsDefinition(tabela =>
                    {
                        coluna.RelativeColumn(30);
                        coluna.RelativeColumn(40);
                        coluna.RelativeColumn(2);
                        coluna.RelativeColumn(40);
                        coluna.RelativeColumn();
                    });
                    tabela.Header(cabecalho =>
                    {
                        cabecalho.Cell().Text($"#");
                        cabecalho.Cell().Text($"cod");
                        cabecalho.Cell().Text($"nome");
                        cabecalho.Cell().Text($"QTD");
                        cabecalho.Cell().Text($"Total");
                       
                    });
                    int pos = 1;
                    foreach(var funcionario in funcionario)
                    {
                        tabela.Cell().Text($"{pos}**");
                        tabela.Cell().Text($"{funcionario.id_funcionario}");
                        tabela.Cell().Text($"{funcionario.nome}");
                        tabela.Cell().Text($"{funcionario.quantidadedevendas}");
                        tabela.Cell().Text($"{funcionario.total:C2}");
                    }
                });

                
            });
     
        }


        private void demonstrativo(IContainer conteudo, List<Vendas> listadevendas)
        {
            decimal totalvendido = listadevendas.Sum(venda => venda.total);

            conteudo.Column(coluna =>
            {
                coluna.Item().Background(Colors.LightBlue.Darken2)
                .Padding(8)
                .Border(Colors.LightGreen.Darken2)
                .DefaultTextStyle(e => e.FontColor(Colors.White))
                .Text("Demonstrativo De Vendas");

                coluna.Item().Row(linha =>
                {
                    linha.RelativeItem().Text($"faturamento");
                    linha.RelativeItem().Text($"{totalvendido}:c2").AlignRight().FontSize();
                });
            });
        }
    }

}
