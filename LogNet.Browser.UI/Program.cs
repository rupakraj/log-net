using LogNet.Http.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace LogNet.Browser.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            HttpServer httpServer;
            
                httpServer = new LogNetHttpServer(8181);
            
            Thread thread = new Thread(new ThreadStart(httpServer.listen));
            thread.Start();
            Console.WriteLine("Server is listening on: http://localhost:8181");
             
            Application.Run(new LogBrowser());
        }
    }
}
