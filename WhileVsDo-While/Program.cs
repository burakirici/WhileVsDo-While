int sayac = 1;

Console.WriteLine("Bir limit degeri giriniz: ");

int limit = int.Parse(Console.ReadLine());

while (sayac <= limit)
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac++;
}

// Do-While ile yapımı
int sayac2 = 1;
Console.WriteLine("Bir limit degeri giriniz");
int lim2 = int.Parse(Console.ReadLine());
do
{
    System.Console.WriteLine("Ben Patika'lıyım!");
    sayac2++;
}while(sayac2 <= lim2);

// While döngüsü önce koşulu kontrol edip çalıştırıyor, Do-While döngüsünde ise koşulu son aşamada kontrol ediyor.

