using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bulanbulanan
{
    public class StatusMahasiswa
    {
        public enum Status
        {
            Terdaftar,
            Aktif,
            Lulus,
            Cuti
        };

        public enum Aksi
        {
            CetakKSM,
            Lulus,
            AjukanCuti,
            SelesaiCuti,
        };

        public class Transisi
        {
            public Status StateAwal;
            public Status StateAkhir;
            public Aksi Trigger;

            public Transisi(Status awal, Status akhir, Aksi yangDilakukan)
            {
                StateAwal = awal;
                StateAkhir = akhir;
                Trigger = yangDilakukan;
            }
        }
        Transisi[] listPerpindahanState =
            {
            new Transisi(Status.Terdaftar, Status.Aktif, Aksi.CetakKSM),
            new Transisi(Status.Aktif, Status.Lulus, Aksi.Lulus),
            new Transisi(Status.Terdaftar, Status.Cuti, Aksi.AjukanCuti),
            new Transisi(Status.Cuti, Status.Terdaftar, Aksi.SelesaiCuti)
        };

        public Status StateSaatIni = Status.Terdaftar;

        public Status GetStatusAkhir(Status awal, Aksi yangDilakukan)
        {
            Status statusAkhir = awal;

            for (int i = 0; i < listPerpindahanState.Length; i++)
            {
                Status stateAwal = listPerpindahanState[i].StateAwal;
                Aksi triggerState = listPerpindahanState[i].Trigger;

                if (stateAwal == awal && triggerState == yangDilakukan)
                {
                    statusAkhir = listPerpindahanState[i].StateAkhir;
                }
            }

            return statusAkhir;
        }

        public void AksiYangDilakukan(Aksi yangDilakukan)
        {
            Status stateBerikutnya = GetStatusAkhir(StateSaatIni, yangDilakukan);
            StateSaatIni = stateBerikutnya;

            Console.WriteLine("State saat ini adalah: " + StateSaatIni);

            if (StateSaatIni == Status.Lulus)
            {
                Console.WriteLine("Selamat Anda Telah Lulus!");
            }
        }

        public StatusMahasiswa()
        {
            StateSaatIni = Status.Terdaftar;
        }
    }
}
