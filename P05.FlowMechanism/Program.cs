using System;

namespace P05.FlowMechanism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanılan 4 tip döngü var
            // 
            // for, while, do while, foreach
            //


            // for döngüsü
            // 
            // for ( ifade1 ; ifade2 ; ifade3)
            //  deyimler
            // 
            // yada
            // for ( ifade1 ; ifade2 ; ifade3)
            // {
            //  deyim1;
            //  deyim2;
            //  deyim3;
            //  ....
            // }

            #region Örnek1
            // Örnek 1 : 1-20 arasındaki sayıların toplamı

            //int toplam = 0;

            //for (int sayi = 1 ; sayi <= 20 ; sayi++)
            //{
            //    toplam = toplam + sayi;
            //}


            //Console.WriteLine("\nSonuç : {0}",toplam);
            #endregion

            #region Örnek2
            // Örnek 2: Değişik yapıda

            //int sayi = 0;

            //for (; sayi < 10; sayi++)
            //{
            //    Console.WriteLine("Sayı : {0}", sayi);
            //}
            #endregion

            #region Örnek3
            // Örnek3: 1den 200 e kadar olan sayılar içinde 3'e tam bölünen ve 5'e tam bölünemeyen sayıların adetlerini ve toplamlarını bulmak-----------------------

            //int adet = 0; // kac tane old. tutacağım
            //int toplam = 0;

            //for (int sayi = 1; sayi <= 200; sayi++)
            //{
            //    if ((sayi % 3 == 0) && (sayi % 5 != 0)) 
            //    {
            //        // ilgili sarta uyan sayı bulundu
            //        Console.WriteLine("Sayı : {0}", sayi);

            //        toplam = toplam + sayi;

            //        adet = adet + 1; ;

            //    }
            //}

            //Console.WriteLine("\n\n {0} adet sayı bulundu.....", adet);
            //Console.WriteLine("\nToplamları : {0}", toplam);
            #endregion

            #region Örnek4
            // 0dan 100e kadar olan sayıları 5er 5er artışlı olacak şekilde ve bir satırda 6 adet sayı yazacak şekilde gösteriniz.Gösterilecek sayılar arasında da görünüm karmaşıklığı azaltmak için biraz boşluk veriniz.
            // a b c d e f
            // g h i j k l
            // .....

            //int satiradet = 0; //satırda yazılacak eleman sayısı

            //for (int sayi = 0; sayi <= 100 ; sayi += 5)
            //{
            //    if (satiradet % 6 == 0) // demekki bir satırı doldurmuşum ..bir alt satıra yazmaya devam edebilirim..
            //    {
            //        Console.WriteLine();
            //    }

            //    Console.Write("{0,3} ",sayi); // db

            //    satiradet++;
            //}

            //Console.WriteLine("\n\nBitti");
            #endregion

            // =========================
            // while döngüsü
            //
            // while(kosul)
            //  deyim
            //
            // yada
            // 
            // while(kosul)
            // {
            //  deyim1;
            //  deyim2;
            //  deyim3;
            //  ....
            // }

            #region Örnek5
            // Örnek : 1 den 50 ye kadar olan sayıları yazdırma---------------------------------

            //int sayi = 1;

            //while (sayi <=50)
            //{
            //    Console.WriteLine("Sayi : {0}", sayi);

            //    sayi++;

            //}

            #endregion

            #region Örnek6
            // Örnek: 100e kadar olan pozitif tek tamsayıların toplamı

            //int sayi = 1;
            //int sonsayi = 100;
            //int toplam = 0;

            //while (sayi <= sonsayi)
            //{
            //    toplam = toplam + sayi;

            //    sayi = sayi + 2;

            //}
            //Console.WriteLine("Pozitif tek sayıların  toplamı : {0}", toplam);

            #endregion

            //-------------------------
            // do while döngüsü
            //
            // do
            //  deyim
            // while (kosul);
            //
            // veya
            // 
            // do
            // {
            //  deyim1;
            //  deyim2;
            //  deyim3;
            //  ....
            // } while (kosul);

            #region Örnek7
            // Örnek: şifre doğru olana kadar-------

            //string sifre;

            //do
            //{
            //    Console.Write("Şifrenizi giriniz : ");

            //    sifre = Console.ReadLine();

            //    sifre = sifre.Trim(); // girilen string değerin baş - sondaki eğer girilmişse boşluk karakterlerini atar kırpar....

            //} while (sifre != "q1w2e3");

            //Console.WriteLine("Doğru şifreyi girdiniz....");

            #endregion


            #region Örnek8
            // sayı tahmin oyunu...

            int tutdeger, girdeger, deneme = 1, toplamdeneme = 10;

            string ayrac = "-----";
            //string ayrac = new string('-', 15);

            Random random = new Random(); // daha sonra bakılacak


            tutdeger = random.Next(10); // 0 ila 10 arasında bir sayı tutacak

            do
            {
                Console.WriteLine("Lütfen sayınızı giriniz    : ");

                girdeger = int.Parse(Console.ReadLine());

                if (tutdeger == girdeger)
                {
                    Console.WriteLine("{0}\nTebrikler...{1}.denemede bildiniz...\n{2}", ayrac, deneme, ayrac);
                    break;
                }
                else if (deneme == toplamdeneme)
                    Console.WriteLine("{0}\n-> Üzgünüm deneme hakkınız bitti. Tahmin etmeniz gereken değer {1} olacaktı.\n{2}", ayrac, tutdeger, ayrac);

                else
                    Console.WriteLine("{0}\n", ayrac);

                deneme++;

            } while (deneme <= toplamdeneme);


            #endregion

            Console.ReadKey();

            //=======================================================================================================

            // Üniv. Vize Final, Ortalama

            //int vizeNot, finalNot;
            //double ortalama;
            //string ayrac = "-------------------";

            //Console.WriteLine("Vize Notu : ");
            //vizeNot = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Final Notu : ");
            //finalNot = Convert.ToInt32(Console.ReadLine());

            //ortalama = (vizeNot * 0.4) + (finalNot * 0.6);


            //if (ortalama >= 88 && ortalama <= 100)
            //{
            //    Console.WriteLine("Ortalamanız : {0} ---> Harf olarak : AA", ortalama);
            //    Console.WriteLine(ayrac);
            //}
            //else if (ortalama >= 70 && ortalama <= 87)
            //{
            //    Console.WriteLine("Ortalamanız : {0} ---> Harf olarak : BA", ortalama);
            //    Console.WriteLine(new string('-', 20));
            //}
            //else
            //{
            //    Console.WriteLine("Ortalamanız : {0} ---> Harf olarak : BB", ortalama);
            //    Console.WriteLine(new string('-', 20));
            //}


            // Kullanıcıdan kullanıcı adı ve şifresi ekrandan alınacak
            // doğru olması durumunda br mesaj yazılacak
            // yanlış olması durumunda da ayrı bir mesaj yazılacaktır.

            //string kulad, kulsifre;

            //Console.WriteLine("Kullanıcı Ad :");
            //kulad = Console.ReadLine();
            //kulsifre = Console.ReadLine();

            //if (kulad == "ümit" && kulsifre == "2512")

            //    Console.WriteLine("OK");

            //else
            //    Console.WriteLine("Not OK");

            // çok basit bir dört işlem

            // iki adet sayı alınacak...küçük bir menüden de habgi işlemin yapılacağı alınacak.. ve sonuç hata mesajlarıyla birlikte yazılacak

            int sayi1, sayi2;
            string islem; // t toplama c çıkarma ç carpma b bolme olsun

            // do-while yapısı
            do
            {
                // aradaki işlemleri yap
                // Menu
                Console.WriteLine("Toplama : t");
                Console.WriteLine("Çıkarma : c");
                Console.WriteLine("Çarpma : ç");
                Console.WriteLine("Bölme : b");

                Console.WriteLine("Seçiminiz : (q-Çıkış)");

                islem = Console.ReadLine();

                Console.WriteLine("Sayi1 : ");
                sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sayi2 : ");
                sayi2 = Convert.ToInt32(Console.ReadLine());
                #region çoklu if yapısı
                //if (islem == "b")
                //{
                //    if (sayi2 != 0) // sayı2nin 0 olup olmadığı kontrolu
                //    {
                //        float sonuc = (float)sayi1 / (float)sayi2;
                //        Console.WriteLine("Sayı1 in Sayı2 ye bölümü {0} dir", sonuc);
                //    }
                //    else
                //        Console.WriteLine("0 a bölüm olmaz");
                //}
                //else if (islem == "t")
                //    Console.WriteLine("Sayı1 ile sayı2nin toplamı {0} dır", sayi1 + sayi2);
                //else if (islem == "ç")
                //    Console.WriteLine("Sayı1 ile sayı2nin çarpımı {0} dır", sayi1 * sayi2);
                //else if (islem == "c")
                //    Console.WriteLine("Sayı1 ile sayı2nin farkı {0} dır", sayi1 - sayi2);
                #endregion

                // switch komutu

                switch (islem)
                {

                    case "t":
                        Console.WriteLine("Sayı1 ile sayı2nin toplamı {0} dır", sayi1 + sayi2);
                        break;

                    case "ç":
                        Console.WriteLine("Sayı1 ile sayı2nin çarpımı {0} dır", sayi1 * sayi2);
                        break;

                    case "c":
                        Console.WriteLine("Sayı1 ile sayı2nin farkı {0} dır", sayi1 - sayi2);
                        break;

                    case "b":
                        if (sayi2 != 0) // sayı2nin 0 olup olmadığı kontrolu
                        {
                            float sonuc = (float)sayi1 / (float)sayi2;
                            Console.WriteLine("Sayı1 in Sayı2 ye bölümü {0} dir", sonuc);
                        }
                        else
                            Console.WriteLine("0 a bölüm olmaz");
                        break;


                }




            } while (islem !="q"); // buradaki kontrol doğru olana kadar.






                Console.ReadKey();











        }
    }
}
