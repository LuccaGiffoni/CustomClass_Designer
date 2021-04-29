using MyCustomClass;
using System;

namespace UsingMyClass
{
    class CustomCartCreation
    {

        public static void Main()
        {
            #region AuxiliarVariables
            // Chosse a name for your custom store
            string MyStoreName = "MyStore";

            // Variables for quantity -- all start with zero to not 'exist' if not selected by the user
            int laptopQuantity = 0;
            int phoneQuantity = 0;
            int mouseQuantity = 0;

            // Variables for the user's response
            int userResponse;
            int limit = 0;

            #endregion

            #region Header

            // You can change the name of your "store"
            Console.WriteLine("Welcome to " + MyStoreName);
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("Catalog:");
            Console.WriteLine("[1] M1.0WN Laptop -- i8 Processor + 24 GB of RAM + 81 GB of SSD | Price: 1299 U$");
            Console.WriteLine("[2] M1.0WN Phone -- A24 Processor + 8 GB of RAM +  33643 MB of Memory | Price: 899 U$");
            Console.WriteLine("[3] M1.0WN Mouse -- KB24/8 Sensor | Price: 49 U$");
            Console.WriteLine("-------------------------------------------------------------------------------------");

            #endregion

            #region UserChoosing

            // Getting the user response
            Console.WriteLine("Choose what you want (type the number of the item -- 1, 2 or 3): ");
            userResponse = Convert.ToInt32(Console.ReadLine());

            // Making the user select everything he wants how many time he want it
            do
            {
                if (userResponse == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------------------------------------------------------------");
                    Console.WriteLine("Nice! How many laptops do you want? ");
                    laptopQuantity = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("If you want something else, type it's number, or type 4 to check-out: ");
                    userResponse = Convert.ToInt32(Console.ReadLine());
                }
                else if (userResponse == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------------------------------------------------------------");
                    Console.WriteLine("Nice! How many phones do you want? ");
                    phoneQuantity = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("If you want something else, type it's number, or type 4 to check-out: ");
                    userResponse = Convert.ToInt32(Console.ReadLine());
                }
                else if (userResponse == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------------------------------------------------------------");
                    Console.WriteLine("Nice! How many mouses do you want? ");
                    mouseQuantity = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("If you want something else, type it's number, or type 4 to check-out: ");
                    userResponse = Convert.ToInt32(Console.ReadLine());
                }
                else if (userResponse == 4)
                {
                    {
                        // Calling the constructor
                        MyCart customCart = new MyCart(laptopQuantity, phoneQuantity, mouseQuantity);

                        // Calling the method to check-out
                        customCart.CheckOut();
                        Console.WriteLine();
                        Console.WriteLine("-------------------------------------------------------------------------------------");
                        Console.WriteLine("Total to pay: " + customCart.Amount + "U$");

                        limit = 1;
                    }
                }
                else
                {
                    Console.WriteLine("That's not valid! Type 1 to try again!");
                    userResponse = Convert.ToInt32(Console.ReadLine());
                }

                #endregion
            }
            while (limit != 1);
        }
    }
}
