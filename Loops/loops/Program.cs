
namespace loops
{ using System;
  using System.Numerics;
    

    class Program
    {
        static void Main()
        {
            string battery = Console.ReadLine();
            battery = battery.Remove(battery.Length - 1);
            int baterypower = int.Parse(battery);
            int remainingprograms = 0;
            bool needcharge = false;
            bool phoneoff = false;
            if (baterypower <= 0)
            {
                phoneoff = true;
            }
            else if (baterypower <= 15)
            {
                needcharge = true;
            }
            string input = Console.ReadLine();
            while (input.ToLower() != "end")
            {
                int percentage = int.Parse(input.Substring(input.Length -3, 2));
                
                remainingprograms++;
                if (baterypower > 15)
                {
                    remainingprograms--;
                    baterypower = baterypower - percentage;
                }
                if (baterypower <= 15 && baterypower > 0)
                {
                    needcharge = true;
                }
                if (baterypower <= 0)
                {
                    phoneoff = true;
                }
                
                input = Console.ReadLine();
            }
            if (phoneoff == true)
            {
                Console.WriteLine("Phone Off");
            }
            else if (needcharge == true)
            {
                Console.WriteLine("Connect charger -> {0}%", baterypower);
                Console.WriteLine("Programs left -> {0}", remainingprograms);
            }
            else if (needcharge == false)
            {
                Console.WriteLine("Successful complete -> {0}%", baterypower);
            }
        }
    }
}
