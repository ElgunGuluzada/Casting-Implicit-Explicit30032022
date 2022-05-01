using System;
using Casting_Implicit_Explicit30032022.Models;

namespace Casting_Implicit_Explicit30032022
{
    internal class Program
    {
        #region Task1
        //enum Currency
        //{
        //    USD = 1, Euro, Try
        //}
        #endregion

        static void Main(string[] args)
        {


            //1.1 Currecy enum

            //- Usd - dollar
            //- Eur - yevro
            //- Try - türk lirası

            //1.2 Program class
            //- Exchange() - bu method parametr olaraq bir Enum tipindən obyekt qəbul edəcək birdə double tipindən azn,
            //method daxilində ilk olaraq yoxlamaq lazımdır ki gələn Enum obyekti Currecy enumıdırmı daha sonra daha sonra
            //hansı valyuta göndərilibsə göndərilən azn-i həmin valyutaya uyğun konvertasiya edib geriyə qaytaracaq.
            //Məsələn: method-a parametr olaraq azn dəyəri 2 göndərildisə və valyuta usd göndərildisə geriyə 2 * 0.59 = 1.18 qaytarılmalıdır.


            //2. Kelvin ve Celsius(selsi) adli iki temperaturu gosteren klasslarimiz var ve Degree adli property-leri var.
            //Celcius uchun implicit operatorunu yazmaginizi isteyirem.(0C= 273K)

            #region Task1
            //Azn: Console.Write("Manat daxil edin: ");
            //    double valyuta = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine($" 1: Dollar\n 2: Euro\n 3: Try");
            //    Console.WriteLine($"Choose Your: ");
            //    int input = Convert.ToInt32(Console.ReadLine());
            //    Console.Clear();
            //    switch (input)
            //    {
            //        case 1:
            //            Console.WriteLine(Exchange(Currency.USD, valyuta));
            //            goto Azn;
            //        case 2:
            //            Console.WriteLine(Exchange(Currency.Euro, valyuta));
            //            goto Azn;
            //        case 3:
            //            Console.WriteLine(Exchange(Currency.Try, valyuta));
            //            goto Azn;
            //        default: goto Azn;
            //    }
            #endregion

            Celsius c = new Celsius(42);
            Kelvin k = c;
            Console.WriteLine(k.Degree);
        }
        #region Task1
        //static double Exchange(Enum obj, double Azn)
        //{
        //    double result = 0;
        //    if (obj is Currency)
        //    {
        //        switch (obj)
        //        {
        //            case Currency.USD:
        //                result = Azn * 0.59;
        //                break;
        //            case Currency.Euro:
        //                result = Azn * 0.53;
        //                break;
        //            case Currency.Try:
        //                result = Azn * 8.74;
        //                break;
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Yanlis enum secilib");
        //    }
        //    return result;
        //}

        #endregion

    }
}
