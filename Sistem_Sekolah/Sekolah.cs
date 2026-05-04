using System;

namespace SistemSekolah
{
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

        // mengambil list 
        public List<Orang> GetDaftarOrang()
        {
            return _daftarOrang;
        }
    }
}
