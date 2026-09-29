string nama_pelanggan = "Fal";
string barang = "Nasi Goreng";
decimal harga = 15000;
int jumlah = 2;
decimal uang_pelanggan = 1000;

Console.WriteLine("Nama Pelanggan: " + nama_pelanggan);
Console.WriteLine("Barang: " + barang);
Console.WriteLine("Harga: " + harga);
Console.WriteLine("Jumlah: " + jumlah);
Console.WriteLine("==============================");

decimal total = harga * jumlah;

Console.WriteLine("Total: " + total);

if (uang_pelanggan >= total)
{
    decimal kembalian = uang_pelanggan - total;
    Console.WriteLine("Transaksi berhasil");
    Console.WriteLine("Kembalian " + kembalian);
}
else
{
    Console.WriteLine("Transaksi di tolak");
}

Console.WriteLine("==============================");

Console.WriteLine("Masukkan Nama : ");
string nama = Console.ReadLine() ?? "";

Console.WriteLine("Masukkan Nama Barang : ");
string nama_barang = Console.ReadLine() ?? "";

Console.WriteLine("Masukkan Harga Barang : ");
int harga_barang = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Masukkan Jumlah Barang : ");
int jumlah_barang = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Masukkan Uang Pelanggan : ");
decimal uangPelanggan = decimal.Parse(Console.ReadLine() ?? "0");

decimal total2 = harga_barang * jumlah_barang;

if (uangPelanggan >= total2)
{
    decimal kembalian2 = uangPelanggan - total2;
    Console.WriteLine("Transaksi berhasil");
    Console.WriteLine("Kembalian " + kembalian2);
}
else
{
    Console.WriteLine("Transaksi di tolak");
}

Console.WriteLine("=========================");

decimal hargaaBarang = 12000;
int jumlahhBarang = 3;
decimal uanggPelanggan = 50000;


decimal totalHitung = hargaaBarang * jumlahhBarang;


if (uanggPelanggan >= totalHitung)
{
    Console.WriteLine("Transaksi Berhasil");
    decimal kembalian3 = uanggPelanggan - totalHitung;
    Console.WriteLine("Kembalian : " + kembalian3);
}
else
{
    Console.WriteLine("Uang tidak cukup");
}

Console.WriteLine("=====================================");

String aname = "Keyboard";
decimal price = 150000;
int count = 2;
decimal moneyuser = 400000;

decimal subtotal = price * count;

decimal change = moneyuser - subtotal;

if (moneyuser >= subtotal)

{
    Console.WriteLine("Transaksi Berhasil");
    Console.WriteLine("Kembalian : " + change);
}
else
{
    Console.WriteLine("Pembayaran Tidak Mencukupi");
}

Console.WriteLine("=====");
Console.WriteLine("\tNama Barang\t==" + aname);
Console.WriteLine("\tSub Total\t==" + subtotal);
Console.WriteLine("\tKembalian\t==" + change);

Console.WriteLine("==============================");

Console.WriteLine("Nama Barang : ");
String jenis_nama = Console.ReadLine() ?? "";

Console.WriteLine("Harga : ");
decimal jenis_harga = decimal.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Jumlah : ");
int jenis_jumlah = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Uang Pelanggan : ");
decimal jenis_usermoney = decimal.Parse(Console.ReadLine() ?? "0");

decimal jenis_subTotal = jenis_harga * jenis_jumlah;
decimal jenis_kembalian = jenis_usermoney - jenis_subTotal;

if (jenis_usermoney >= jenis_subTotal)
{
    Console.WriteLine("Transaksi Berhasil...");
    Console.WriteLine("Kembalian : " + jenis_kembalian);
}
else
{
    Console.WriteLine("Transaksi Gagal..");
}

Console.WriteLine("============================");

Console.WriteLine("=======Aplikasi Kasir=======");

Console.WriteLine("============================");
Console.WriteLine("Inputan");

Console.WriteLine("Nama Barang : ");
string namabarang2 = Console.ReadLine() ?? "";

Console.WriteLine("Harga : ");
decimal hargabarang2 = decimal.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Jumlah : ");
decimal jumlahbarang2 = decimal.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Uang Pembayaran : ");
decimal uangpembayaran2 = decimal.Parse(Console.ReadLine() ?? "0");

decimal totalbarang2 = hargabarang2 * jumlahbarang2;

if (hargabarang2 > 0 && jumlahbarang2 > 0 && uangpembayaran2 >= totalbarang2)
{
    decimal kembalianbarang2 = uangpembayaran2 - totalbarang2;
    Console.WriteLine("Harga & Jumlah Barang Valid!");
    Console.WriteLine("Transaksi Berhasil!");
    Console.WriteLine("Kembalian : " + kembalianbarang2);
}
else
{
    Console.WriteLine("Harga & Jumlah Barang Tidak Valid!");
    Console.WriteLine("Transaksi Gagal!");
}


Console.WriteLine("================================");

Console.WriteLine("Toko Kasir");
Console.WriteLine("Nama Barang : ");
String namabarang3 = Console.ReadLine() ?? "";

Console.WriteLine("Harga Barang : ");
decimal hargabarang3 = decimal.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Jumlah Barang : ");
decimal jumlahbarang3 = decimal.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Uang Pembayaran : ");
decimal uangpembayaran3 = decimal.Parse(Console.ReadLine() ?? "0");

decimal totalbarang3 = hargabarang3 * jumlahbarang3;

if (hargabarang3 <= 0)
{
    Console.WriteLine("Harga Tidak Valid!");
}
else if (jumlahbarang3 <= 0)
{
    Console.WriteLine("Jumlah Tidak Valid!");
}

else if (uangpembayaran3 < totalbarang3)
{
    Console.WriteLine("Uang Pembayaran Tidak Cukup!");
}
else
{
    decimal kembalianbarang3 = uangpembayaran3 - totalbarang3;
    Console.WriteLine("Transaksi Berhasil!");
    Console.WriteLine("Total Barang Keseluruhan : " + totalbarang3);
    Console.WriteLine("Kembalian : " + kembalianbarang3);
}

Console.WriteLine("===============================");

decimal harga34;
Console.WriteLine("Masukkan Nilai Harga : ");
string hargacatcherror = Console.ReadLine() ?? "0";

if (!decimal.TryParse(hargacatcherror, out harga34))
{
    Console.WriteLine("Masukkan Harga Berupa Angka!");
}
else if (harga34 <= 0)
{
    Console.WriteLine("Harga Tidak Valid!");
}
else
{
    Console.WriteLine("Harga Valid!");
}

decimal jumlah34;
Console.WriteLine("Masukkan Jumlah Barang : ");
string jumlahcatcherror = Console.ReadLine() ?? "0";

if (!decimal.TryParse(jumlahcatcherror, out jumlah34))
{
    Console.WriteLine("Masukkan Jumlah Berupa Angka!");
}
else if (jumlah34 <= 0)
{
    Console.WriteLine("Jumlah Tidak Valid!");
}
else
{
    Console.WriteLine("Jumlah Valid!");
}

decimal total34 = harga34 * jumlah34;

decimal up34;
Console.WriteLine("Masukkan Uang Pembayaran : ");
string upcatcherror = Console.ReadLine() ?? "0";

if (!decimal.TryParse(upcatcherror, out up34))
{
    Console.WriteLine("Masukkan Uang Pembayaran Berupa Angka!");
}
else if (up34 < total34)
{
    Console.WriteLine("Uang Pembayaran Kurang!");
}
else
{
    Console.WriteLine("Uang Pembayaran Valid!");
}

if (harga34 > 0 && jumlah34 > 0 && up34 >= total34)
{
    decimal kembalian34 = up34 - total34;

    Console.WriteLine("Total : " + total34);
    Console.WriteLine("Transaksi Berhasil!");
    Console.WriteLine("Kembalian : " + kembalian34);
}
else
{
    Console.WriteLine("Transaksi Gagal!");
}

Console.WriteLine("Masukkan Angka : ");
String angka1 = Console.ReadLine() ?? "0";
int angka2;
if (int.TryParse(angka1, out angka2))
{
    Console.WriteLine("Masukkan Angka Yang Sesuai!");
}
else
{
    Console.WriteLine("Apa ya!");
}

int angkaa = 1;

while (angkaa <= 5)
{
    Console.WriteLine(angkaa);

    angkaa++;
}

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

Console.WriteLine("==============================");

Console.WriteLine("=== SISTEM KASIR ===");

Console.Write("Nama Barang : ");
string namaBarang23 = Console.ReadLine() ?? "";

Console.Write("Harga Barang : ");
decimal harga23 = decimal.Parse(Console.ReadLine() ?? "0");

Console.Write("Jumlah Barang : ");
int jumlah23 = int.Parse(Console.ReadLine() ?? "0");

decimal subtotal23 = harga23 * jumlah23;

Console.WriteLine("Subtotal : " + subtotal23);

Console.Write("Uang Pembayaran : ");
decimal pembayaran23 = decimal.Parse(Console.ReadLine() ?? "0");

if (harga23 <= 0)
{
    Console.WriteLine("Harga tidak valid!");
}
else if (jumlah23 <= 0)
{
    Console.WriteLine("Jumlah tidak valid!");
}
else if (pembayaran23 < subtotal23)
{
    Console.WriteLine("Uang pembayaran tidak cukup!");
}
else
{
    decimal kembalian23 = pembayaran23 - subtotal23;

    Console.WriteLine("=== TRANSAKSI ===");
    Console.WriteLine("Barang     : " + namaBarang23);
    Console.WriteLine("Harga      : " + harga23);
    Console.WriteLine("Jumlah     : " + jumlah23);
    Console.WriteLine("Subtotal   : " + subtotal23);
    Console.WriteLine("Pembayaran : " + pembayaran23);
    Console.WriteLine("Kembalian  : " + kembalian23);
    Console.WriteLine("Transaksi berhasil!");
}

Console.WriteLine("====================================================");

int kesempatan4 = 10;
while (kesempatan4 > 0)
{


    Console.WriteLine("Nama Barang : ");
    String inputsbarang = Console.ReadLine() ?? "";

    Console.WriteLine("Harga Barang : ");
    String hargaBarangtryparse = Console.ReadLine() ?? "0";
    decimal hargaBarang4;

    if (!decimal.TryParse(hargaBarangtryparse, out hargaBarang4))
    {

        Console.WriteLine("Masukkan Harga Dengan Benar!");
        kesempatan4--;
        continue;
    }

    if (hargaBarang4 > 0)
    { 
    }
    else
    {
        Console.WriteLine(" ");
        kesempatan4--;
        continue;
    }



    Console.WriteLine("Jumlah Barang : ");
    String jumlahBarangtryparse = Console.ReadLine() ?? "0";
    decimal jumlahBarang4;

    if (!decimal.TryParse(jumlahBarangtryparse, out jumlahBarang4))
    {
        Console.WriteLine("Masukkan Jumlah Dengan Benar!");
        kesempatan4--;
        continue;
    }


    if (jumlahBarang4 > 0)
    { 
    }
    else
    {
        Console.WriteLine(" ");
        kesempatan4--;
        continue;
    }

    decimal jumlahTotal4 = hargaBarang4 * jumlahBarang4;
    Console.WriteLine("Total : " + jumlahTotal4);

    break;
}

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

Console.WriteLine("===========================================");
Console.WriteLine("PPCPPCPPPCPCPCP");
Console.WriteLine("OFFOFOOFOFOFOOOF");