using LogNet.Http.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LogNet.Http.Server
{
    class Program
    {
        static int Main(string[] args)
        {
            HttpServer httpServer;
            if (args.GetLength(0) > 0)
            {
                httpServer = new LogNetHttpServer(Convert.ToInt32(args[0]));
            }
            else
            {
                //PORT = 8181 if nothing is supplied.
                httpServer = new LogNetHttpServer(8181);
            }
            Thread thread = new Thread(new ThreadStart(httpServer.listen));
            thread.Start();
            Console.WriteLine("Server is listening on: http://localhost:8181");
            return 0;
        }
    }
}
