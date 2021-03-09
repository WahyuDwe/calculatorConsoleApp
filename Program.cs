using System;

namespace Calculator
{
    class Program
    {
        // function for calculating entered value
        static int tambah(int a, int b)
        {
            return a + b;
        }
        static int kurang(int a, int b)
        {
            return a - b;
        }
        static int kali(int a, int b)
        {
            return a * b;
        }
        static double bagi(double a, double b)
        {
            return a / b;
        }

        // Function for the enter value 
        static int bilanganPertama()
        {
            Console.Write("Masukan Bilangan Pertama : ");
            return int.Parse(Console.ReadLine());
        }
        static int bilanganKedua()
        {
            Console.Write("Masukan Bilangan Kedua : ");
            return int.Parse(Console.ReadLine());
        }

        static void menu()
        {
            Console.WriteLine("Pilih menu calculator\n");
            Console.WriteLine("1.Penambahan");
            Console.WriteLine("2.Pengurangan");
            Console.WriteLine("3.Perkalian");
            Console.WriteLine("4.Pembagian");
        }

        static char choose()
        {
            Console.Write("Masukan Pilihan [1..4] : ");
            return Convert.ToChar(Console.ReadLine());
        }

        static void close()
        {
            Console.WriteLine();
            Console.WriteLine("Tekan Sembarang Untuk Keluar");
            Console.Read();
        }

        static void Main(string[] args)
        {
            menu();
            char pilihan = choose();
            Console.WriteLine();
            if (pilihan < '1' || pilihan > '4')
            {
                Console.Write("Maaf, menu yang anda masukan tidak tersedia");
            }

            if (pilihan == '1')
            {
                int bil1 = bilanganPertama();
                int bil2 = bilanganKedua();
                Console.WriteLine("Hasil Penambahan : {0} + {1} = {2}", bil1, bil2, tambah(bil1, bil2));
            }
            else if (pilihan == '2')
            {
                int bil1 = bilanganPertama();
                int bil2 = bilanganKedua();
                Console.WriteLine("Hasil Pengurangan : {0} - {1} = {2} {0.00}", bil1, bil2, kurang(bil1, bil2));
            }
            else if (pilihan == '3')
            {
                int bil1 = bilanganPertama();
                int bil2 = bilanganKedua();
                Console.WriteLine("Hasil Perkalian : {0} * {1} = {2}", bil1, bil2, kali(bil1, bil2));
            }
            else if (pilihan == '4')
            {
                int bil1 = bilanganPertama();
                int bil2 = bilanganKedua();
                Console.WriteLine("Hasil Pembagian : {0} / {1} = {2}", bil1, bil2, bagi(bil1, bil2));
            }
            close();
        }
    }
}
