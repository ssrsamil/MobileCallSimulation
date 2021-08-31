using MobileCallSimulation;
using System;
using System.Threading;

namespace MSISDN
{
    class Program
    {
        static void Main(string[] args)
        {
            // Subscriber A data
            Console.WriteLine("enter MSISDN for subscriber A : ");
            string numberA = Console.ReadLine();

            Console.WriteLine("enter initial balance");
            double balanceA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Please select tariff package");
            Console.WriteLine("         * Enter 1 if you talking a lot ");
            Console.WriteLine("         * Enter 2 if you send sms a lot ");
            Console.WriteLine("         * Enter 3 if you use internet ");
            Console.WriteLine("         * Enter 4 create custom tarif ");
            Console.WriteLine("         * Enter 5 to skip this step ");
            Console.WriteLine("-------------------------------------------------------------");

            int tarifA = Convert.ToInt32(Console.ReadLine());
            Tariff tA;

            if (tarifA == 4)
            {
                Console.WriteLine(" * Enter price for 1 minute talking ");
                double minutePriceA = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" * Enter price for sms ");
                double smsPriceA = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" * Enter price for 1 MB ");
                double megaPriceA = Convert.ToDouble(Console.ReadLine());

                tA = new Tariff("Custom Tarif", minutePriceA, smsPriceA, megaPriceA);
            }
            else if (tarifA == 5)
            {
                tA = new Tariff(null, 0.00, 0.00, 0.00);
            }
            else
            {
                tA = new Tariff(tarifA);
            }

            Subscriber subA = new Subscriber(numberA, balanceA, tA);

            Console.WriteLine();  //          


            //Subscriber B data
            Console.WriteLine("enter MSISDN for subscriber B : ");
            string numberB = Console.ReadLine();

            Console.WriteLine("enter initial balance");
            double balanceB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Please select tariff package");
            Console.WriteLine("         * Enter 1 if you talking a lot ");
            Console.WriteLine("         * Enter 2 if you send sms a lot ");
            Console.WriteLine("         * Enter 3 if you use internet ");
            Console.WriteLine("         * Enter 4 create custom tarif ");
            Console.WriteLine("         * Enter 5 to skip this step ");
            Console.WriteLine("-------------------------------------------------------------");

            int tarifB = Convert.ToInt32(Console.ReadLine());
            Tariff tB;

            if (tarifB == 4)
            {
                Console.WriteLine(" * Enter price for 1 minute talking ");
                double minutePriceB = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" * Enter price for sms ");
                double smsPriceB = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" * Enter price for 1 MB ");
                double megaPriceB = Convert.ToDouble(Console.ReadLine());

                tB = new Tariff("Custom Tarif", minutePriceB, smsPriceB, megaPriceB);
            }
            else if (tarifB == 5)
            {
                tB = new Tariff(null, 0.00, 0.00, 0.00);
            }
            else
            {
                tB = new Tariff(tarifB);
            }

            Subscriber subB = new Subscriber(numberB, balanceB, tB);

            subA.Display();
            subB.Display();

            Operation operation = new Operation();
            operation.StartCall(subB, subA);

            Console.ReadKey();
        }
    }  
    
}
