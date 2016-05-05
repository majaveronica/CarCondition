    class Program
    {
        static void Main(string[] args)
        {
            //ulazni podaci
            int vehicleCode = 1;
            int speed = 31;
            String[] vehicle = { "truck","bus","car" };
            if(vehicle[vehicleCode]!="car")
            {
                switch(speed)
                {
                    case 10:
                    case 20:
                    case 30:
                        Console.WriteLine(vehicle[vehicleCode] + " speed is "
+ speed);
                        break;
                    default:
                        Console.WriteLine(vehicle[vehicleCode] + " is not 10, 
20 nor 30");
                        break;
                }
            }
        }
    }