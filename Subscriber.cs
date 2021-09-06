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
        public Subscriber(string msisdn)
        {
            MSISDN = msisdn;
        }

        public string MSISDN { get; set; } // it has to be used Subscriber creation only
        public double Balance { get; set; }
        public Tariff TarifPackage { get; set; }

        public void InvokeMenu()
        {
            Menu menu = new Menu();
            Balance = menu.InitBalance();
            TarifPackage = menu.InitTariff();
        }

        public void AdjustBalance(double balance)
        {
            if (balance >= 0)
            {
                Balance += balance;
            }
            else
            {
                if (balance > Balance)
                {
                    Balance -= Balance;
                }
                else
                    Balance += balance;
            }            
        }

        public void Display()
        {
            if (TarifPackage == null)
            {
                Console.WriteLine("_______________________________________");
                Console.WriteLine("SUBSCRIBER`s DATA");
                Console.WriteLine(" MSISDN       = {0} ", MSISDN);
                Console.WriteLine(" Balance      = {0:0.00} azn ", Balance);
                Console.WriteLine(" Tarif plan has not been selected ");
                Console.WriteLine();
            }
            else
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
}
