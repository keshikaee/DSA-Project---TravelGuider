using TravelGuiderLibrary;

namespace Traveler_UI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashbord());
        }
    }
 }
