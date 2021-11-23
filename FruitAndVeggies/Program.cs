using System;
using System.IO;

namespace FruitAndVeggies
{
    class Program
    {
        static void Main(string[] args)
        {
            //read data from fruit.txt
            string fruitPath = @"C:\Users\julia.voronetskaja\samples\fruit.txt";
            string[] veggieData = File.ReadAllLines(fruitPath);

            //read data from veggie.txt
            string veggiePath = @"C:\Users\julia.voronetskaja\samples\veggie.txt";
            string[] fruitData = File.ReadAllLines(veggiePath);

            File.WriteAllLines(fruitPath, fruitData);
            File.WriteAllLines(veggiePath, veggieData);
        }
    }
}
