using System;
using System.Collections.Generic;
using System.Text;

namespace SistemSekolah
{
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

}
