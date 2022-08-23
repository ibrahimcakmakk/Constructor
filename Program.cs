using System;
using System.Collections;

class Program{

    static void Main(string[] args){

        //söz Dizisi
        //class SinifAdi
        //{
        //  [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
        //  [Erişim Belirleyici] [Geri Dönüş Tipi] MetodAdi([Parametre Listesi])
        //  {
        //      Metot Konutları
        //   }
        // }

        //Erişim Berlileyiciler
        // * Public
        // * Private
        // * Internal
        // * Protected
        Calisan calısan1 = new Calisan("ayşe","kara",2345634,"insan kaynakları");
        
        calısan1.CalışanBilgiler();

        Calisan calisan2 = new Calisan();
        calisan2.Ad = "Deniz";
        calisan2.Soyad = "Arda";
        calisan2.No = 2345345;
        calisan2.Depertman = "satın alma";

        calisan2.CalışanBilgiler();

        Calisan calisan3 = new Calisan("zekriye", "Ürkmez");
    
    }   
}

class Calisan{

    public string Ad;
    public string Soyad;
    public int No;
    public string Depertman;

    public Calisan(string ad, string Soyad, int No,string Depertman){

        this.Ad = ad;
        this.Soyad = Soyad;
        this.No = No;
        this.Depertman = Depertman;
    }
    public Calisan(string ad, string Soyad){

    }
    public Calisan(){

    }

    public void CalışanBilgiler(){
        Console.WriteLine("çalışanın Adı:{0}" ,Ad);
        Console.WriteLine("çalışanın Soyadı:{0}" ,Soyad);
        Console.WriteLine("çalışanın No:{0}" ,No);
        Console.WriteLine("çalışanın Departmanı:{0}" ,Depertman);
        
    }
}
