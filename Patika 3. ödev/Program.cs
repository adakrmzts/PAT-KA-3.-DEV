Console.Write("Lütfen bir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());
if (sayi<10)
{
    Console.WriteLine("Girdiğiniz sayı 10'dan küçük.");
}
else if (sayi==10)
{
        Console.WriteLine("Girdiğiniz sayı 10'a eşit.");
}
else    
{
        Console.WriteLine("Girdiğiniz sayı 10'dan büyüktür.");
}
if(sayi%2==0)
{
        Console.WriteLine("Girdiğiniz sayı çifttir.");
}
else
{
        Console.WriteLine("Girdiğiniz sayı tektir.");
}