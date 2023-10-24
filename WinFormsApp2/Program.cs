using LibraryForApliedMathService;
namespace WinFormsApp2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int a = 5;
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            
        }
    }
}