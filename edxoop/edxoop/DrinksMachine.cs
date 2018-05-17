using System;
namespace edxoop
{
    public class DrinksMachine
    {
        // The following statements declare private member variables
        public string _location { get; set; }
        public string _make { get; set; }
        public string _model { get; set; }

        // The following statements declare public methods
        public void MakeCappuccino()
        {
            // Method logic goes here
            Console.WriteLine("Cappuccino is made.");
        }

        public void MakeEspresso()
        {
            // Method logic goes here
        }
    }
}
