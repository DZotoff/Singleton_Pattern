using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace singleton_task
{
    public class Logger
    {
        private static Logger instance = new Logger(); // static instanace which is needed in case if only one instance is created

        private Logger() { } // prevent direct instantiation, can't be initiated from outside
        public static Logger Instance { get { return instance; } } //access to the instance

        public void LogMess(string i) //the methoв to print the message
        {
            Console.WriteLine(i);
        }
      

    }
}
