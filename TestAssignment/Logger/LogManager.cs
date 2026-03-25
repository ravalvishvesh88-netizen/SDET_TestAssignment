using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignment.Logs
{
    public static class LogManager
    {
        public static void Info(string message)
        {
            Console.WriteLine($"[Info] {DateTime.Now} : {message}");
        }

    }
}
