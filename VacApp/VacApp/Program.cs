string cevap = "";

while (cevap == "evet" || cevap == "") // Butun tatil uygulamasi bu while dongusunun icinde calisacak cevap degiskeni evet oldugu zaman dongu tekrar baslayacak.
{ 
    Console.WriteLine("Merhaba, ben VacApp. Tatil icin gitmek istedginiz konumu girin.");
    Console.WriteLine($" 1-Bodrum (Paket Baslangic Ucreti: 4000TL)\n 2-Marmaris(Paket Baslangic Ucreti: 3000TL) \n 3-Cesme(Paket Baslangic Ucreti:5000TL )");
    string konum = Console.ReadLine().ToLower(); // Kullanici gitmek istedigi konumu girecek.
    while (konum !="bodrum" && konum != "marmaris" && konum !="cesme")
    {
        Console.WriteLine("Lutfen gecerli Bir Konum Giriniz. (marmaris,cesme,bodrum)");
        konum = Console.ReadLine().ToLower();// Kullnaici seceneklerde olmayan bir cevap yazarsa kullanicidan tekrar girdi istiyoruz.
    }

    int konumucreti; // Konum ucretini tutacak degisken

    if(konum =="bodrum")
    {
        konumucreti = 4000; // Bodrumun ucreti
    }
    else if (konum == "marmaris")
    {
        konumucreti = 3000; // Marmarisin ucreti
    }
    else
    {
        konumucreti = 5000; // Cesmenin ucreti
    }

    Console.WriteLine("Kac Kisisinz ?");
    int kisi = Convert.ToInt32(Console.ReadLine()); // Kullanici kac kisi oldugunu girecek.

    while (kisi < 0)
    {
        Console.WriteLine("Lutfen gecerli bir kisi sayisi giriniz.");
        kisi = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("Ulasim secenekleri:");
    Console.WriteLine($" 1-Karayolu kisi basi git-gel :1500TL\n 2-Havayolu kisi basi git-gel :4000TL/n  Hangi ulasim yontemini secmek istersiniz? Cevap icin (1-2)");
    int ulasim = Convert.ToInt32(Console.ReadLine()); // Kullanici ulasim secenegini sececek.

    while (ulasim != 1 && ulasim != 2)
    {
        Console.WriteLine("Lutfen gecerli bir ulasim secenegi giriniz. (1-2)");
        ulasim = Convert.ToInt32(Console.ReadLine()); // Kullanici seceneklerde olmayan bir cevap yazarsa kullanicidan tekrar girdi istiyoruz.
    }

    int ulasimfiyati; // Ulasim fiyatini tutacak degisken
    
    if (ulasim == 1)
    {
        ulasimfiyati = 1500; // Karayolu fiyatı
    }
    else
    {
        ulasimfiyati = 4000; // Havayolu fiyatı
    }


    // Toplam fiyat Bilgisinin kullaniciya gosterilmesi icin hesaplanacak kisim
     int ucret = (kisi * ulasimfiyati) + (konumucreti*kisi); // Toplam ucret hesaplanacak
    Console.WriteLine("toplam ucret : " + ucret);

    Console.WriteLine("Baska Bir tatil Planlamak Ister Misiniz ? (evet / hayir)");
    cevap = Console.ReadLine().ToLower(); // Kullanici tatil planlamak isteyip istemedigini soruyoruz.

    while (cevap !="evet" && cevap != "hayir") // ve operatoru kullanik veya kullansaydik dongu bu kisimda sikisirdi.
    {
        Console.WriteLine("Lutfen gecerli bir cevap giriniz. (evet / hayir)");
        cevap = Console.ReadLine().ToLower(); // Kullanici seceneklerde olmayan bir cevap yazarsa kullanicidan tekrar girdi istiyoruz.
    }
}
//Cevap Hayir olursa dongu sonlanacak ve kullaniciya "Tesekkur mesaji yazilacak.
Console.WriteLine("VacAPP tercih ettiginiz icin tesekkur ederiz ! Iyi tatiller.");