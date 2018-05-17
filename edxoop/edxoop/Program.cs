using System;

namespace edxoop
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DrinksMachine myMachine = new DrinksMachine();
            myMachine._location = "Kitchen";
            myMachine._model = "DM1000";

            // Write location to console
            Console.WriteLine(myMachine._location);
            // Run MakeCappuccino function
            myMachine.MakeCappuccino();
        }
    }
}
