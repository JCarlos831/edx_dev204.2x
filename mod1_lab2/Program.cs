﻿using System;

namespace mod1_lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating an object of Car() Class by using Type Inference called Car1
            var Car1 = new Car();
            // Using dot notation to call members on Car1
            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11000;

            // Instatiating Car2
            var Car2 = new Car("Red", 2008);

            // Access static members
            int carCount = Car.CountCars();

            // Output to the console window
            Console.WriteLine($"There are {carCount} cars on inventory right now.");
        }
    }

    // Declaring the Car() Class
    // This Class has 3 properties: Color, Year, and Mileage
    public class Car
    {
        // Defining properties
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        // Creates integer variable called "instances" and assigns value to 0
        private static int instances = 0;

        // Adding a Constructor
        // This constructor instantiates a Car() object while only having hte car's color and year information available
        public Car(string color, int year)
        {
            this.Color = color;
            this.Year = year;
            // Every time the constructor runs, increment "instances"
            instances++;
        }

        // Adding another Constructor
        // This constructor instantiates a Car() object while only having the car's year and mileage information available
        public Car(int year, int mileage)
        {
            this.Year = year;
            this.Mileage = mileage;
            // Every time the constructor runs, increment "instances"
            instances++;
        }

        public Car()
        {
            // Every time the constructor runs, increment "instances"
            instances++;
        }

        // Declare static member
        public static int CountCars()
        {
            return instances;
        }
    }
}
