using System;

namespace SistemSekolah
{
    public class SiswaSD : Siswa
    {
        public SiswaSD(string nama, int umur, string kelas) : base(nama, umur, kelas) { }

        public void Main()
        {
            Console.WriteLine($"{Nama} sedang bermain bersama teman-teman di jam istirahat SD.");
        }
        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} sedang melakukan aktivitas sebagai Siswa SD (Belajar & Bermain).");
        }
    }
}
