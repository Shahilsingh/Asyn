using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Age
{
    class Program5
    {

        static void Main(string[] args)
        {
            Method();
            Console.WriteLine("Main thread");
        
            Console.ReadLine();

        }
        public static async void Method()
        {
            await Task.Run(new Action(LongTask));
            Console.WriteLine("New Thread");


        }
        public static void LongTask()
        {
            Thread.Sleep(2000);
        }

    }
}

    
