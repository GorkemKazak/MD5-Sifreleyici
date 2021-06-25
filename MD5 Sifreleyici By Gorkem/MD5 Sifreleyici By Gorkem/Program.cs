using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace MD5_Sifreleyici_By_Gorkem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("MD5 Şifreleyici By Gorkem");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Lütfen Şifrelemek istediğiniz metni girin: ");
            byte[] girdi = Encoding.UTF8.GetBytes(Console.ReadLine());       
            Console.WriteLine();
       
            MD5CryptoServiceProvider serviceProvider = new MD5CryptoServiceProvider();
            serviceProvider.ComputeHash(girdi);

            StringBuilder sifreli = new StringBuilder();
            foreach(byte s in girdi)
            {
                sifreli.Append(s.ToString("x2").ToLower());
            }

            Console.WriteLine("Şifreleme başarılı: "+sifreli);

            Console.ReadLine();
        }
    }
}
