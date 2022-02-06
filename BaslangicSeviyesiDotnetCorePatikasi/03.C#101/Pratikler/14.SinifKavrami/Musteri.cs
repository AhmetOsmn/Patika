class Musteri
{
    private static int musteriSayisi;   // Her zaman değiştirilen son değerini göreceğiz.
    private string Isim;
    private string Soyisim;
    private string TC;

    public Musteri(string isim, string soyisim, string tc)
    {
        Isim = isim;
        Soyisim = soyisim;
        TC = tc;
        musteriSayisi++;
    }

    static Musteri()
    {
        musteriSayisi = 0;
    }

    public static int MusteriSayisi { get => musteriSayisi; set => musteriSayisi = value; }
}