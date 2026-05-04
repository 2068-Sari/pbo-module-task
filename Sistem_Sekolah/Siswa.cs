using System;

namespace SistemSekolah
{
    public class Siswa : Orang
    {
        private string kelas = " ";

        public string Kelas
        {
            get { return kelas; }
            set { kelas = value; }
        }

        public Siswa(string nama, int umur, string kelas) : base(nama, umur)
        {
            Kelas = kelas;
        }

        public void Belajar()
        {
            Console.WriteLine($"{Nama} sedang belajar di kelas {Kelas}.");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} sedang melakukan aktivitas sebagai Siswa.");
        }

        public override void InfoOrang()
        {
            base.InfoOrang();
            Console.WriteLine($"Status : Siswa | Kelas : {Kelas}");
        }
    }

}
