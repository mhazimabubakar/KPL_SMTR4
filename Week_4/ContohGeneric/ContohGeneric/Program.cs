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

            ListData<int, int> objData1 = new ListData<int, int>(1111, 2222);
            objData1.GetData();

            ListData<int, double> objData2 = new ListData<int, double>(57, 12.31);
            objData2.GetData();

            ListData<int, DateTime> objData3 = new ListData<int, DateTime>(1, DateTime.Today);
            objData3.GetData();
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

    class ListData<T, U>
    {
        private T data1;
        private U data2;
        public ListData(T inputAngka1, U inputAngka2)
        {
            data1 = inputAngka1;
            data2 = inputAngka2;
        }
        public void GetData()
        {
            Console.WriteLine("Data 1  = " + data1 + " | Data 2 = " + data2);
        }
    }

}
