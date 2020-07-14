using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;
using System.Threading;

namespace cs_example2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClimateMonitor monitor = new ClimateMonitor(new FileLogger("Mylog.txt"));
            //ClimateMonitor monitor = new ClimateMonitor(new ConsoleLogger());
            //monitor.Start();

            AbstractBase obj = new Derived();
            obj.AbstractMethodA();
            obj.PublicMethodA();

        }
    }

    interface ILogger
    {
        void WriteLog(string message);
    }
    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            WriteLine($"{DateTime.Now.ToLocalTime()} {message}");
        }
    }
    class FileLogger : ILogger
    {
        private StreamWriter writer;
        public void WriteLog(string message)
        {
            writer.WriteLine($"{DateTime.Now.ToLocalTime()} {message}");

        }
        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }
    }
    class ClimateMonitor
    {
        private ILogger logger;
        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }
        public void Start()
        {
            while(true)
            {
                Write("온도를 입력하세요 : ");
                string temperature = ReadLine();
                if (temperature == "") break;
                logger.WriteLog("현재 온도 : " + temperature);
            }
        }
    }

    abstract class AbstractBase
    {
        protected void PrivateMethodA()
        {
            WriteLine("AbstractBase.PrivateMethodA()");
        }
        public void PublicMethodA()
        {
            WriteLine("AbstractBase.PublicMethodA()");
        }
        public abstract void AbstractMethodA();
    }

    class Derived : AbstractBase
    {
        public override void AbstractMethodA()
        {
            WriteLine("Derived.AbstractMethodA()");
            PrivateMethodA();
        }
    }


}
