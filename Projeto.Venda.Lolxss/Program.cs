using Projeto.Venda.Lolxss.view;

namespace Projeto.Venda.Lolxss
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            //Application.Run(new frmfuncionario());

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