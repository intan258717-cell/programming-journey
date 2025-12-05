using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRALTIK_5._8_INTAN_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                // --- Blok Proses yang akan diulang ---
                Console.WriteLine("==============================");
                Console.WriteLine("Masukkan nama Anda: ");
                string nama = Console.ReadLine();
                Console.WriteLine("Halo, {nama}! Proses telah selesai.")
                // -------------------------------
                // Pertanyaan untuk Mengulang 
                Console.Write("Apakah Anda ingin mengulang lagi? (ya/tidak): ");
                ulangPilihan = Console.ReadLine().ToLower(); // Mengambil input dan mengubah ke huruf kecil

                Console.WriteLine(); // Baris kosong untuk kerapiaan

                // Kondisi diperiksa di akhir: Ulangi selama pengguna mengetik "ya"
            } while (ulangPilihan == "ya");
            Console.WriteLine("Terima kasih. Program selesai.");
            }
        }
    }
}
