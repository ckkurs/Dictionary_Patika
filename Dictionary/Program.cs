using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
           //Dictionary verileri anahtar değer olarak tutar key=value;

           Dictionary<int,string> kullanıcılar =new Dictionary<int, string>();
             
            kullanıcılar.Add(10,"Ayşe Yılmaz");
            kullanıcılar.Add(12,"Ahmet Yılmaz");
            kullanıcılar.Add(18,"Deniz Arda");
            kullanıcılar.Add(20,"Özcan Coşar");

            //Dizinin elemanlarına erişim
            Console.WriteLine("*****Elemanlarına Erişim******");
            Console.WriteLine(kullanıcılar[12]);//12 keyine anahtarına sahip elemanı getir

            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }
             Console.WriteLine("*****Count******");
            //Count:
            Console.WriteLine(kullanıcılar.Count);

            Console.WriteLine("*****Contains******");
            //Contains
            //12 anahtarına sahip eleman var mı
            //zikriye ürkmez valuesne sahip eleman var mı
            Console.WriteLine(kullanıcılar.ContainsKey(10));
            Console.WriteLine(kullanıcılar.ContainsValue("Zikriye Ürkmez"));

            Console.WriteLine("*****Remove******");
            //Remove
            //Eleman çıkarma
            kullanıcılar.Remove(12);

            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }

            //Keys
            Console.WriteLine("*****Keys******");

            foreach (var item in kullanıcılar.Keys)
            {
                Console.WriteLine(item);
            }
            //Values 
            Console.WriteLine("*****Values******");

            foreach (var item in kullanıcılar.Values)
            {
                Console.WriteLine(item);
            }





            


        }
    }
}
