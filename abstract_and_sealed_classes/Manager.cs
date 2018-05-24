using System;

namespace abstract_and_sealed_classes
{
    class Manager : Employee

    public override voide Login()
    {
      Console.WriteLine("Manager Login");
    }

    public override void Hire()
    {
      Console.WriteLine("Hire someone");
    }
}