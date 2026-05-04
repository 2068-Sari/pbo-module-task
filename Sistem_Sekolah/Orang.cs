using System;

namespace SistemSekolah
{
    public class Orang
    {
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
                    umur = 0;
            }
        }

        public Orang(string nama, int umur)
        {
            Nama = nama;
            Umur = umur;
        }

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

}
