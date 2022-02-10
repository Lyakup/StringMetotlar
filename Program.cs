using System;

namespace StringMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string yazi = "CSharp Dersine Hoşgeldiniz";
            string yazi2 = "CSharp";

            Console.WriteLine(yazi.Length);

            Console.WriteLine(yazi.ToUpper());
            Console.WriteLine(yazi.ToLower());

            Console.WriteLine(String.Concat(yazi," Merhaba"));

            Console.WriteLine(yazi.CompareTo(yazi2));
            //true durumunda büyük küçük harf duyarsız , false da ise duyarlı 
            Console.WriteLine(String.Compare(yazi,yazi2,true));

            Console.WriteLine(yazi.Contains(yazi2));
            Console.WriteLine(yazi.EndsWith("Hoşgeldiniz"));
            Console.WriteLine(yazi.StartsWith("Merhaba"));

            Console.WriteLine(yazi.IndexOf("CS"));
            Console.WriteLine(yazi.IndexOf("cs"));
            Console.WriteLine(yazi.LastIndexOf("i"));

            Console.WriteLine(yazi.Insert(14,","));

            Console.WriteLine(yazi + yazi2.PadLeft(30));
            Console.WriteLine(yazi2.PadRight(50,'_'));

            //Console.WriteLine(yazi.Remove(23));
            //Console.WriteLine(yazi.Remove(8,13));

            Console.WriteLine(yazi.Replace("ş","s"));

            Console.WriteLine(yazi.Split(' ')[1]);

            Console.WriteLine(yazi.Substring(7));
            Console.WriteLine(yazi.Substring(0,6));

        }
    }
}
