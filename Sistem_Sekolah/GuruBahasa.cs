using System;

namespace SistemSekolah
{
    public class GuruBahasa : Guru
    {
        public GuruBahasa(string nama, int umur) : base(nama, umur, "Bahasa") { }
        public void MengajarBahasa()
        {
            Console.WriteLine($"{Nama} sedang mengajarkan tata bahasa, struktur kalimat, dan kosa kata.");
        }
        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} sedang melakukan aktivitas sebagai Guru Bahasa.");
        }
    }
}
