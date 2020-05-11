using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace csharp8practice
{

    class Rectangle
    {
        public readonly float Width, Height;

        public Rectangle(float width, float height)
        {
            Width = width;
            Height = height;
        }

        public void Deconstruct(out float width, out  float height)
        {
            width = Width;
            height = Height;
        }
    }

    public class Wine
    {
        public decimal Price;
        public int Year;
        
        
        public Wine(decimal price) { Price = price; }
        public Wine(decimal price, int year) : this(price) { Year = year; }
    }

    public class Octopus
    {
        string name;
        public int age = 10;
        static readonly int legs;

        public static readonly DateTime StartupTime = DateTime.Now;

        const string message = "Hello Thanks";

        public static int multiply(int x, int y) => x * y; 

    }
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World!";

            Console.WriteLine(message[^1]);
            Console.WriteLine(message[^2]);
            Console.WriteLine(message[..2]);
            Console.WriteLine(message[2..]);

            Console.WriteLine(Octopus.StartupTime);

            Console.WriteLine(Octopus.multiply(3, 6));

            string s = null;

            s ??= "I am null";
            Console.WriteLine(s);



            if (File.Exists("file.txt"))
            {
                using var reader = File.OpenText("mmmm.txt");
                Console.WriteLine(reader.ReadLine());
            }

            Point p = new Point();
            p.x = 7;
            p.y = 8;

            

            //int c = checked(a * b);

            int[,] matrix = new int[3, 3];

            for(int i = 0; i <matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = i * 3 + j;
                }
            }

            int[,] mat = new int[,]
            {
                {4, 5, 6 },
                {14, 25, 16 },
                {44, 35, 46 }
            };

            int[] numbers = { 0, 1, 2, 4 };
            ref int numref = ref numbers[3];
            numref = 10;

            Console.WriteLine(numbers[3]);
            Console.WriteLine(numref);


            ref string xRef = ref GetX();
            xRef = "New Value";
            Console.WriteLine(x);

            StringBuilder sb = null;
            string s1 = sb?.ToString();

            int sx = 0;

            while (sx < 10)
            {
                if (sx == 5)
                {
                    break;
                }
                     
                Console.WriteLine(sx);
                sx++;
            }


            for(int i = 0; i < 20; i++)
            {
                if((i % 2) == 0)
                {
                    continue;
                }

                Console.WriteLine(i + " ");
            }

        }

        public struct Point { public int x; public int y; }

        static string x = "Old Value";
        static ref string GetX() => ref x;

        

        
    }
}


namespace MyTradingCompany
{
    class Class1
    {

    }

    namespace Common
    {
        class ReportBase { }
    }

    namespace ManagementReporting
    {
        using Common;
        
        class SalesReport : ReportBase
        {
            
        }
    }
}
