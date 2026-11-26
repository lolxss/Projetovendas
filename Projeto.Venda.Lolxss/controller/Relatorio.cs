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
    }

}
