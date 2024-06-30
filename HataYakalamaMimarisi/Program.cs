using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HataYakalamaMimarisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Try-Catch

            ////try => hata çıkma potansiyeli olan kısmı try içerisine almalıyız
            ////try tek başına çalışamaz
            ////catch => eğer hata çıkarsa catch çalışır
            ////try-catch programın hata ile durmasına engel olur

            //try
            //{
            //    Console.WriteLine("Lütfen 1.sayıyı giriniz.");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Lütfen 2.sayıyı giriniz.");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    int sonuc = sayi1 / sayi2;

            //    Console.WriteLine("Bölüm = " + sonuc);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Hata Oluştu.");
            //    //Console.WriteLine(ex.StackTrace);
            //    //Console.WriteLine(ex.Message);
            //}

            //Console.WriteLine("Hata yakalama alanı dışı bölge");

            #endregion

            #region Özel Hata Yakalama

            //try
            //{
            //    Console.WriteLine("Lütfen 1.sayıyı giriniz.");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Lütfen 2.sayıyı giriniz.");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    int sonuc = sayi1 / sayi2;

            //    Console.WriteLine("Bölüm = " + sonuc);
            //}
            //catch(FormatException)
            //{
            //    Console.WriteLine("Lütfen sadece sayısal veri giriniz.");
            //}
            //catch(DivideByZeroException)
            //{
            //    Console.WriteLine("Sıfıra bölme tanımsızdır.");
            //}

            #endregion

            #region Mimari OLuşturma

            //try
            //{
            //    Console.WriteLine("Lütfen 1.sayıyı giriniz.");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Lütfen 2.sayıyı giriniz.");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    int sonuc = sayi1 / sayi2;

            //    Console.WriteLine("Bölüm = " + sonuc);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Sıfıra bölme tanımsızdır.");
            //}
            //catch (FormatException hata)
            //{
            //    Console.WriteLine("Lütfen sadece sayısal veri giriniz.");
            //    Console.WriteLine(hata.Message);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Beklenmeyen bir hata oluştu.");
            //}
            //Console.WriteLine("Hata yakalama alanı dışı bölge.");

            #endregion

            #region Try-Catch-Finally

            try
            {
                Console.WriteLine("Lütfen 1.sayıyı giriniz.");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Lütfen 2.sayıyı giriniz.");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                int sonuc = sayi1 / sayi2;

                Console.WriteLine("Bölüm = " + sonuc);
            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen sadece sayısal veri giriniz.");
            }
            finally
            {
                Console.WriteLine("Finally Çalıştı.");
            }
            Console.WriteLine("Hata yakalama alanı dışı bölge");

            #endregion

        }
    }
}

