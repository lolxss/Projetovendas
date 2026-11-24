using Projeto.Venda.Lolxss.controller;
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