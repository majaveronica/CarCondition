using System;
    class Program
    {
        static void Main(string[] args)
        {
         //ulazni podaci
        int vehicleCode = 1;
        int speed = 30;
        String[] vehicle = { "truck","bus","car" };
 
        if(vehicle[vehicleCode]!="car")
        {
            switch(speed)
            {
                case 10:
                    Console.WriteLine(vehicle[vehicleCode] + " speed is 10");
                    break;
                case 20:
                    Console.WriteLine(vehicle[vehicleCode] + " speed is 20");
                    break;
                case 30:
                    Console.WriteLine(vehicle[vehicleCode] + " speed is 30");
                    break;
                default:
                    Console.WriteLine(vehicle[vehicleCode] + " speed is not 
10, 20 or 30");
                    break;
            }
        }
        }
    }