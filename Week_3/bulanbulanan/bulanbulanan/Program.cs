using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bulanbulanan
{
    class Program
    {
        public enum JenisKelamin { Pria = 0, Lakilaki, Wanita = 50, Perempuan, Lainlain = 99 };

        static void Main(string[] args)
        {
            string[] contohArray = { "a", "b", "c", "d", "e", "f" };

            Console.WriteLine(contohArray[0]);



            StatusMahasiswa objStatusMhs = new StatusMahasiswa();
            Console.WriteLine(objStatusMhs.StateSaatIni);

            objStatusMhs.AksiYangDilakukan(StatusMahasiswa.Aksi.Lulus);
            objStatusMhs.AksiYangDilakukan(StatusMahasiswa.Aksi.AjukanCuti);
            objStatusMhs.AksiYangDilakukan(StatusMahasiswa.Aksi.SelesaiCuti);
            objStatusMhs.AksiYangDilakukan(StatusMahasiswa.Aksi.CetakKSM);
            objStatusMhs.AksiYangDilakukan(StatusMahasiswa.Aksi.Lulus);
        }
    }
}
