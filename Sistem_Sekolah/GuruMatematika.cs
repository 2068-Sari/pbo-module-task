using System;
using System.Collections.Generic;
using System.Text;

namespace SistemSekolah
{
    public class GuruMatematika : Guru
    {
        // Constructor akan mengisi mataPelajaran dengan "Matematika"
        public GuruMatematika(string nama, int umur) : base(nama, umur, "Matematika") { }
        public void MengajarHitung()
        {
            Console.WriteLine($"{Nama} sedang mengajarkan rumus logika dan operasi hitung angka.");
        }
        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} sedang melakukan aktivitas sebagai Guru Matematika.");
        }
    }
}
