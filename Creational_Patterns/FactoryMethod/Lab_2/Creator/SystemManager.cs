using FactoryMethod.Lab_2.Concrete;
using FactoryMethod.Lab_2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Lab_2.Creator
{
    class SystemManager
    {
        private ILoggerFactory _loggerFactory;

        public SystemManager(ILoggerFactory loggerFactory) => _loggerFactory = loggerFactory;


        public void Save()
        {
            Console.WriteLine("Saved..!");

            ILogger logger_1 = new SystemLoggerFactory().CreateLogger();
            ILogger logger_2 = new PLSLoggerFactory().CreateLogger();

            logger_1.Log();
            logger_2.Log();
        }
    }
}
