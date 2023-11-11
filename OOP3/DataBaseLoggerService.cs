using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public partial class DataBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına loglandı.");
        }
    }
}
