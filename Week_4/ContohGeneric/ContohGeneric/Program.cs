using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContohGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //untuk merubah tipe data hanya perlu merubah yang di dalam <...>
            Halo.PrintInput<DateTime>(DateTime.Now);

            Console.WriteLine(Halo.Kalikan<int>(25, 3));

            Console.WriteLine(Halo.GabungkanJadiString<string, string, int>("abc", "def", 2112));
        }
    }

    class Halo
    {
        //<T> (generic) digunakan untuk merubah-ubah tipe data
        public static void PrintInput<T>(T inputUser)
        {
            Console.WriteLine("Input dari user: " + inputUser);
        }
        public static string GabungkanJadiString<T, U, V>(T a, U b, V c)
        {
            return c + "" + a + b;
        }
        public static T Kalikan<T>(T a, T b)
        {
            dynamic tempA = a;
            dynamic tempB = b;

            return tempA * tempB;
        }

        //TERLALU BOROS---->>>>>>>
        //public static void PrintInput(string inputUser)
        //{
        //    Console.WriteLine("Input dari user: " + inputUser);
        //}
        //public static void PrintInput(int inputUser)
        //{
        //    Console.WriteLine("Input dari user: " + inputUser);
        //}
        //public static void PrintInput(float inputUser)
        //{
        //    Console.WriteLine("Input dari user: " + inputUser);
        //}
        //public static void PrintInput(double inputUser)
        //{
        //    Console.WriteLine("Input dari user: " + inputUser);
        //}
        //public static void PrintInput(DateTime inputUser)
        //{
        //    Console.WriteLine("Input dari user: " + inputUser);
        //}
    }
}
