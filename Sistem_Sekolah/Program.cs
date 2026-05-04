using System;
using System.Collections.Generic;

namespace SistemSekolah
{
    public class Orang
    {
        // Enkapsulasi dengan standar naming convention C#
        private string nama = " ";
        private int umur;

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public int Umur
        {
            get { return umur; }
            set
            {
                if (value >= 0)
                    umur = value;
                else
                    umur = 0;// Validasi sederhana: umur tidak boleh negatif
            }
        }

        public Orang(string nama, int umur)
        {
            Nama = nama;
            Umur = umur;
        }

        // Virtual agar bisa di-override (Polymorphism)
        public virtual void Aktivitas()
        {
            Console.WriteLine($"{Nama} sedang melakukan aktivitas umum.");
        }

        public virtual void InfoOrang()
        {
            Console.WriteLine($"Nama : {Nama}");
            Console.WriteLine($"Umur : {Umur} tahun");
        }
    }

    // ==========================================
    // 2. KELAS TURUNAN LEVEL 1 (Siswa & Guru)
    // ==========================================
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

    public class Guru : Orang
    {
        private string mataPelajaran = " ";

        public string MataPelajaran
        {
            get { return mataPelajaran; }
            set
            {
                mataPelajaran = value;
            }
        }

        public Guru(string nama, int umur, string mataPelajaran) : base(nama, umur)
        {
            MataPelajaran = mataPelajaran;
        }

        public void Mengajar()
        {
            Console.WriteLine($"{Nama} sedang mengajar mata pelajaran {MataPelajaran}.");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} sedang melakukan aktivitas mengajar sebagai Guru.");
        }

        public override void InfoOrang()
        {
            base.InfoOrang();
            Console.WriteLine($"Status : Guru | Mata Pelajaran : {MataPelajaran}");
        }
    }

  
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

    public class GuruMatematika : Guru
    {
        // Constructor otomatis mengisi mataPelajaran dengan "Matematika"
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

    public class GuruBahasa : Guru
    {
        // Constructor otomatis mengisi mataPelajaran dengan "Bahasa"
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

    // ==========================================
    // 4. KELAS SEKOLAH (Komposisi/Agregasi)
    // ==========================================
    public class Sekolah
    {
        private List<Orang> _daftarOrang;

        public Sekolah()
        {
            _daftarOrang = new List<Orang>();
        }

        // Method TambahOrang
        public void TambahOrang(Orang orang)
        {
            _daftarOrang.Add(orang);
            Console.WriteLine($"> Berhasil menambahkan {orang.Nama} ke sistem sekolah.");
        }

        // Method DaftarOrang
        public void DaftarOrang()
        {
            Console.WriteLine("\n=== DAFTAR SELURUH WARGA SEKOLAH ===");
            foreach (var orang in _daftarOrang)
            {
                orang.InfoOrang();
                Console.WriteLine("----------------------------------");
            }
        }

        // Method tambahan untuk mengambil list (untuk keperluan looping di Main)
        public List<Orang> GetDaftarOrang()
        {
            return _daftarOrang;
        }
    }

  


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

            // --- SOAL 5 ---
            Console.WriteLine();
            Orang contohOrang = new SiswaSD("Siswa Diyan", 9, "3 SD");
            contohOrang.Aktivitas();
            Console.WriteLine();

            // d. Tampilkan semua data
            sekolahMaju.DaftarOrang();

            // e. Demonstrasikan polymorphism
            Console.WriteLine();
            // Meski di-loop sebagai tipe 'Orang', sistem akan memanggil aktivitas sesuai wujud aslinya
            foreach (Orang orang in sekolahMaju.GetDaftarOrang())
            {
                orang.Aktivitas();
            }

            // f. Panggil method khusus
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