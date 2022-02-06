using System;
using System.Collections.Generic;

namespace _17.ToDoUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> takimUyeleri = new Dictionary<int, string>();
            takimUyeleri.Add(1, "Ahmet Sezgin");
            takimUyeleri.Add(2, "Mert Altın");
            takimUyeleri.Add(3, "Ulaş Avil");
            takimUyeleri.Add(4, "Kürşat Gürler");
            takimUyeleri.Add(5, "Burak Güney");
            takimUyeleri.Add(6, "Emre Doran");

            Board board = new Board();
            board.ToDoList.Add(new Kart("Deneme1", "Deneme 1 kartı", takimUyeleri[1], Buyuklukler.XS, Lines.todo));
            board.ToDoList.Add(new Kart("Deneme2", "Deneme 2 kartı", takimUyeleri[2], Buyuklukler.S, Lines.todo));
            board.ToDoList.Add(new Kart("Deneme3", "Deneme 3 kartı", takimUyeleri[3], Buyuklukler.M, Lines.todo));

            BoardManager boardManager = new BoardManager(board);
            KartManager kartManager = new KartManager(board);

            while (true)
            {
                ShowMenu();
                int menuSecim = int.Parse(Console.ReadLine());
                if (menuSecim == 0)
                {
                    System.Console.WriteLine("Çıkış yapılıyor.");
                    break;
                }
                else if (menuSecim == 1)
                {
                    boardManager.KartlariListele();
                }
                else if (menuSecim == 2)
                {
                    System.Console.Write("Başlık giriniz: ");
                    string kartBaslik = Console.ReadLine();
                    System.Console.Write("İçerik giriniz: ");
                    string kartIcerik = Console.ReadLine();
                    System.Console.Write("Büyüklük seçiniz -> XS(1),S(2),M(3),L(4),XL(5): ");
                    int kartBuyuklukSecim = int.Parse(Console.ReadLine());
                    System.Console.Write("Kisi ID'sini giriniz: ");
                    int kartKisi = int.Parse(Console.ReadLine());
                    if (takimUyeleri.ContainsKey(kartKisi))
                    {
                        Kart newKart = new Kart(kartBaslik, kartIcerik, takimUyeleri[kartKisi], (Buyuklukler)kartBuyuklukSecim, Lines.todo);
                        kartManager.KartEkle(newKart);
                    }
                    else
                    {
                        System.Console.WriteLine("Hatalı giriş yaptınız, menüye dönüyorsunuz..");

                    }
                }
                else if (menuSecim == 3)
                {
                    while (true)
                    {
                        System.Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
                        System.Console.Write("Lütfen kart başlığını yazınız: ");
                        string kartBasligi = Console.ReadLine();
                        Kart arananKart = boardManager.KartlardaAra(kartBasligi);
                        if (arananKart == null)
                        {
                            System.Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız: ");
                            System.Console.WriteLine(" * İşlemi sonlandırmak için : (1)");
                            System.Console.WriteLine(" * Yeniden denemek için : (2 vb.)");
                            int silmeSecim = int.Parse(Console.ReadLine());
                            if (silmeSecim == 1)
                            {
                                System.Console.WriteLine("Silme işlemi sonlanıyor..");
                                break;
                            }
                        }
                        else
                        {
                            kartManager.KartSil(arananKart);
                            break;
                        }
                    }
                }
                else if (menuSecim == 4)
                {
                    while (true)
                    {
                        System.Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
                        System.Console.Write("Lütfen kart başlığını yazınız: ");
                        string kartBasligi = Console.ReadLine();
                        Kart arananKart = boardManager.KartlardaAra(kartBasligi);
                        if (arananKart == null)
                        {
                            System.Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız: ");
                            System.Console.WriteLine(" * İşlemi sonlandırmak için : (1)");
                            System.Console.WriteLine(" * Yeniden denemek için : (2 vb.)");
                            int silmeSecim = int.Parse(Console.ReadLine());
                            if (silmeSecim == 1)
                            {
                                System.Console.WriteLine("Taşıma işlemi sonlanıyor..");
                                break;
                            }
                        }
                        else
                        {
                            System.Console.WriteLine("Bulunan Kart Bilgileri");
                            System.Console.WriteLine("**********************************");
                            kartManager.KartiGoster(arananKart);
                            System.Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: ");
                            System.Console.WriteLine("(1) TODO");
                            System.Console.WriteLine("(2) IN PROGRESS");
                            System.Console.WriteLine("(3) DONE");
                            int secim = int.Parse(Console.ReadLine());
                            if (secim == 1 || secim == 2 || secim == 3)
                            {
                                Lines eski = arananKart.Line;
                                Lines yeni = (Lines)secim;
                                arananKart.Line = yeni;
                                kartManager.KartTasi(arananKart, eski, yeni);
                                System.Console.WriteLine("Taşıma işlemi başarılı");
                                break;
                            }
                            else
                            {
                                System.Console.WriteLine("Hatalı seçim yaptınız.");
                                break;
                            }
                        }
                    }
                }
                else
                {
                    System.Console.WriteLine("Geçersiz seçim");
                }

            }
        }

        static void ShowMenu()
        {
            System.Console.WriteLine("-----------------------------------");
            System.Console.WriteLine("| MENÜ                            |");
            System.Console.WriteLine("-----------------------------------");
            System.Console.WriteLine("| (1) Board Listelemek            |");
            System.Console.WriteLine("| (2) Board'a Kart Eklemek        |");
            System.Console.WriteLine("| (3) Board'dan Kart Silmek       |");
            System.Console.WriteLine("| (4) Kart Taşımak                |");
            System.Console.WriteLine("| (0) Çıkış                       |");
            System.Console.WriteLine("-----------------------------------");

        }
    }
}
