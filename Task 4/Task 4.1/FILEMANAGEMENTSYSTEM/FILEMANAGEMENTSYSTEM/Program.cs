using Serilog;
using System;
using System.IO;

namespace FILEMANAGEMENTSYSTEM
{
    class Program
    {
        static void Main(string[] args)
        {
           UI newUi = new UI();
           newUi.Start();
        }   
    }
}
