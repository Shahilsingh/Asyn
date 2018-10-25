using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    public class AshuCustomException : Exception
    {
        public AshuCustomException(string txt) : base(txt)
        {

        }
    }
  
    class Program
    {
        
        static void Main(string[] args)
        {


            getUserAge();


        }
        public static void getUserAge()
        {
            Console.WriteLine("enter a  values");
            int a = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (a < 18 || a > 100)
                {
                    throw new AshuCustomException("enter value should be above 18");
                }
                else
                {
                    
                    Console.WriteLine("valid age");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);



            }
            Console.ReadLine();
        }
    }
    
}