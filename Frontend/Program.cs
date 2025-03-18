
using Backend;

namespace Frontend
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            PopulateMockupData();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }

        private static void PopulateMockupData()
        {
            Helper.AddNewActivity("Wash the floor", "The floor is very dirty, the floor is lava", 6);
            //Helper.AddNewActivity("Activity 2", "Desc2", 10);
        }
    }
}