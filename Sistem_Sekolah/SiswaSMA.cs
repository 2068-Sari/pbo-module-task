using System;

namespace SistemSekolah
{
    public class SiswaSMA : Siswa
    {
        public SiswaSMA(string nama, int umur, string kelas) : base(nama, umur, kelas) { }
        public void UjianNasional()
        {
            Console.WriteLine($"{Nama} sedang fokus dan serius mempersiapkan Ujian Nasional SMA.");
        }
        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} sedang melakukan aktivitas sebagai Siswa SMA (Fokus Akademik Tinggi).");
        }
    }
}
