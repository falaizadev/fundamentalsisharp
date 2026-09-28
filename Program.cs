

Console.WriteLine("==================================");

Console.WriteLine("Game Tebak Angka");
int angkatebak = 10;
int kesempatan = 5;
int angkaTebakan;



while (kesempatan > 0)
{
    Console.WriteLine("Kesempatan : " + kesempatan);


    Console.WriteLine("Masukkan Angka 1-10 : ");
    String angkatebakCatcherror = Console.ReadLine() ?? "0";

    if (!int.TryParse(angkatebakCatcherror, out angkaTebakan))
    {
        Console.WriteLine("Masukkan Sesuai");
        continue;
    }
    else
    {
        Console.WriteLine("Sesuai");

        

    }

    if (angkaTebakan == angkatebak)
    {
        Console.WriteLine("Selamat");
        break;

    }
    else
    {
        Console.WriteLine("Salah..");
        kesempatan--;
    }

}