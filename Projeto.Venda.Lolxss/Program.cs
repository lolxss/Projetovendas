using Projeto.Venda.Lolxss.view;

namespace Projeto.Venda.Lolxss
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new frmLogin());


            while (true) 
            { 
            
             using (frmLogin login = new frmLogin())
             {
                if (login.ShowDialog() != DialogResult.OK)
                {
                        break;
                    //Application.Run(new frmsistemaprincipal());


                }
             }
                using (frmsistemaprincipal principal = new frmsistemaprincipal())
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