using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTIK_5._3_INTAN_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inisialisasi variabel untuk menyimpan input
            string inputUser = "";
            Console.WriteLine("Program akan terus berjalan hingga Anda mengetik 'keluar'.");

            // Perulangan selama isi variabel inputUser TIDAK SAMA DENGAN "keluar"
            while (inputUser.ToLower() != "keluar")
            {
                Console.WriteLine("\nKetik sesuatu ( atau 'keluar' .");
                inputUser = Console.ReadLine(); // baca input dari user

                Console.WriteLine("Anda mengetik: " + inputUser);
            }

            Console.WriteLine("\nProgram selesai. Terima kasih!");

        }
    }
}
