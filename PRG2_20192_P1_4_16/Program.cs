using System;

namespace PRG2_20192_P1_4_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" PROGRAM SEGITIGA SIKU-SIKU");
            Console.WriteLine(" a. Hitung Luas Segitiga");
            Console.WriteLine(" b. Hitung Hipotenusa");
            Console.WriteLine(" c. Hitung Keliling");
            Console.WriteLine(" d. Keluar \n");
            Console.Write(" Pilihanmu : ");
            String pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "a":
                    Console.Clear();
                    Luas();
                    break;
                case "b":
                    Console.Clear();
                    Hipotenusa();
                    break;
                case "c":
                    Console.Clear();
                    Keliling();
                    break;
                case "d":
                    Console.Clear();
                    Console.WriteLine(" Menutup Program...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine(" Pilihan tidak valid!!\n");
                    Main(null);
                    break;
            }
        }

        private static void Luas()
        {
            int alas, tinggi, luas;

            Console.WriteLine(" Menghitung Luas");
            Console.Write(" Masukkan Alas   : ");
            alas = Convert.ToInt16(Console.ReadLine());
            Console.Write(" Masukkan Tinggi : ");
            tinggi = Convert.ToInt16(Console.ReadLine());

            luas = (alas * tinggi) / 2;

            Console.WriteLine("\n Luasnya adalah {0}", luas);
            Menu();
        }

        private static void Hipotenusa()
        {
            int a, c, b;

            Console.WriteLine(" Menghitung Hipotenusa");
            Console.Write(" Masukkan Sisi A : ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write(" Masukkan Sisi B : ");
            b = Convert.ToInt16(Console.ReadLine());

            c = (a * a) + (b * b);

            Console.WriteLine("\n Garis Hipotenusa-nya adalah {0:0.00}", Math.Sqrt(c));
            Menu();
        }
        private static void Keliling()
        {
            double sisi1, sisi2, sisi3, keliling;

            Console.WriteLine(" Menghitung Keliling");
            Console.Write(" Masukkan Sisi A : ");
            sisi1 = Convert.ToInt16(Console.ReadLine());
            Console.Write(" Masukkan Sisi B : ");
            sisi2 = Convert.ToInt16(Console.ReadLine());

            sisi3 = (sisi1 * sisi1) + (sisi2 * sisi2);
            sisi3 = Math.Sqrt(sisi3);
            keliling = sisi1 + sisi2 + sisi3;

            Console.WriteLine("\n Sisi C nya adalah {0:0.00}", sisi3);
            Console.WriteLine(" Kelilingnya adalah {0:0.00}", keliling);
            Menu();
        }

        private static void Menu()
        {
            Console.Write("\n Kembali ke menu? [y/t] : ");
            String pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "y":
                    Console.Clear();
                    Main(null);
                    Console.WriteLine("");
                    break;
                case "t":
                    Console.Clear();
                    Console.WriteLine(" Menutup Program...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine(" Inputan tidak valid!! \n");
                    Menu();
                    Console.WriteLine("");
                    break;
            }
        }
    }
}
