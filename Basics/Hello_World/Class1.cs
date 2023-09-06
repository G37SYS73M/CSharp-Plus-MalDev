using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    public class Class1
    {
        public static void Main(string[] args)
        {

            //window Title 
            Console.Title = "This my First Progarm!!!!";

            //Adding Colors
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            //Printing in the console
            Console.Write("Hello World");


          


            for (int i = 0; i < 10; i++) {
                Console.WriteLine(i);
            }



            //To make the console hold..
            Console.ReadLine();
        }
    }
}
