// NAMA       : AWAL NUR LINDA
// NIM        : 222410102034
// PRODI      : TEKNOLOGI INFORMASI
// MATAKULIAH : PEMROGRAMAN BERORIENTASI OBYEK
// KELAS      : A
// TUGAS 1 PBO A PRAKTIKUM

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DetailProcessor;
using System.Diagnostics;
using DetailVga;
using DetailJawaban;

namespace DetailJawaban
{
    public class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Vivobook(); // Variabel laptop1 bertipe data Laptop dengan objek Vivobook
            laptop1.vga = new NVidia(); // Variabel laptop1 yang menggunakan Vga NVidia
            laptop1.processor = new CoreI5(); // Variabel laptop1 yang menggunakan processor Core i5

            Laptop laptop2 = new IdeaPad(); // Variabel laptop2 bertipe data Laptop dengan objek Ideapad
            laptop2.vga = new DetailVga.AMD(); // Variabel laptop2 yang menggunakan Vga AMD 
            laptop2.processor = new Ryzen(); // Variabel laptop2 yang menggunakan processor Ryzen

            Predator predator = new Predator(); // Variabel predator bertipe data Predator dengan objek Predator
            predator.vga = new DetailVga.AMD(); // Variabel predator yang menggunakan Vga AMD
            predator.processor = new CoreI7(); // Variabel predator yang menggunakan processor Core i7

            //// SOAL NO. 1 (Menjalankan method LaptopDinyalakan() dan LaptopDimatikan() pada laptop2)
            laptop2.LaptopDinyalakan(); // Menjalankan method LaptopDinyalakan() pada laptop2
            laptop2.LaptopDimatikan(); // Menjalankan method LaptopDimatikan() pada laptop2

            //// SOAL NO. 2 (Menjalankan method Ngoding() pada laptop1)
            laptop1.Ngoding(); //// Memanggil method pada anak (child)
            //// Akan terjadi error karena method Ngoding() berada di kelas Vivobook (child).
            //// Sedangkan, yang dipanggil pada soal tersebut kelas Laptop (parent).
            //// Jadi, sifat anak (child) tidak bisa diwariskan ke orang tua (parent).

            //// ALTERNATIF PERTAMA UNTUK NO. 2 AGAR TIDAK TERJADI ERROR
            //Vivobook laptop1 = new Vivobook(); //// Variabel laptop1 bertipe data Vivobook dengan objek Vivobook
            //laptop1.Ngoding(); //// Memanggil method Ngoding()

            //// SOAL NO. 3 (Menampilkan spesifikasi yang digunakan laptop1)
            laptop1.Spesifikasi(); // Menjalankan method Spesifikasi() pada laptop1

            //// SOAL NO.4 (Menjalankan method BermainGame() pada Predator) 
            predator.BermainGame(); // Menjalankan method BermainGame() pada predator

            //// SOAL NO. 5 (Menjalankan method BermainGame() pada acer)
            ACER acer = new Predator(); // Variabel acer bertipe data ACER dengan objek Predator
            acer.BermainGame(); // Menjalankan method BermainGame() pada acer
            //// Akan terjadi error karena method BermainGame() berada di kelas Predator (child).
            //// Sedangkan, yang dipanggil pada soal tersebut kelas ACER (parent).
            //// Jadi, sifat anak (child) tidak bisa diwariskan ke orang tua (parent).

            //// ALTERNATIF PERTAMA UNTUK NO. 5 AGAR TIDAK TERJADI ERROR
            //Predator acer = new Predator(); // Variabel acer bertipe data Predator dengan objek Predator
            //acer.BermainGame();

        }
    }
}

namespace DetailProcessor
{
    class Processor // Parent class yang bernama Processor
    {
        public string merk;
        public string tipe;
    }

    class Intel : Processor // Child class dari Processor
    {
        public Intel()
        {
            base.merk = "Intel"; // Inheritance property dari parent class
        }
    }

    class CoreI3 : Intel // Child class dari Intel
    {
        public CoreI3()
        {
            base.tipe = "Core i3"; // Inheritance property dari parent class
        }
    }

    class CoreI5 : Intel // Child class dari Intel
    {
        public CoreI5()
        {
            base.tipe = "Core i5"; // Inheritance property dari parent class
        }
    }

    class CoreI7 : Intel
    {
        public CoreI7() // Child class dari Intel
        {
            base.tipe = "Core i7"; // Inheritance property dari parent class
        }
    }

    class AMD : Processor // Child class dari Processor
    {
        public AMD()
        {
            base.merk = "AMD"; // Inheritance property dari parent class
        }
    }

    class Ryzen : AMD // Child class dari AMD
    {
        public Ryzen()
        {
            base.tipe = "RYZEN"; // Inheritance property dari parent class
        }
    }

    class Athlon : AMD // Child class dari AMD
    {
        public Athlon()
        {
            base.tipe = "ATHLON"; // Inheritance property dari parent class
        }
    }
}

namespace DetailVga
{
    class Vga // Parent class yang bernama Vga
    {
        public string merk;
    }

    class NVidia : Vga // Child class dari Vga
    {
        public NVidia()
        {
            base.merk = "NVidia"; // Inheritance property dari parent class
        }
    }

    class AMD : Vga // Child class dari Vga
    {
        public AMD()
        {
            base.merk = "AMD"; // Inheritance property dari parent class
        }
    }
}

class Laptop // Parent class yang bernama Laptop
{
    public string merk;
    public string tipe;
    public Vga vga;
    public Processor processor;

    public void LaptopDinyalakan() // Method LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} menyala");
    }
    public void LaptopDimatikan() // Method LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} mati");
    }

    // ALTERNATIF KEDUA UNTUK NO. 2 AGAR TIDAK TERJADI ERROR
    //public void Ngoding() // Method Ngoding()
    //{
    //    Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    //}

    public void Spesifikasi() // Method Spesifikasi
    {
        Console.WriteLine($"Spesifikasi dari laptop {merk} {tipe} tersebut diantaranya adalah Vga bermerk {vga.merk} dan processor bermerk {processor.merk} dengan tipe {processor.tipe}");
    }
}

class ASUS : Laptop // Child class dari Laptop
{
    public ASUS()
    {
        base.merk = "ASUS"; // Inheritance property dari parent class
    }
}

class ROG : ASUS // Child class dari ASUS
{
    public ROG()
    {
        base.tipe = "ROG"; // Inheritance property dari parent class
    }
}

class Vivobook : ASUS // Child class dari ASUS
{
    public Vivobook()
    {
        base.tipe = "Vivobook"; // Inheritance property dari ASUS
    }
    public void Ngoding() // Method Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class ACER : Laptop // Child class dari Laptop
{
    public ACER()
    {
        base.merk = "ACER"; // Inheritance property dari parent class
    }

    //// ALTERNATIF CARA KEDUA UNTUK NO.5 AGAR TIDAK TERJADI ERROR
    //public void BermainGame() // Method BermainGame()
    //{
    //    Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
    //}
}

class Swift : ACER // Child class dari ACER
{
    public Swift()
    {
        base.tipe = "Swift"; // Inheritance property dari parent class
    }
}

class Predator : ACER // Child class dari ACER
{
    public Predator()
    {
        base.tipe = "Predator"; // Inheritance property dari parent class
    }
    public void BermainGame() // Method BermainGame()
    {
        Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
    }
}

class Lenovo : Laptop // Child class dari Lenovo
{
    public Lenovo()
    {
        base.merk = "Lenovo"; // Inheritance property dari parent class
    }
}

class IdeaPad : Lenovo // Child class dari Lenovo
{
    public IdeaPad()
    {
        base.tipe = "IdeaPad"; // Inheritance property dari parent class
    }
}

class Legion : Lenovo // Child class dari Lenovo
{
    public Legion()
    {
        base.tipe = "Legion"; // Inheritance property dari parent class
    }
}
