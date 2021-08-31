using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MobileCallSimulation
{
    class Subscriber
    {
        public Subscriber()
        {
        }
        public Subscriber(string number, double balance, Tariff tarif)
        {
            MSISDN = number;
            Balance = balance;
            TarifPackage = tarif;
        }

        public string MSISDN { get; set; }
        public double Balance { get; set; }
        public Tariff TarifPackage { get; set; }

        public void AddBalance(double balance)
        {
            Balance += balance;
        }
        public void MinusBalance(double balance)
        {
            Balance -= balance;
        }

        //public void StartCall(Subscriber b)
        //{
        //    if (TarifPackage.PackageName == null)
        //    {
        //        Console.WriteLine("You cannot create a call, a tarif plan has to be choosen.");
        //    }
        //    else
        //    {
        //        double currentBalance = Balance;
        //        double duration = 0.0;
        //        DateTime fromDate = DateTime.Now;

        //        while (currentBalance >= duration * (TarifPackage.PriceForTalikngMinute / 60.0) && duration < 5)
        //        {
        //            Thread.Sleep(1000);
        //            duration++;
        //        }

        //        duration = 0;

        //        MinusBalance(duration * (TarifPackage.PriceForTalikngMinute / 60.0));

        //        TimeSpan seconds = EndCall(b, fromDate);
        //        double result = seconds.TotalSeconds * (TarifPackage.PriceForTalikngMinute / 60.0);

        //        CallDurationDisplay(seconds, result);
        //    }
        //}

        //public TimeSpan EndCall(Subscriber b, DateTime fromDate)
        //{
        //    DateTime tillDate = DateTime.Now;
        //    TimeSpan diff1 = tillDate - fromDate;

        //    return diff1;
        //}

        //public void CallDurationDisplay(TimeSpan seconds, double result)
        //{
        //    Console.WriteLine("Duration :{0:hh\\:mm\\:ss}, Son istifade = {1:0.00} azn, Cari balans = {2:0.00} azn", seconds, result, Balance);
        //}

        public void Display()
        {
            Console.WriteLine("_______________________________________");
            Console.WriteLine("SUBSCRIBER`s DATA ");
            Console.WriteLine(" MSISDN       = {0} ", MSISDN);
            Console.WriteLine(" Balance      = {0:0.00} azn ", Balance);
            Console.WriteLine(" Tarif plan   = {0} ", TarifPackage.PackageName);
            Console.WriteLine(" Talk/min     = {0:0.00} azn ", TarifPackage.PriceForTalikngMinute);
            Console.WriteLine(" SMS          = {0:0.00} azn ", TarifPackage.PriceForSmsSending);
            Console.WriteLine(" 1 MegaByte   = {0:0.00} azn", TarifPackage.PriceForOneMegabyte);
            Console.WriteLine("_______________________________________");

        }
    }
}
