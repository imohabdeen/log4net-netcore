using System;

namespace Log4netNetCoreDemo
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager
            .GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        static void Main(string[] args)
        {
            var logRepository = log4net.LogManager.GetRepository(System.Reflection.Assembly.GetEntryAssembly());

            //log4net configuraiton for consoleappendar - no config gile needed
            //log4net.Config.BasicConfigurator.Configure(logRepository);

            //Load configuration from log4net.config file
            log4net.Config.XmlConfigurator.Configure(logRepository,
                                                     new System.IO.FileInfo("log4net.config"));


            Console.WriteLine("Hello World!");

            log.Info("Log4net for .Net Core Hello World");
        }
    }
}
