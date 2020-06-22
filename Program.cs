using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuggasDelapan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 - Inheritance, Polymorphsim, Abstraction & Collection";

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "082-134-553";
            karyawanTetap.Nama = "Tsunade";
            karyawanTetap.GajiBulanan = 3500000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "087-388-265";
            karyawanHarian.Nama = "Orocimaru";
            karyawanHarian.UpahPerJam = 20000;
            karyawanHarian.JumlahJamKerja = 8;

            Sales sales = new Sales();
            sales.Nik = "088-303-406";
            sales.Nama = "Jiraya";
            sales.JumlahPenjualan = 30;
            sales.Komisi = 40000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. NIK: {1}, Nama: {2}, Gaji: {3}", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                noUrut++;
            }

            Console.ReadKey();
        }
    }
}
