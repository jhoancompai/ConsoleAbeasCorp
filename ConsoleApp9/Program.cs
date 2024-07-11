using System;
using System.Collections.Generic;
using Trabajo_Final___AbeasCorp;

namespace AplicationConsoleAbeasCorp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos a AbeasCorp.\n");
            Console.WriteLine("Para las solicitudes: \nAF514 0 5 10\r\nCO5   3 7 14\r\nAF515 5 9 7\r\nBA01  6 9 8");

            var requests = new List<Request>
            {
               new Request("AF514", 0, 5 , 10),
               new Request("CO5", 3, 7 , 14),
               new Request("AF515", 5, 9 , 7),
               new Request("BA01", 6, 9 , 8)
            };

            var scheduler = new RequestSchedulerTest();

            var MaxGain = scheduler.GetMaxGain(requests);

            Console.WriteLine("\nEl mejor resultado es : " + MaxGain);
        }
    }
}
