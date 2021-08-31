using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MobileCallSimulation
{
    class Operation
    {

        static bool checkpoint = false;
        public object TarifPackage { get; private set; }

        public void StartCall(Subscriber A, Subscriber B)
        {

            double pricePerSecond = A.TarifPackage.PriceForTalikngMinute / 60.0;

            if (A.TarifPackage.PackageName == null)
            {
                Console.WriteLine("Caution!");
                Console.WriteLine("You cannot create a call,the tarif plan has to be choosen.");
            }
            else
            {
                double currentBalance = A.Balance;
                double duration = 0.0;
                DateTime fromDate = DateTime.Now;

                Console.CancelKeyPress += Console_CancelKeyPress;

                Console.WriteLine();
                Console.WriteLine("To interupt call press Ctrl + C");
                Console.WriteLine();

                Console.CancelKeyPress += new ConsoleCancelEventHandler(Console_CancelKeyPress);
                while (!checkpoint && currentBalance >= duration * pricePerSecond)
                {
                    Thread.Sleep(1000);
                    duration++;                 
                }
              
                A.MinusBalance(duration * pricePerSecond);

                TimeSpan seconds = EndCall(fromDate);
                double result = seconds.TotalSeconds * pricePerSecond;

                CallDurationDisplay(seconds, result, A);
            }
        }

        static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            e.Cancel = true;
            checkpoint = true;
        }


        public TimeSpan EndCall(DateTime fromDate)
        {
            DateTime tillDate = DateTime.Now;
            TimeSpan diff1 = tillDate - fromDate;

            return diff1;
        }
        public void CallDurationDisplay(TimeSpan seconds, double result, Subscriber A)
        {
            Console.WriteLine("Duration :{0:hh\\:mm\\:ss}, Son istifade = {1:0.00} azn, Cari balans = {2:0.00} azn", seconds, result, A.Balance);
        }
    }
}
