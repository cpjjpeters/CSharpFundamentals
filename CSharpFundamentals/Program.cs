using System;
using System.Collections.Generic;
using System.Globalization;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var Fullname = "Carl Paul Jozef Johannes Peters ";
            Console.WriteLine("Trim '{0}';", Fullname.Trim());
            Console.WriteLine("ToUpper:'{0}'" , Fullname.ToUpper());
            var index = Fullname.IndexOf(' ');
            var Firstname = Fullname.Substring(0, 4);
            Console.WriteLine("Voornaam '{0}'",Firstname);
            var Lastname = Fullname.Substring(index + 1);
            Console.WriteLine("Familienaam '{0}'", Lastname);
            var names = Fullname.Trim().Split(' ');
            foreach (var naam in names)
            {
                Console.WriteLine(naam);
            }
            var NAAM = names[names.Length - 1];
            Console.WriteLine("NAAM='{0}'",NAAM);
            var age = "53";
            int leeftijd = Convert.ToInt32(age);
            Console.WriteLine("Leeftijd= {0}", leeftijd);
            Console.WriteLine("Geboren in {0}", DateTime.Today.Year-leeftijd);
            Console.WriteLine("Geb in 64 geeft "+(1964+leeftijd));
            float price = 26.5f;
            Console.WriteLine(price.ToString("C", CultureInfo.CreateSpecificCulture("nl-NL")));
            Console.WriteLine("currentculture:" +CultureInfo.CurrentCulture);
            Console.WriteLine(CultureInfo.CurrentUICulture.CultureTypes);
            var land=CultureInfo.GetCultureInfoByIetfLanguageTag("nl");
            Console.WriteLine("land="+land);
            //var numbers = new List<int>() { 1, 2, 3, 4 };
            //numbers.Add(1);
            //numbers.AddRange(new int[3] { 5, 6, 7 });

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
        }
    }
}
