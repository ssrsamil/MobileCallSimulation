using MobileCallSimulation;
using System;
using System.Collections.Generic;
using System.Threading;

namespace MSISDN
{
    class Program
    {
        public static int count;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter MSISDN to create subscriber {0} ", ++count);
            string s = Console.ReadLine();
            Subscriber sub1 = new Subscriber(s);
            sub1.InvokeMenu();

            Console.WriteLine("Enter MSISDN to create subscriber {0} ", ++count);
            string s2 = Console.ReadLine();
            Subscriber sub2 = new Subscriber(s2);            
            sub2.InvokeMenu();

            sub1.Display();
            sub2.Display();
            sub1.AdjustBalance(10);


            Console.WriteLine("for A to B press 1, or press 2 for vice versa ");
            int direction = Convert.ToInt32(Console.ReadLine());
            Operation operation = new Operation();

            if (direction == 1)
            {
                Console.WriteLine("A calling B....");
                operation.StartCall(sub1);
            }
            else
            {
                Console.WriteLine("B calling A....");
                operation.StartCall(sub2);
            }


            Console.ReadKey();
        }
    }      
}
