using System;
using System.Collections.Generic;

namespace _16.TelefonRehberiUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Ahmet", "SEZGİN", "000001");
            Person p2 = new Person("Ulaş", "AVİL", "000002");
            Person p3 = new Person("Kürşat", "GÜRLER", "000003");
            Person p4 = new Person("Mert", "ALTIN", "000004");
            Person p5 = new Person("Oğuzhan Emre", "DORAN", "000005");
            Person p6 = new Person("Burak", "GÜNEY", "000006");


            DirectoryManager directoryManager = new DirectoryManager(new Directory());

            directoryManager.CreatePerson(p1);
            directoryManager.CreatePerson(p2);
            directoryManager.CreatePerson(p3);
            directoryManager.CreatePerson(p4);
            directoryManager.CreatePerson(p5);
            directoryManager.CreatePerson(p6);

            ShowMenu();

            while (true)
            {
                try
                {
                    System.Console.Write("Seçim: ");
                    int secim = int.Parse(Console.ReadLine());

                    if (secim < 0 || secim > 5)
                    {
                        System.Console.WriteLine("Geçersiz seçim!");
                    }
                    else if (secim == 0)
                    {
                        System.Console.WriteLine("Çıkış yapılıyor.");
                        break;
                    }
                    else
                    {
                        if (secim == 1)
                        {
                            System.Console.Write("Lütfen isim giriniz: ");
                            string newPersonName = Console.ReadLine();
                            System.Console.Write("Lütfen soyisim giriniz: ");
                            string newPersonSurname = Console.ReadLine();
                            System.Console.Write("Lütfen telefon numarası giriniz: ");
                            string newPersonNumber = Console.ReadLine();

                            directoryManager.CreatePerson(new Person(newPersonName, newPersonSurname, newPersonNumber));
                            ShowMenu();
                        }
                        else if (secim == 2)
                        {
                            while (true)
                            {
                                System.Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
                                string nameOrSurname = Console.ReadLine();
                                List<Person> personList = directoryManager.SearchPerson(nameOrSurname);

                                if (personList.Count == 0)
                                {
                                    System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                                    System.Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                                    System.Console.WriteLine("* Yeniden denemek için      : (2)");
                                    System.Console.Write("Silme işlemi için seçim: ");
                                    int silmeSecim = int.Parse(Console.ReadLine());
                                    if (silmeSecim == 1)
                                    {
                                        System.Console.WriteLine("Silme işlemi sonlandırılıyor.");
                                        break;
                                    }
                                    else if (silmeSecim == 2)
                                    {

                                    }
                                    else
                                    {
                                        System.Console.WriteLine("Geçersiz seçim");
                                    }

                                }
                                else
                                {
                                    Person person = new Person();
                                    person = personList[0];
                                    System.Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", person.Name);
                                    char silmeOnaySecim = Console.ReadLine()[0];
                                    System.Console.WriteLine(silmeOnaySecim);
                                    if (silmeOnaySecim == 'y')
                                    {
                                        directoryManager.DeletePerson(person);
                                        System.Console.WriteLine("Silme işlemi tamamlandı.");
                                        break;
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("İşlem iptal edildi.");
                                        break;
                                    }
                                }
                            }

                            ShowMenu();
                        }
                        else if (secim == 3)
                        {
                            while (true)
                            {
                                System.Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
                                string nameOrSurname = Console.ReadLine();
                                List<Person> personList = directoryManager.SearchPerson(nameOrSurname);
                                if (personList.Count == 0)
                                {
                                    System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                                    System.Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                                    System.Console.WriteLine("* Yeniden denemek için      : (2)");
                                    System.Console.Write("Güncelleme işlemi için seçim: ");
                                    int guncellemeSecim = int.Parse(Console.ReadLine());
                                    if (guncellemeSecim == 1)
                                    {
                                        System.Console.WriteLine("Güncelleme işlemi sonlandırılıyor.");
                                        break;
                                    }
                                    else if (guncellemeSecim == 2)
                                    {

                                    }
                                    else
                                    {
                                        System.Console.WriteLine("Geçersiz seçim");
                                    }

                                }
                                else
                                {
                                    Person person = new Person();
                                    person = personList[0];
                                    System.Console.WriteLine("{0} isimli kişinin yeni numarasını giriniz: ", person.Name);
                                    string newNumber = Console.ReadLine();
                                    person.Number = newNumber;
                                    directoryManager.UpdatePerson(person);
                                    System.Console.WriteLine("Güncelleme işlemi tamamlandı.");
                                    break;
                                }
                            }
                            ShowMenu();
                        }
                        else if (secim == 4)
                        {
                            // A-Z, Z-A sıralama işlemi yapılacak.
                            System.Console.WriteLine("\nTelefon Rehberi");
                            System.Console.WriteLine("**************************************");
                            directoryManager.ShowPersonsAsc();
                            ShowMenu();
                        }
                        else
                        {
                            System.Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz.");
                            System.Console.WriteLine("***************************************");
                            System.Console.WriteLine("\nİsim veya soyisime göre arama yapmak için: (1)");
                            System.Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
                            int aramaSecim = int.Parse(Console.ReadLine());

                            if (aramaSecim == 1)
                            {
                                System.Console.Write("Lütfen isim veya soyisim giriniz: ");
                                string nameOrSurname = Console.ReadLine();
                                List<Person> personList = directoryManager.SearchPerson(nameOrSurname);
                                if (personList.Count == 0)
                                {
                                    System.Console.WriteLine("Böyle birisi bulunamadı..");
                                }
                                else
                                {
                                    System.Console.WriteLine("Arama Sonuçlarınız:");
                                    System.Console.WriteLine("********************************");
                                    foreach (var item in personList)
                                    {
                                        item.Info();
                                        System.Console.WriteLine("-");
                                    }
                                }
                            }
                            else if (aramaSecim == 2)
                            {
                                System.Console.Write("Lütfen numarasını giriniz: ");
                                string arananNumara = Console.ReadLine();
                                List<Person> personList = directoryManager.SearchPerson2(arananNumara);
                                if (personList.Count == 0)
                                {
                                    System.Console.WriteLine("Böyle birisi bulunamadı..");
                                }
                                else
                                {
                                    System.Console.WriteLine("Arama Sonuçlarınız:");
                                    System.Console.WriteLine("********************************");
                                    foreach (var item in personList)
                                    {
                                        item.Info();
                                        System.Console.WriteLine("-");
                                    }
                                }
                            }
                            else
                            {
                                System.Console.WriteLine("Geçersiz seçim!");
                            }
                            ShowMenu();
                        }
                    }
                }



                catch (System.Exception)
                {
                    System.Console.WriteLine("Geçersiz seçim!");
                }
            }
        }

        public static void ShowMenu()
        {
            System.Console.WriteLine("----------------------------------------------");
            System.Console.WriteLine("| MENÜ                                       |");
            System.Console.WriteLine("----------------------------------------------");
            Console.WriteLine("| (1) Yeni Numara Kaydetmek                  |");
            Console.WriteLine("| (2) Varolan Numarayı Silmek                |");
            Console.WriteLine("| (3) Varolan Numarayı Güncelleme            |");
            Console.WriteLine("| (4) Rehberi Listelemek                     |");
            Console.WriteLine("| (5) Rehberde Arama Yapmak                  |");
            Console.WriteLine("| (0) Çıkış                                  |");
            System.Console.WriteLine("----------------------------------------------");
        }
    }
}
