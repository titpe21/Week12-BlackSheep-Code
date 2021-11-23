using System;
using System.IO;

namespace ChuckNorrisRandomJoke
{
    class Program
    {
        static void Main(string[] args)
        {
            //string filePath = @"C:\Users\julia.voronetskaja\samples\chuck.txt";
            //string[] jokesAboutChuck = File.ReadAllLines(filePath);

            //Random rnd = new Random();
            //int randomIndex = rnd.Next(0, jokesAboutChuck.Length);
            //Console.WriteLine(jokesAboutChuck[randomIndex]);

            Console.WriteLine(GetRandomJoke());
        }

        public static string GetRandomJoke()
        {
            string filePath = @"C:\Users\julia.voronetskaja\samples\chuck.txt";
            string[] jokesAboutChuck = File.ReadAllLines(filePath);
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, jokesAboutChuck.Length);

            return jokesAboutChuck[randomIndex];
        }

    }
}
