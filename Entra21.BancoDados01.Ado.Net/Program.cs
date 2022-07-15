using Entra21.BancoDados01.Ado.Net.Views.TiposPersonagens;

namespace Entra21.BancoDados01.Ado.Net
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
         
            ApplicationConfiguration.Initialize();
            Application.Run(new  TipoPersonagemListagemForm());
        }
    }
}