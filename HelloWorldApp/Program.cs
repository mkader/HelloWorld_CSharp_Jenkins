using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write(Program.DisplayMessage());
        }

        public static string DisplayMessage()
        {
            return "Hello World";
        }
    }
}
