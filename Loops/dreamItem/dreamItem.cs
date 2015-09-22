using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading;


namespace dreamItem
{
    class dreamItem
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            string input = Console.ReadLine();
            string month = input.Split('\\')[0];
            decimal moneyperhour = decimal.Parse(input.Split('\\')[1]);
            decimal hoursperday = decimal.Parse(input.Split('\\')[2]);
            decimal price = decimal.Parse(input.Split('\\')[3]);
            

            decimal workingdays = 0M;

            switch (month)
            {
                case "Jan":
                    workingdays = 31M - 10M;
                    break;
                case "Feb":
                    workingdays = 28M - 10M;
                    break;
                case "March":
                    workingdays = 31M - 10M;
                    break;
                case "Apr":
                    workingdays = 30M - 10M;
                    break;
                case "May":
                    workingdays = 31M - 10M;
                    break;
                case "June":
                    workingdays = 30M - 10M;
                    break;
                case "July":
                    workingdays = 31M - 10M;
                    break;
                case "Aug":
                    workingdays = 31M - 10M;
                    break;
                case "Sept":
                    workingdays = 30M - 10M;
                    break;
                case "Oct":
                    workingdays = 31M - 10M;
                    break;
                case "Nov":
                    workingdays = 30M - 10M;
                    break;
                case "Dec":
                    workingdays = 31M - 10M;
                    break;
                default:
                    
                    break;
            }

           
            decimal salary = workingdays * moneyperhour * hoursperday;

            if (salary > 700M)
            {
                salary = salary + (salary * 0.1M);
            }
            if (salary >= price)
            {
                Console.WriteLine("Money left = {0:F2} leva.", (salary - price)); 
            }
            else
            {
                Console.WriteLine("Not enough money. {0:F2} leva needed.", price - salary);
            }
            
        }
    }
}
