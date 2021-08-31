using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileCallSimulation
{
    public class Tariff
    {
        public Tariff()
        {
        }

        public Tariff(string name)
        {
            PackageName = name;
        }

        public Tariff(string name, double talk)
        {
            PackageName = name;
            PriceForTalikngMinute = talk;
        }

        public Tariff(string name, double talk, double sms, double priceForOneMegabyte)
        {
            PackageName = name;
            PriceForTalikngMinute = talk;
            PriceForSmsSending = sms;
            PriceForOneMegabyte = priceForOneMegabyte;
        }

        public Tariff(int type)
        {
            switch (type)
            {
                case 1:
                    PackageName = "TALK";
                    PriceForTalikngMinute = 0.06;
                    PriceForSmsSending = 0.08;
                    PriceForOneMegabyte = 10.00;
                    break;
                case 2:
                    PackageName = "SMS";
                    PriceForTalikngMinute = 0.08;
                    PriceForSmsSending = 0.06;
                    PriceForOneMegabyte = 10.00;
                    break;
                case 3:
                    PackageName = "WEB";
                    PriceForTalikngMinute = 0.07;
                    PriceForSmsSending = 0.07;
                    PriceForOneMegabyte = 5.00;
                    break;
                //case 4:
                //    PackageName = "BASIC";
                //    PriceForTalikngMinute = 0.02;
                //    PriceForSmsSending = 0.02;
                //    PriceForOneMegabyte = 8.00;
                //    break;
                default:
                    break;
            }
        }

        public string PackageName { get; set; }
        public double PriceForTalikngMinute { get; set; }
        public double PriceForSmsSending { get; set; }
        public double PriceForOneMegabyte { get; set; }

        public void Display()
        {
            Console.WriteLine("Package = {0}, TalkingMinute = {1}, SMSSend = {2}, 1 Megabyte = {3}", PackageName, PriceForTalikngMinute, PriceForSmsSending, PriceForOneMegabyte);
        }
    }
}
