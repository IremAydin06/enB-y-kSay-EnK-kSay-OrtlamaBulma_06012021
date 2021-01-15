using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enBüyükSayıEnKüçükSayıOrtlamaBulma_06012021
{
    class Program
    {
        static void Main(string[] args)
        {
            double enKüçükSayi = 0, enBüyükSayi = 0, toplam = 0, ortalama = 0;
            Console.Write("Kaç elemanlı dizi oluşturulsun :"); // kullanıcıdan dizi oluşturması istendi.
            int n = Int32.Parse(Console.ReadLine());
            double[] dizi = new double[n];

            for (int i = 0; i < dizi.Length; i++)  // dizinin tüm elemanlarını döngü ile gezdik.
            {
                Console.Write("Sayı {0}: ", i + 1);
                dizi[i] = Convert.ToDouble(Console.ReadLine());
                toplam += dizi[i];

                if (dizi[i] > enBüyükSayi) // dizinin bu elemanı bulunan en büyük elemandan daha büyükse en büyük sayı o elemandır.
                    enBüyükSayi = dizi[i];

                else if (dizi[i] < enKüçükSayi) // dizinin bu elemanı bulunan en küçük elemandan daha küçükse en küçük sayı o elemandır.
                    enKüçükSayi = dizi[i];
            }
            ortalama = toplam / dizi.Length;

            Console.WriteLine("En Büyük Sayı:" + enBüyükSayi);
            Console.WriteLine("En Küçük Sayı:" + enKüçükSayi);
            Console.WriteLine("Toplam : " + toplam);
            Console.WriteLine("Ortalama : " + ortalama);
            Console.ReadKey();
        }
    }
}
