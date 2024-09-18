using LibraryManagementSystemWithAPI.API;
using LibraryManagementSystemWithAPI.UI;

namespace LibraryManagementSystemWithAPI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using HttpClient client = new HttpClient();
            BookOperations bOperations = new BookOperations(client);
            BorrowedBookOperations bbOperations = new BorrowedBookOperations(client);
            CategoryOperations cOperations = new CategoryOperations(client);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Library(bOperations,bbOperations,cOperations));
        }
    }
}