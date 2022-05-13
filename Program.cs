using System;

namespace CampIntro
{
    class Program
    {
        //Aynen derste yaptığımız MyList gibi siz de kendi Dictonary sınıfınızı yazınız. (MyDictionary)

        //Sadece ekleme(Add) metodunu yazınız
        static void Main(string[] args)
        {
            MyDictionary<string> myDictionary = new MyDictionary<string>();
            myDictionary.Add("Computer");
            myDictionary.Add("Mouse");
            myDictionary.Add("Switch");
            myDictionary.Add("Laptop");
            myDictionary.Add("Airpods");


            Console.WriteLine(myDictionary.Count);

        }
    }
}

