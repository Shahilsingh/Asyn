using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Age
            
{
    class Program1
    {
        static void Main(string[] args)
        {
            Method();
            Console.WriteLine("Main thread");  
            for(int i=0;i<10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
        public static async void Method()
        {
            await Task.Run(new Action(LongTask));
            Console.WriteLine("New Thread");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

        }
        public static void LongTask()
        {
            Thread.Sleep(2000);
        }
        
    }
}
