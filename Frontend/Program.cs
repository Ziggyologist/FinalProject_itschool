
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
            Helper.AddNewActivity("Water the plants", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nulla consectetur, tellus vitae convallis eleifend, orci risus iaculis magna, sed elementum orci ipsum sed odio. Nulla in eros turpis. Aliquam felis massa, luctus at imperdiet sed, fermentum condimentum enim.", 3);
        }
    }
}