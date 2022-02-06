class Calisan
{

    public Calisan(string ad, string soyad, int no, string departman)
    {

        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;
    }

    public Calisan(string ad, string soyad)
    {
        this.Ad = ad;
        this.Soyad = soyad;
    }

    public Calisan()
    {

    }


    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgileri()
    {
        System.Console.WriteLine("Çalışanın adı: {0}", Ad);
        System.Console.WriteLine("Çalışanın soyadı: {0}", Soyad);
        System.Console.WriteLine("Çalışanın numarası: {0}", No);
        System.Console.WriteLine("Çalışanın departmanı: {0}", Departman);
    }
}
