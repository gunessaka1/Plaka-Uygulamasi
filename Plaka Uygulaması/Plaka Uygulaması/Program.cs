using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plaka_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte plaka;
            Console.WriteLine("Plakayı Giriniz:");
            plaka = byte.Parse(Console.ReadLine());
            switch (plaka)
            {
                case 01: Console.Write("Merhaba Adana"); break;
                case 34: Console.Write("Merhaba İstanbul"); break;
                case 48: Console.Write("Merhaba Muğla"); break;
                case 07: Console.Write("Merhaba Antalya"); break;
                case 37: Console.Write("Merhaba Kastamonu"); break;
                case 06: Console.Write("Merhaba Ankara"); break;
                default:Console.WriteLine("Henüz Şehir Bilgisi Girilmedi");break;
            }
            Console.Read();
        }
        
    }
}
