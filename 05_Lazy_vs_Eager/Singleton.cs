using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Thread_Safety_Singleton
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());
        public static Singleton Instance
        {
            get
            {
                return instance.Value;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value: " + counter.ToString());
        }

        public void PrintDetails(string details)
        {
            Console.WriteLine(details);
        }

        /*
         * why we should use sealed keyword in the singleton class
         * 
         *       public class SingletonDerived : Singleton
         *       {
         *       }
         */
    }
}
