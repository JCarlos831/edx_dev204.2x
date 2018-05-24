using System;

namespace ac_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Anon Class

            var anon = new { Name = "Gerry", Age = 29 };

            Console.WriteLine(anon.Name + anon.Age);

            #endregion
        }
    }
}
