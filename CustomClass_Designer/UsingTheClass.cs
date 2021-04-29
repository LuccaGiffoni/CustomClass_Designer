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

            // Variable to alocate the user's response
            int userResponse;

            // Variable to end the loop if the check-out option is selected by the user
            int checkout = 0;

            #endregion

            #region Header

            // The header to your store, showing all your products
            // You can change the name of your "store"
            Console.WriteLine("                                 Welcome to " + MyStoreName);
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("                                      Catalog:                                           ");
            Console.WriteLine();
            Console.WriteLine("[1] M1.0WN Laptop |     i8 Processor + 24 GB of RAM + 81 GB of SSD      | Price: 1299 U$");
            Console.WriteLine("[2] M1.0WN Phone  |  A24 Processor + 8 GB of RAM +  33643 MB of Memory  | Price: 899 U$");
            Console.WriteLine("[3] M1.0WN Mouse  |                    KB24/8 Sensor                    | Price: 49 U$");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------------");

            #endregion

            #region UserChoosing

            // Getting the user response
            Console.WriteLine();
            Console.WriteLine("Choose what you want (type the number of the item -- 1, 2 or 3): ");
            userResponse = Convert.ToInt32(Console.ReadLine());

            // Making the user select everything he wants how many time he want it, until he decides to check-out
            do
            {
                #region Laptop Option
                if (userResponse == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("How many LAPTOPS do you want? ");
                    laptopQuantity = Convert.ToInt32(Console.ReadLine());

                    // Give user the option to choose more things to buy
                    Console.WriteLine();
                    Console.WriteLine("If you want something else, type it's number, or type 4 to check-out: ");
                    userResponse = Convert.ToInt32(Console.ReadLine());
                }
                #endregion

                #region Phone Option
                else if (userResponse == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("Nice! How many PHONES do you want? ");
                    phoneQuantity = Convert.ToInt32(Console.ReadLine());

                    // Give user the option to choose more things to buy
                    Console.WriteLine();
                    Console.WriteLine("If you want something else, type it's number, or type 4 to check-out: ");
                    userResponse = Convert.ToInt32(Console.ReadLine());
                }
                #endregion

                #region Mouse Option
                else if (userResponse == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("Nice! How many MOUSES do you want? ");
                    mouseQuantity = Convert.ToInt32(Console.ReadLine());

                    // Give user the option to choose more things to buy
                    Console.WriteLine();
                    Console.WriteLine("If you want something else, type it's number, or type 4 to check-out: ");
                    userResponse = Convert.ToInt32(Console.ReadLine());
                }
                #endregion

                #region Check-Out Option
                else if (userResponse == 4)
                {
                    {
                        // Calling the constructor
                        MyCart customCart = new MyCart(laptopQuantity, phoneQuantity, mouseQuantity);

                        // Calling the method to check-out
                        // Using MyCustomClass properties to display data
                        customCart.CheckOut();
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                        Console.WriteLine("                                         Your cart:                                      ");
                        Console.WriteLine();
                        Console.WriteLine("Total laptops: " + customCart.Laptop);
                        Console.WriteLine("Total phones: " + customCart.Phone);
                        Console.WriteLine("Total mouses: " + customCart.Mouse);
                        Console.WriteLine();
                        Console.WriteLine("Total to pay: " + customCart.Amount + "U$");
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------------------------------------------");

                        // This variable set the end to the program, the end of the check-out process
                        checkout = 1;
                    }
                }
                #endregion

                #region Invalid Option
                else
                {
                    Console.WriteLine("That's not valid! Type 1 to try again!");
                    userResponse = Convert.ToInt32(Console.ReadLine());
                }
                #endregion

                #endregion
            }
            // While condition to stop the loop when the user choose to check-out
            while (checkout != 1);
        }
    }
}
