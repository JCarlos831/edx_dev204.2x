using System;

namespace abstract_and_sealed_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Employee newEmp = new Employee();
            // newEmp.Login();

            Manager myManager = new Manager();
            myManager.Login();
            myManager.Hire();
        }
    }
}
