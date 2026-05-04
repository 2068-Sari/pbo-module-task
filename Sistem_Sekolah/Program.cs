using System;
using System.Collections.Generic;

namespace SistemSekolah
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEM INFORMASI SEKOLAH ===\n");

            // a. Buat objek sekolah
            Sekolah sekolahMaju = new Sekolah();

            // b. Buat beberapa objek orang
            SiswaSD mikha = new SiswaSD("Mikha", 10, "4 SD");
            SiswaSMA louis = new SiswaSMA("Louis", 17, "12 SMA");
            GuruMatematika pakMinho = new GuruMatematika("Minho", 45);
            GuruBahasa buHellen = new GuruBahasa("Hellen", 38);

            // c. Tambahkan ke sekolah
            Console.WriteLine("--- a. Menambahkan Data ---");
            sekolahMaju.TambahOrang(mikha);
            sekolahMaju.TambahOrang(louis);
            sekolahMaju.TambahOrang(pakMinho);
            sekolahMaju.TambahOrang(buHellen);
            Console.Clear();

            Console.WriteLine();
            pakMinho.Aktivitas(); // Objek Guru
            louis.Aktivitas();    // Objek Siswa
            Console.WriteLine();

            Console.WriteLine();
            pakMinho.MengajarHitung();
            Console.WriteLine();

            Console.WriteLine();
            pakMinho.InfoOrang();
            Console.WriteLine();


            Console.WriteLine();
            louis.UjianNasional();
            Console.WriteLine();

            Console.WriteLine();
            Orang contohOrang = new SiswaSD("Siswa Diyan", 9, "3 SD");
            contohOrang.Aktivitas();
            Console.WriteLine();

            // d. Tampilkan semua data
            sekolahMaju.DaftarOrang();

            // e. Demonstrasikan polymorphism
            Console.WriteLine();
            foreach (Orang orang in sekolahMaju.GetDaftarOrang())
            {
                orang.Aktivitas();
            }

            // f. method khusus
            Console.WriteLine();
            mikha.Main();
            louis.UjianNasional();
            pakMinho.MengajarHitung();  // Hanya dimiliki GuruMatematika
            buHellen.MengajarBahasa();   // Hanya dimiliki GuruBahasa

            Console.WriteLine("Program selesai");
            Console.ReadLine();
        }
    }
}