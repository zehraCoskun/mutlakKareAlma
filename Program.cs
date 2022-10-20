//Ekrandan girilen n tane sayının 67'den küçük yada büyük olduğuna bakan. Küçük olanların farklarının toplamını, büyük ise de farkların mutlak karelerini alarak toplayıp ekrana yazdıran console uygulamasını yazınız.
//Örnek: Input: 56 45 68 77
//Output: 33 101
internal class Program
{
    private static void Main(string[] args)
    {
        baslangic:
        Console.WriteLine("Kontrol etmek istediğiniz sayıları arasına vergil koyarak yazınız");
        string input = Console.ReadLine();
        string[] sayiDizisi = input.Split(",");
        int elemanSayisi = sayiDizisi.Count();
        int[] dizimiz = new int[elemanSayisi];
        int sayimiz;
        for (int i = 0; i < elemanSayisi; i++)
        {
            if (!Int32.TryParse(sayiDizisi[i], out sayimiz))
            {
                Console.WriteLine("Girdiğiniz değerler sayısal olmalı");
                goto baslangic;
            }
            dizimiz[i]=sayimiz;
        }
        //buraya kadar int değerler içeren bir sayı dizisi elde ettik.
        int kucuklerToplamı=0;
        int buyuklerToplamı=0;
     
        for (int j = 0; j < elemanSayisi; j++)
        {
            if (dizimiz[j]<64)
            {
                kucuklerToplamı +=64-dizimiz[j];
            }
            else 
            {
                buyuklerToplamı+=(dizimiz[j]-64)*(dizimiz[j]-64);
            }
        }
        Console.WriteLine("64'ten küçük sayılar için yapılan işlem : "+kucuklerToplamı);
        Console.WriteLine("64'ten büyük sayılar için yapılan işlem : "+buyuklerToplamı);

       
    }
}