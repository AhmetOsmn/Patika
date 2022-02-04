class Ogrenci
{

    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;

    public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
    {
        this.isim = isim;
        this.soyisim = soyisim;
        this.ogrenciNo = ogrenciNo;
        this.sinif = sinif;
    }

    public Ogrenci()
    {

    }

    public int Sinif
    {
        get => sinif;
        set
        {
            if (value < 1)
            {
                System.Console.WriteLine("Sınıf en az 1 olabilir.");
                sinif = 1;
            }
            else
            {
                sinif = value;
            }
        }
    }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public string Isim { get => isim; set => isim = value; }

    public void OgrenciBilgileriniGetir()
    {
        System.Console.WriteLine("----OGRENCİ BİLGİLERİ");
        System.Console.WriteLine("Öğrencinin adı: " + this.isim);
        System.Console.WriteLine("Öğrencinin soyisim: " + this.soyisim);
        System.Console.WriteLine("Öğrencinin sınıfı: " + this.sinif);
        System.Console.WriteLine("Öğrencinin öğrenci numarası: " + this.ogrenciNo);
    }

    public void SinifArttir()
    {
        this.Sinif = this.Sinif + 1;
    }

    public void SinifDusur()
    {
        this.Sinif = this.Sinif - 1;
    }
}
