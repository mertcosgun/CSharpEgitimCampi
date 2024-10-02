using System;

namespace _02_Variables
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            #region Double Variables

            // double number;
            // number = 3.14;
            // Console.WriteLine(number);

            // Console.WriteLine("***** Fiyat Listesi *****");
            // Console.WriteLine();

            // double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            // applePrice = 14.85;
            // orangePrice = 20.95;
            // strawberryPrice = 45;
            // potatoPrice = 9.75;
            // tomatoPrice = 6.88;

            // Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " ₺");
            // Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " ₺");
            // Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " ₺");
            // Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " ₺");
            // Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " ₺");
            // double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            // appleGram = 1.245;
            // orangeGram = 2.650;
            // strawberryGram = 0.750;
            // potatoGram = 4.859;
            // tomatoGram = 3.745;

            // double appleTotalPrice = applePrice * appleGram;
            // double orangeTotalPrice = orangePrice * orangeGram;
            // double strawberryTotalPrice = strawberryPrice * strawberryGram;
            // double potatoTotalPrice = potatoPrice * potatoGram;
            // double tomatoTotalPrice = tomatoPrice * tomatoGram;

            // Console.WriteLine();
            // Console.WriteLine($"Alıanan Ürün: Elma - Birim Fiyatı: {applePrice} - Gramaj: {appleGram} - Toplam Tutar: {appleTotalPrice}₺");
            // Console.WriteLine($"Alıanan Ürün: Portakal - Birim Fiyatı: {orangePrice} - Gramaj: {orangeGram} - Toplam Tutar: {orangeTotalPrice}₺");
            // Console.WriteLine($"Alıanan Ürün: Çilek - Birim Fiyatı: {strawberryPrice} - Gramaj: {strawberryGram} - Toplam Tutar: {strawberryTotalPrice}₺");
            // Console.WriteLine($"Alıanan Ürün: Patates - Birim Fiyatı: {potatoPrice} - Gramaj: {potatoGram} - Toplam Tutar: {potatoTotalPrice}₺");
            // Console.WriteLine($"Alıanan Ürün: Domates - Birim Fiyatı: {tomatoPrice} - Gramaj: {tomatoGram} - Toplam Tutar: {tomatoTotalPrice}₺");

            // Console.WriteLine();
            // Console.WriteLine();
            // double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            // Console.WriteLine("---- Ödenmesi Gereken Tutar: " + shoppingTotalPrice + " ₺");

            #endregion

            #region Char Variables

            // char symbol;
            // symbol = 'a';
            // Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri - String Değerler

            /*
            Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            Console.WriteLine();

            string passengerName,
                passengerSurname,
                passengerDistrict,
                passengerCity,
                passengerAge,
                passengerIdentityNumber;
            Console.Write("Yolcu Adı: ");
            passengerName = Console.ReadLine();

            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();

            Console.Write("İlçe Bilgisi: ");
            passengerDistrict = Console.ReadLine();

            Console.Write("Şehir Bilgisi: ");
            passengerCity = Console.ReadLine();

            Console.Write("Yolcu Yaş: ");
            passengerAge = Console.ReadLine();

            Console.Write("Yolcu TC Kimlik No: ");
            passengerIdentityNumber = Console.ReadLine();

            Console.WriteLine("---------------------------------------------------------------------------------");

            Console.WriteLine($"Yolcu Tc Kimlik No:  {passengerIdentityNumber} - Yolcu Ad Soyad:  {passengerName} {passengerSurname} {passengerDistrict} / {passengerCity} {passengerAge}");
            */

            #endregion

            #region Veri Girişleri - Integer Değerler ve Dönüşümler

            /*
            int shoesPrice, computerPrice, chairPrice, tvPrice;
            shoesPrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 15000;

            int shoesCount, computerCount, chairCount, tvCount;

            Console.Write("Lütfen aldığınız ayakkabı adetini giriniz: ");
            shoesCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız bilgisayar adetini giriniz: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız sandalye adetini giriniz: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız televizyon adetini giriniz: ");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice +
                             tvCount * tvPrice;
            Console.WriteLine();
            Console.WriteLine($"Toplam Ödeme Tutarı: {totalPrice}");
            */

            #endregion

            #region Veri girişleri - Double değerler ve Dönüşümler

            /*
            double exam1, exam2, exam3, result;
            Console.Write("Lütfen 1. Sınav notunu giriniz: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 2. Sınav notunu giriniz: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 3. Sınav notunu giriniz: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;

            Console.WriteLine();
            Console.WriteLine("Sınav Ortalamanız: " + result);
            */

            #endregion

            #region Veri Girişleri - Char

            /*char gender;
            Console.Write("Lütfen cinsiyet seciniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);
            */

            #endregion
        }
    }
}