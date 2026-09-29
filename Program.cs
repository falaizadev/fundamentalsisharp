

Console.WriteLine("=====================================");


for (int i =1; i <= 10; i++)
{
    Console.WriteLine(i);
}

for(int a = 10; a>=1; a--)
{
    Console.WriteLine(a);
}

for(int u = 2; u <= 20; u+=2)
{
    Console.WriteLine(u);
}

int totalFor = 0;

for (int aa = 1; aa<=10; aa++)
{
    totalFor += aa;
    Console.WriteLine(aa);
}
Console.WriteLine("Total : " + totalFor);

for(int p = 1; p<=10; p++)
{
    int y = 5;
    int perkalian = p * y;
    Console.WriteLine(p + "x" +  y  +": " + perkalian);
}


decimal tttl = 0;

for (int brg = 1; brg<=5; brg++)
{
    decimal hrg = 10000;
    decimal jml = 2;
    decimal sbttl = hrg * jml;
    tttl += sbttl;

    Console.WriteLine("Barang "+brg + "-" + "subtotal : "+sbttl );
}
Console.WriteLine("Total Semua Barang : " + tttl);