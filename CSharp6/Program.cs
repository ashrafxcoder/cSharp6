using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using static System.Console;
namespace CSharp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Show();

            ReadKey();
        }


        public static void Show() => Console.WriteLine($"{Assembly.GetExecutingAssembly().FullName}");
 
    }


}
