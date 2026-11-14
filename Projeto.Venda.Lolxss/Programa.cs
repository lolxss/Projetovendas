using Projeto.Venda.Lolxss.view;

namespace Projeto.Venda.Lolxss
{
    internal static class Programa
    {
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            //Application.Run(new frmcadastrovenda());

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