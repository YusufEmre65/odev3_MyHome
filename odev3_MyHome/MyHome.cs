using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_home
{
    public class MyHome
    {
        string isim;
        byte yas;
        string meslek;
        byte boy;
        byte kilo;
        string cinsiyet;

        public MyHome(string name, byte age, string job, byte height, byte weight, bool women)
        {
            isim = name;
            yas = age;
            meslek = job;
            boy = height;
            kilo = weight;

            if (women == true)
            {
                cinsiyet = "Kadın";
            }
            else
            {
                cinsiyet = "Erkek";
            }
        }

        public void bilgileriGoster()
        {
            Console.WriteLine("İsim: " + isim);
            Console.WriteLine("Yaş: " + yas);
            Console.WriteLine("Meslek: " + meslek);
            Console.WriteLine("Boy: " + boy);
            Console.WriteLine("Kilo: " + kilo);
            Console.WriteLine("Cinsiyet: " + cinsiyet);
        }
    }
}