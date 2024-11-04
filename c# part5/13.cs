using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__exceptionalhandling
{
    public class Logger
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Logger));

        static Logger()
        {
            XmlConfigurator.Configure();
        }

        public static object XmlConfigurator { get; }

        public static void LogError(string message, Exception ex)
        {
            log.Error(message, ex);
        }
    }
    public class LoggingExample
    {
        public static void Divide(int a, int b)
        {
            try
            {
                int result = a / b;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Logger.LogError("Attempted to divide by zero.", ex);
                Console.WriteLine("DivideByZeroException caught and logged.");
            }
        }
        
    }
}
