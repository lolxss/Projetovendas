using Projeto.Venda.Lolxss.controller;
using Projeto.Venda.Lolxss.model;
using Projeto.Venda.Lolxss.view;
using QuestPDF.Infrastructure;
namespace Projeto.Venda.Lolxss
{
    internal static class Programa
    {
        [STAThread]
        static void Main()
        {
            QuestPDF.Settings.License = LicenseType.Community;
            ApplicationConfiguration.Initialize();
            //Application.Run(new frmcadastrovenda());
           Relatorio relatorio = new Relatorio();
            //List<Item> itens = new List<Item>();
            //itens.Add(new Item
            //{
            //      nome_produto = "pera",
            //      preco = 350,
            //      quantidade = 4,
            //}
            //);
            //var documento = relatorio.gerarNota(itens);
            //relatorio.salvarPdf(documento);
            while (true) 
            { 
             using (FrmSessão sessão = new FrmSessão())
             {
                if (sessão.ShowDialog() != DialogResult.OK)
                {
                        break;
                    //Application.Run(new FrmSistemaPrincipal());


                }
             }
                using (FrmSistemaPrincipal principal = new FrmSistemaPrincipal())
                {
                    Application.Run(principal);
                    if(principal.DialogResult != DialogResult.Retry)
                    {
                        break;
                    }
                }



            }


        }
    }
}