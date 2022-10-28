using System;
namespace inheritance
{
   
        class Vehicle
        {
            public string name = "tesla";
            public void honk()
            {
                Console.WriteLine("elon,musk");

            }

        }
        class Car : Vehicle
        {
            public string model1Name = "tesla1";

        }
        class program
        {
            static void Main(string[] args)
            {
                Car myCar = new Car();
                myCar.honk();
                Console.WriteLine(myCar.name + " " + myCar.model1Name);
            }
        }
    }