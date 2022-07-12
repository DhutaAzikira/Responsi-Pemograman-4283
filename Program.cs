using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih menu aplikasi");
            Console.WriteLine("1. Tambah penjualan");
            Console.WriteLine("2. Tampilkan penjualan");
            Console.WriteLine("3. Keluar");
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Penjualan jual = new Penjualan();
            Console.WriteLine("Tambah data penjualan\n");
            Console.WriteLine("Nota : ");
            jual.nota = Console.ReadLine();
            Console.WriteLine("Tanggal : ");
            jual.tanggal = Console.ReadLine();
            Console.WriteLine("Nama Customer : ");
            jual.nama = Console.ReadLine();
            Console.WriteLine("Jenis Pembayaran [T/K] : ");
            jual.jenis = Console.ReadLine();
            Console.WriteLine("Total nota : ");
            jual.total = Convert.ToInt32(Console.ReadLine()); ;

            daftarPenjualan.Add(jual);
 

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            int nomor = 1;
            foreach (Penjualan data in daftarPenjualan)
            {
                string text = ((data.jenis == "T") ? "Tunai" : "Kredit");
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}", nomor, data.nota, data.tanggal, data.nama, text, data.total);
                nomor++;
            }


            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
