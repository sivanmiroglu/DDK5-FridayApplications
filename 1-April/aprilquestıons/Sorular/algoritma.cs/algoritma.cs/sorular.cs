// See https://aka.ms/new-console-template for more information

#region soru1
//Ekrana 10 defa hello world yazdır
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Hello World");
//}
//Console.Read();
#endregion


#region soru2
//Dışarıdan girilen sayıya kadar olan çift sayıları ekrana yazdı
//Console.WriteLine("Lütfen Sayı Girin");
//int sayi = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i <= sayi; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }

//}
//Console.Read();
#endregion


#region soru3
// Dışarıdan girilen bir sayının rakamlarını tersine çeviren program
//Console.WriteLine("Lütfen sayı giriniz");
//int sayi = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < sayi; sayi--)
//{
//    Console.WriteLine(sayi);
//}
//Console.Read();
#endregion



#region soru4
//Verilen tamsayının sıfır, pozitif ya da negatif olup olmadığını bulan program.
//Console.WriteLine("sayı giriniz");
//int sayi = Convert.ToInt32(Console.ReadLine());
//if(sayi >0)
//{
//    Console.WriteLine("Sayı pozitif");
//}
//else if(sayi<0)
//{
//    Console.WriteLine("sayı negatif");
//}
//else 
//{
//    Console.WriteLine("Sayı 0 a eşit");
//}
//Console.Read();
#endregion



#region soru5
//Girilen fiyatın KDV li halini ( % 18 ) ekrana yazdır.
//Console.WriteLine("Lütfen Fiyat Giriniz");
//int fiyat = Convert.ToInt32(Console.ReadLine());
//if(fiyat <400)
//{
//    Console.WriteLine("Kdv dahil fiyatı : " + (fiyat * 1.18));
//}
//else  if(fiyat >= 400)
//{
//    Console.WriteLine("Fiyata Kdv Dahil değildir"+(fiyat));
//}
//Console.Read();
#endregion



#region soru6
//Üniversite bir dersin başarı notu bir vize bir final sınav notu ile hesaplanır. Vize notunun kat sayısı %30 final notunun kat sayısı %70’dir. 
//    Bir öğrencinin sınavda almış olduğu bu notlar neticesinde ders ortalaması bulun.
//Console.WriteLine("Vize notunu girin");
//double not = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Final notuu girin");
//double not2 = Convert.ToDouble(Console.ReadLine());
//double sonuc = (not * 0.3) + (not2 * 0.7);
//Console.WriteLine("Not :" + sonuc);
//Console.ReadLine();
#endregion


#region soru7
// Kullanıcının girdiği sayının tek mi çift mi olduğunu bulan program
//Console.WriteLine("Lütfen sayı girin");
//int a = Convert.ToInt32(Console.ReadLine());
//if(a %2==0)
//{
//    Console.WriteLine("Sayı Çift");
//}
//else if(a%3==0)
//{
//    Console.WriteLine("Sayı tek");
//}
//Console.Read();
#endregion



#region soru8
//Bir kenar uzunluğu ve o kenara ait yüksekliği girilen üçgenin alanını hesaplayın
//int kenar, yukseklik, alani;

//Console.Write("Kenar uzunluğunu giriniz : ");

//kenar = Convert.ToInt32(Console.ReadLine());

//Console.Write("Yükekliği giriniz : ");

//yukseklik = Convert.ToInt32(Console.ReadLine());

//alani = kenar * yukseklik / 2;

//Console.WriteLine("Üçgenin alanı = " + alani);

//Console.ReadKey();
#endregion



#region soru9
//Girilen bir x sayısının yine girilen bir y sayısına tam bölünüp bölünmediğini ekrana yazdırın.
//Console.WriteLine("x sayısını girin");
//int sayi = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("y sayısını girin");
//int sayi2 = Convert.ToInt32(Console.ReadLine());
//if (sayi % sayi2 == 0)
//{
//    Console.WriteLine("x sayısı y sayısına bölünür");
//}

//else if (sayi % sayi2 == 1)
//    {
//        Console.WriteLine("x sayısı y sayısına bölünmez");
//    }

//Console.Read();
#endregion



#region soru10
//Girlen sayının basamak sayısını bulan program
//Console.WriteLine("sayi girin");
//int sayi = Convert.ToInt32(Console.ReadLine());
//int sayac = 0;
//while (sayi > 0)
//{
//    sayi /= 10;
//    sayac++;
//}
//Console.WriteLine("Girdiginiz sayi " + sayac + " basamaklıdır.");
//Console.ReadLine();
#endregion



#region soru11
//Dışarıdan girilen N sayısına kadar olan asal sayıları bulan program
//int girilen, sayac, kontrol, asal;  // sayi değişkenleri tanımlandı.

//Console.WriteLine("Sayıyı Giriniz: ");  // sayı girilmesi için mesaj yazdırıldı.
//girilen = Convert.ToInt32(Console.ReadLine());  //girilen sayı string den int dönüştürüldü.

//for (kontrol = 2; kontrol <= girilen; kontrol++)   // sayı döngüsü başlatılır girilen sayıya kadar her sayı için asallık işlemi kontrol ettirilir.
//{
//    asal = 1;
//    for (sayac = 2; sayac < kontrol; sayac++)  // her sayı için asal olup olmadığına bakılır. kendisi hariç alt rakamların tamamına bölünerek kalan kontrol edilir.
//    {
//        if (kontrol % sayac == 0)  // kalan sıfır ise sayı asal değildir bu rakam için döngüden çıkılır sayı 1 artırılır.
//        {
//            asal = 0;
//        }
//    }
//    if (asal == 0)
//    {

//    }
//    else
//    {
//        Console.WriteLine(kontrol);  //asal=0 olmadığında sayı asal sayıdır ekrana yazdırılır döngüye tekrar dönülür.
//    }
//}
#endregion



#region soru12
//int[] sayilar = { 14, 15, 19, 12, 17 };

//int buyuk = sayilar[0];
//Console.WriteLine("Dizinin en küçük elemanı = ", (sayilar));
//Console.WriteLine("Dizinin en büyük elemanı = ", (sayilar));
//Console.WriteLine("======================================");

//for (int i = 0; i < sayilar.Length; i++)
//{
//    if (buyuk < sayilar[i])
//    { buyuk = sayilar[i]; }
//}
//return buyuk;

//int kucuk = sayilar[0];

//for (int i = 0; i < sayilar.Length; i++)
//{
//    if (kucuk > sayilar[i])
//    { kucuk = sayilar[i]; }
//    return kucuk;
//}
#endregion



#region soru13
//N elemanlı bir diziyi yedek dizi KULLANMADAN tersine çeviren program.
//int[] dizi = { 5, 6, 9, 12, 15, 7, 3, 20, 14, 36 };
//int gecici;

//for (int i = 0; i < dizi.Length / 2; i++)
//{
//    gecici = dizi[i];
//    dizi[i] = dizi[dizi.Length - i - 1];
//    dizi[dizi.Length - i - 1] = gecici;
//}
//foreach (int sayi in dizi)
//{
//    Console.WriteLine(sayi);
//}
//Console.ReadKey();
#endregion



#region soru 14
//Dışarıdan girilen bir cümledeki kelime sayısını bulan program.
//Console.WriteLine("Lütfen bir metin giriniz");
//    string data =( Console.ReadLine());
//Console.WriteLine(data.Length);
//Console.ReadLine();
#endregion


#region soru15
//Dışarıdan girilen en az 5 basamaklı sayının ilk ve son basamakları arasındaki sayıların toplamını bulan program.


//Console.WriteLine("Lütfen bir sayı giriniz");
//string sayi = Console.ReadLine();

//int sayi = Convert.ToInt32(Console.ReadLine());

//string yeniSayi = sayi.Substring(1, sayi.Length - 2);


//int toplam = 0;
//foreach (var item in yeniSayi)
//{
//    toplam = toplam + Convert.ToInt32(item.ToString());
//}

//Console.WriteLine("Toplam: " + toplam);


//int sayac = 0;
//int toplam = 0;

//while (sayi % 10 != 0)
//{
//    toplam = toplam + (sayi % 10);
//    sayac++;
//    sayi = (sayi - (sayi % 10)) / 10;


//}

//Console.WriteLine("Sayıların toplamı: " + toplam);
//Console.WriteLine("Sayaç: " + sayac);
//Console.Read();


#endregion


#region soru16
//Dışarıdan girilen sayının faktöriyelini hesapla
//Console.WriteLine("Sayı girin");
//double sayi = Convert.ToInt32(Console.ReadLine());
//double faktoriyel = 1;

//for (int i = 1; i <= sayi; i++)
//{
//    faktoriyel = faktoriyel * i;
//}

//Console.WriteLine("{0} sayısının faktöriyeli={1}", sayi, faktoriyel);
//Console.ReadKey();
#endregion


#region soru17

//for (int i = 1; i < 15; i++)
//{
//    Console.Write(i);



//    if (i == 1 || i == 3 || i == 6 || i == 10)
//    {
//        Console.WriteLine("");
//    }



//}

#endregion


#region soru18
//for (int i = 1; i <= 5; i++)
//{
//    int sayac = 1;
//    for (int j = 1; sayac <= 5; j = j + i)
//    {
//        Console.Write(j + i);
//        sayac++;



//    }



//    Console.WriteLine("");

//}
#endregion