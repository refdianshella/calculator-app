using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            // int a = 10; // declarasi variable a,dengan nilai awal 10;
            // int b = 6;  // declarasi variabele b,dengan nilai awal 6;

            Console.Write("Pilih menu calculator: ");

            Console.Write("\n\n1. Penambahan");
            Console.Write("\n2. Pegurangan");
            Console.Write("\n3. Perkalian");
            Console.Write("\n4. Pembagian");

            Console.Write("\n\nInput Nomor Menu [1..4] : ");
            int c = int.Parse(Console.ReadLine());
            if (c == 1)
            {
                Console.Write("\n\nInputkan nilai a = ");
                int a = int.Parse(Console.ReadLine()); // proses casting 
                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine()); //Process casting
                Console.WriteLine();

                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            }

            else if (c == 2)
            {
                Console.Write("\n\nInputkan nilai a = ");
                int a = int.Parse(Console.ReadLine()); // proses casting 
                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine()); //Process casting
                Console.WriteLine();
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            }

            else if (c == 3)
            {
                Console.Write("\n\nInputkan nilai a = ");
                int a = int.Parse(Console.ReadLine()); // proses casting 
                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine()); //Process casting
                Console.WriteLine();
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            }

            else if (c == 4)
            {
                Console.Write("\n\nInputkan nilai a = ");
                int a = int.Parse(Console.ReadLine()); // proses casting 
                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine()); //Process casting
                Console.WriteLine();
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }

            else
            {
                Console.Write("\n\nmaaf menu salah ");
            }

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
