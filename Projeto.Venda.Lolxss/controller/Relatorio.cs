using Microsoft.VisualBasic.ApplicationServices;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
namespace Projeto.Venda.Lolxss.controller
{
    internal class Relatorio
    {
        public Document gerarNota()
        {
            var documento = Document.Create(conteudo => { // criando o documento

                conteudo.Page(pagina => {

                    pagina.Size(PageSizes.A6);
                    pagina.PageColor(QuestPDF.Infrastructure.Color.FromHex("f7f7c7"));
                    pagina.Margin(1, QuestPDF.Infrastructure.Unit.Centimetre);

                    // repete em todas as paginas.
                    pagina.Header().Column(coluna =>
                    {
                        coluna.Item().AlignCenter().Text("Cupom de Venda").FontSize(19);
                        coluna.Item().LineHorizontal(2);
                        coluna.Item().AlignCenter().Text("Hollow Nest").Bold();
                        coluna.Item().AlignCenter().Text("Panteão - 1001 - Sorocaba/SP");

                    });

                    pagina.Content();

                    // repete em todas as paginas.
                    pagina.Footer().Column(coluna =>
                    {

                        coluna.Item().LineHorizontal(0.5f);
                        coluna.Item().AlignCenter().Text($"Data 23/11/2026");
                        coluna.Item().AlignCenter().Text("Compre Mais").Italic();
                        coluna.Item().AlignCenter().Text("Todos os Produtos são de providência duvidosa").FontSize(0.10f);


                    });
                });
            
            
            
            
            
            });
            
            return documento;
        }



        public void salvarPdf()
        {
            var dialogo = new SaveFileDialog 
            { 
                Title = "Salvar Documento",
             FileName = "nota.pdf",
             Filter =  "PDF|*.pdf",
            
            
            };
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                var documento = gerarNota();
                documento.GeneratePdf(dialogo.FileName);

            }
        }
    }

}
