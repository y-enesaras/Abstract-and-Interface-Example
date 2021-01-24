using System;
using System.Text;
using System.Threading;
class Program
{
     static void Main(string[] args)
     {
        DonanimBilesenleri db = new DonanimBilesenleri();
        db.DonanimiGetir();
      
        Console.Read(); 
     }
}
public abstract class Donanım
{
    public string Islemci { get; set; }
    public string EkranKarti { get; set; }
    public string Depolama { get; set; }
    public string Ram { get; set; }
    public abstract void DonanimiGetir();
}
public interface Tasarim
{
    void EkranPaneli();
    void Isiklandirma();
    void EkranBoyutu();
    void Kamera();
}
public interface EkBilgiler
{
    void GarantiSuresi();
    void AnakartBosOlanSlotlar();
}
public class DonanimBilesenleri : Donanım
{
    public override void DonanimiGetir()
    {
        
        Islemci = "AMD Ryzen 5 3550h";
        EkranKarti = "GTX 1650";
        Depolama = "256gb M2 SSD";
        Ram = "16 gb 2666mhz CL17";
        Console.Write("Bilgisayarınızın hangi bilesenini gormek istersiniz? \n" +
            "\nIslemci icin = (1)\n" +
            "Ekran Karti icin = (2)\n" +
            "Depolama icin = (3)\n" +
            "Ram için = (4) ' e basin:");
        
        int secim = Convert.ToInt32(Console.ReadLine());
        if(secim == 1)
        {
            Console.WriteLine("Bilgisayarın Islemcisi: " + Islemci+"\n");
        }
        else if(secim == 2)
        {
            Console.WriteLine("Bilgisayarın Ekran Karti: " + EkranKarti + "\n");
        }
        else if (secim == 3)
        {
            Console.WriteLine("Bilgisayarın Depolaması: " + Depolama + "\n");
        }
        else if(secim == 4)
        {
            Console.WriteLine("Bilgisayarın Rami: " + Ram+"\n");
        }
         int i = 0;
        while (i < secim)
        {
            Console.Write("Baska Bir bilesen gormek icin (0)'a basin. \nEk bilgiler icin (9)'a basin.\nÇıkmak için (1)'e basın: ");
            int tekrarSecim = Convert.ToInt32(Console.ReadLine());
            if (tekrarSecim == 0)
            {
                DonanimiGetir();
            }
            else if(tekrarSecim == 9)
            {
                GerekliBilgiler gb = new GerekliBilgiler();
                Console.WriteLine();
                Console.WriteLine("-----Bilgisayarınız-----");
                Console.WriteLine();
                gb.EkranPaneli();
                gb.Isiklandirma();
                gb.Kamera();
                gb.EkranBoyutu();
                gb.GarantiSuresi();
                gb.AnakartBosOlanSlotlar();
            }
            else if(tekrarSecim == 1)
            {
                Console.WriteLine("Ekran Kapaniyor....");
                Environment.Exit(0);
            }
            else    
            { 
                Environment.Exit(0);
            }
        }
    }
}
public class GerekliBilgiler : Tasarim, EkBilgiler
{
    public void EkranPaneli()
    { 
        Console.WriteLine("60 HZ İPS LCD EKRAN");
    }
    public void Isiklandirma()
    {
        Console.WriteLine("RGB Aydınlatmalı");
    }
    public void Kamera()
    {
        Console.WriteLine("1080P Full HD Kamera Cekimi");
    }
    public void EkranBoyutu()
    {
        Console.WriteLine("15.6 inch Full Hd Ekran ");
    }
    public void GarantiSuresi()
    {
        Console.WriteLine("2 Yıl Garantili");
    }
    public void AnakartBosOlanSlotlar()
    {
        Console.WriteLine("1 Adet M2 depolama boş slot, 1 adet boş ram slotu ve harddisk kısmı boş olan slotlardır.");
    }
}
