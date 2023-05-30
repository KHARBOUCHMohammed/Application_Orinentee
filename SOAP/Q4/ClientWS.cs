using System;
using static SalutService;
using System.Web.Services.Protocols;

namespace Question4
{
    class ClientWS
    {
        [STAThread]

        static void Main(string[] args)
        {
           
            SalutService es = new SalutService();
            try
            {
                string text = es.salut("Mohammed");
                Console.WriteLine("message reçu : {0}", text);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Message: {0}", e.Message);
            }
            Console.ReadLine();
        }
    }
}