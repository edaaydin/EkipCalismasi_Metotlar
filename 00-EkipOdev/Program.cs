namespace _00_EkipOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //46. Bir metot yazın, bir matrisin transpozunu alsın.
            //int[,] matris = { { 3, 5, 7 }, { 2, 4, 6 } };
            //foreach (int i in TranspozAl(matris))
            //    Console.WriteLine(i);


            //47. Bir metot yazın, bir metin içinde en uzun kelimeyi bulsun.
            //string metin = "Bu bir denem metindir ve en uzun kelimeyi bulmaya çalışıyoruz.";
            //string enUzunKelime = EnUzunKelimeyiBul(metin);
            //Console.WriteLine("En uzun kelime: " + enUzunKelime);


            //48. Bir metot yazın, bir string içinde ilk büyük harfi bulsun.
            //string metin = "bu bir örnek metindir";
            //Console.WriteLine(IlkBüyükHarfiBul(metin));


            //50. Bir metot yazın, verilen bir sayı dizisinin ortalamasını döndürsün.
            int[] sayilar1 = { 1, 2, 3, 0, 5, 7 };
            OrtalamaBul(sayilar1);
        }
        //soru1

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sayi1">parametredeki 1. sayı</param>
        /// <param name="sayi2">parametredeki 2. sayı</param>
        /// <returns>parametredeki 1. ve 2. sayının toplamı</returns>
        static int Toplam(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        // soru 2
        static int DiziBuyuk(int[] sayilar)
        {

            int enBuyukSayi = sayilar[0];

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] > enBuyukSayi)
                {
                    enBuyukSayi = sayilar[i];
                }
            }
            return enBuyukSayi;
        }
        // soru3

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sayi">faktöriyeli alınacak sayı</param>
        /// <returns>sayının kendisinden bir önceki sayının faktöriyeliyle çarpımı</returns>
        static int Faktoriyel(int sayi)
        {
            if (sayi == 0)
            {
                return 1;
            }
            else
            {
                return sayi * Faktoriyel(sayi - 1);
            }
        }
        // soru 4

        /// <summary>
        /// 
        /// </summary>
        /// <param name="metin">girilen string metin</param>
        /// <returns>metinin ters dizimiyle eş olması durumu</returns>
        static bool PalindromMu(string metin)
        {
            string tersMetin = "";

            for (int i = metin.Length - 1; i >= 0; i--)
            {
                tersMetin += metin[i];
            }
            return tersMetin == metin;
        }
        //soru 5
        static int Ebob(int sayi1, int sayi2)
        {
            //16 14
            int min = Math.Min(sayi1, sayi2);
            int ebob = 1;

            for (int i = min; i >= 1; i--)
            {
                if (sayi1 % i == 0 && sayi2 % i == 0)
                {
                    ebob = i;
                    break;
                }
            }
            return ebob;

        }
        //soru 6
        static int[] BubbleSort(int[] sayilar)
        {
            for (int i = 0; i < sayilar.Length - 1; i++)
            {
                for (int j = 0; j < sayilar.Length - 1 - i; j++)
                {
                    if (sayilar[j] > sayilar[j + 1])
                    {
                        int yedek = sayilar[j];
                        sayilar[j] = sayilar[j + 1];
                        sayilar[j + 1] = yedek;
                    }
                }
            }
            return sayilar;
        }
        // soru 8
        public static int KacDefa(string metin, char harf)
        {
            metin.ToCharArray();
            int harfToplam = 0;
            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] == harf)
                {
                    harfToplam++;
                }
            }
            return harfToplam;
        }
        //soru 10

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sayilar">çift sayıların ayıklanacağı integer dizisi</param>
        /// <returns>ayıklanan çift sayıların boş listeye eklenip listelenmesi </returns>
        static List<int> BulCiftSayilar(int[] sayilar)
        {
            List<int> ciftSayilar = new List<int>();

            foreach (int sayi in sayilar)
            {
                if (sayi % 2 == 0)
                {
                    ciftSayilar.Add(sayi);
                }
            }
            return ciftSayilar;
        }
        // soru 11
        static int[] NegativeChngZero(int[] sayilar)
        {
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] < 0)
                {
                    sayilar[i] = 0;
                }
            }
            return sayilar;
        }
        // soru 12
        static int[] DiziBirlestir(int[] sayilar1, int[] sayilar2)
        {
            int[] birlesikDizi = new int[sayilar1.Length + sayilar2.Length];
            int index = 0;

            for (int i = 0; i < sayilar1.Length; i++)
            {
                birlesikDizi[index++] = sayilar1[i];
            }

            for (int i = 0; i <= sayilar2.Length; i++)
            {
                birlesikDizi[index++] = sayilar2[i];
            }
            return birlesikDizi;
        }
        //Soru13
        static List<int> TersListe(List<int> sayilarListesi)
        {
            int[] sayilar = sayilarListesi.ToArray();

            int[] tersSayilar = new int[sayilar.Length];

            int index = 0;

            for (int i = sayilar.Length - 1; i >= 0; i--)
            {
                tersSayilar[index] += sayilar[i];
                index++;
            }
            List<int> tersSayilarListesi = new List<int>(tersSayilar);
            return tersSayilarListesi;
        }
        // 14. soru: iki boyutlu bir dizinin tüm elemanlarını toplama
        static int ToplaDizi(int[,] dizi)
        {
            int toplam = 0;
            for (int i = 0; i < dizi.GetLength(0); i++) //  satırın konumu
            {
                for (int j = 0; j < dizi.GetLength(1); j++) // sütunun konumu
                {
                    toplam += dizi[i, j]; // sıra sıra gezerek topluyor
                }
            }
            return toplam;
        }
        //15. soru
        static int[] TekrarEden(int[] sayilar)
        {
            int[] tekrarDizisi = new int[sayilar.Length];

            int index = 0; // yeni dizinin boyutunu hesaplamak için sayaç kuruyoruz.

            for (int i = 0; i <= sayilar.Length; i++)
            {
                bool tekrarEdiyorMu = false; // bayrak yöntemi.aynı değilse döngüye ve aramaya devam et.
                for (int j = 0; j < i; j++)
                {
                    if (sayilar[i] == sayilar[j])
                    {
                        tekrarEdiyorMu = true;
                        break;
                    }
                }
                if (tekrarEdiyorMu) // eğer tekrar ediyorsa
                {
                    tekrarDizisi[index] = sayilar[i];
                    index++;
                }
            }
            Array.Resize(ref tekrarDizisi, index); // sayacımızla belirlediğimiz boyutu aktarıyoruz.
            return tekrarDizisi;
        }

        //soru 16
        static bool AsalMi(int sayi)
        {
            if (sayi <= 1)
            {
                return false; // 1 ve birden küçük sayılar asal değidir.
            }
            for (int i = 2; i < Math.Sqrt(sayi); i++) // sayının karekökünden  küçük olan tamsayılardan birine bölünmemesi o sayının asal olması için yeterlidir.

            {
                if (sayi % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        //soru 17
        static int FibonacciTerimi(int sayi)
        {
            if (sayi <= 1)
            {
                return sayi;
            }
            else
            {
                return FibonacciTerimi(sayi - 1) + FibonacciTerimi(sayi - 2); // 0 ve 1'e ulaşana kadar kendisinden önceki iki sayının toplamını yazdırıyoruz
            }
        }
        //soru 18 (5. soru ile bağlantılı)
        static int Ekok(int sayi1, int sayi2)
        {
            int ebob = Ebob(sayi1, sayi2);

            return (sayi1 * sayi2) / ebob;
        }
        //19. soru

        static int BasamakToplamiRecursive(int sayi)
        {
            if (sayi == 0)
                return 0;
            else
                return sayi % 10 + BasamakToplamiRecursive(sayi / 10);
        }
        //20. soru

        static List<int> PozitifBolenler(int sayi)
        {

            List<int> pozitifBolenler = new List<int>();
            for (int i = 1; i <= sayi; i++)
            {

                if (sayi % i == 0)
                {
                    pozitifBolenler.Add(i);
                }
            }
            return pozitifBolenler;
        }

        //soru22 -  Bir metot yazın, verilen bir sayı dizisinin ortalamasını döndürsün.

        static int Ortalama(int[] a)
        {
            if (a.Length == 0)
            {
                Console.Write("Diziniz Boş");
                return (0);
            }
            int toplam = 0;
            for (int i = 0; i < a.Length; i++)
            {
                toplam += a[i];
            }
            return toplam /= a.Length;
        }

        //soru23
        private static void KelimeSayisi()
        {
            Console.Write("Lutfen Cumlenizi Giriniz : ");
            string Cumle = Console.ReadLine();

            Console.Write("Lutfen karakter yaziniz :");
            char Harf = Convert.ToChar(Console.ReadLine());

            int sayac = 0;

            foreach (char Karakter in Cumle)
            {
                if (Karakter == Harf)
                    sayac++;
            }
            Console.WriteLine($"Cumlede {sayac} kez {Harf} harfi geciyor");
        }
        // soru25 - Bir metot yazın, string içindeki sesli harfleri sayarak döndürsün.

        static int SeslıHarf(string a)
        {
            int sesliHarf = 0;
            if (String.IsNullOrEmpty(a))
            {
                Console.WriteLine("Boş Girmeyiniz");
                return (0);
            }
            else
                a = a.ToLower();
            {
                foreach (char sesli in a)
                {
                    if (sesli == 'a' || sesli == 'e' || sesli == 'ı' || sesli == 'i' || sesli == 'u' || sesli == 'ü' || sesli == 'o' || sesli == 'ö')
                    {
                        sesliHarf++;
                    }

                }
            }
            return sesliHarf;
        }

        //26. soru
        static List<int> FibonacciDizisi(int sayi)
        {
            List<int> fibonacciListesi = new List<int> { 0, 1 };

            if (sayi <= 1)
            {
                return fibonacciListesi.GetRange(0, sayi + 1);
            }

            for (int i = 2; i <= sayi; i++)
            {
                fibonacciListesi.Add(fibonacciListesi[i - 1] + fibonacciListesi[i - 2]);
            }

            return fibonacciListesi;

        }
        //soru27 -  Verilen bir dizi için özyineli bir toplama fonksiyonu yazın 
        static int Toplama(int[] a, int index)
        {
            if (index == a.Length) // eğer  index dizinin boyutuna ulaşırsa ıslemı sonlandır
            {
                return (0);
            }

            return a[index] + Toplama(a, index + 1); // a nın mevcut dızısınde kı elemanı alır sonra kendini cagırıp a nın bır sonrkı indexini alır
        }
        //soru28 -  N elemanlı bir dizi için elemanları sırayla yazdıran özyineli bir metot yazın.

        static int Dizi(int[] a, int index)
        {

            if (index == a.Length) // eğer index dizinin boyutuna ulaşırsa bitiriyoruz
            {
                return (0);
            }
            Console.WriteLine(a[index]); // a nın o ankı indexinde ki elemanı yazdırıyoruz

            return Dizi(a, index + 1); // sonra tekrar çağırıp bu sefer bır sonra kı elemana geçıyoruz
        }

        //soru29 Bir metot yazın, bir sayının tersini (ör. 123 -> 321) hesaplasın.

        static void Tersten(int a)
        {
            for (int i = 0; i < a; i++)
            {

            }
        }
        //soru30 - Bir metot yazın, pascal üçgeninin n. satırını döndürsün.

        static int[] Pascal(int n)
        {
            int[] row = new int[n + 1];
            row[0] = 1; // ilk eleman bastan baslar

            for (int i = 1; i <= n; i++)
            {
                row[i] = row[i - 1] * (n - i + 1) / i;
            }
            return row;
        }

        //soru31 - İki metin arasındaki Hamming mesafesini hesaplayan bir metot yazın.

        static int Hamming(string a1, string a2)
        {

            if (a1.Length != a2.Length) // uzunlukları aynı değilse
            {
                Console.WriteLine("Aynı Uzunlukta Gir!");
                return (0);

            }
            int fark = 0;
            for (int i = 0; i < a1.Length; i++)
            {
                if (a1[i] != a2[i]) // ıkısınıde ı nıncı elemanı bir birine eşit değilse kaç tane fark oldugu bulunur
                {
                    fark++; // eşit olmadıgı durumda buraya girer ve farkı arttır
                }
            }
            return fark; // en sonda kaç tane fark oldugunu gormek ıcın farkı dondururuz
        }

        //soru32 - 0-100 arasındaki tüm asal sayıları bulan bir metot yazın.
        static void SıfırYuzAsal(int a)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine($"Sırasıyla 0 dan 100 e Asal {i}");
                }
            }
        }

        //46. Bir metot yazın, bir matrisin transpozunu alsın.

        static int[,] TranspozAl(int[,] matris)
        {
            int satir = matris.GetLength(0);  // Satır sayısı
            int sutun = matris.GetLength(1);                // Sütun sayısı

            int[,] transpozMatris = new int[sutun, satir];

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    transpozMatris[j, i] = matris[i, j];
                }
            }

            return transpozMatris;
        }

        //47. Bir metot yazın, bir metin içinde en uzun kelimeyi bulsun.
        static string EnUzunKelimeyiBul(string metin)
        {

            string[] kelimeler = metin.Split(' '); // Metni boşluk karakterlerine göre ayırıyoruz.
            string enUzunKelime = "";  // En uzun kelimeyi tutacak bir değişken ve başlangıçta boş bir değer ataması

            foreach (string kelime in kelimeler)
            {
                if (kelime.Length > enUzunKelime.Length) // Eğer mevcut kelime, şu ana kadar bulunan en uzun kelimeden uzunsa, en uzun kelimeyi güncelliyoruz.
                {
                    enUzunKelime = kelime;
                }
            }
            return enUzunKelime;
        }

        //48. Bir metot yazın, bir string içinde ilk büyük harfi bulsun.
        static char IlkBüyükHarfiBul(string metin)
        {
            foreach (char harf in metin)
            {
                if (char.IsUpper(harf))
                {
                    return harf;
                }
            }
            return '-'; // Metinde büyük harf bulunamadıysa, varsayılan olarak bir karakter döndürebiliriz.
        }

        //50. Bir metot yazın, verilen bir sayı dizisinin ortalamasını döndürsün.

        static double OrtalamaBul(int[] dizi1)
        {

            double toplam = 0;

            foreach (int sayi in dizi1)
            {
                toplam += sayi;
            }

            return (double)toplam / dizi1.Length;
        }
    }
}
