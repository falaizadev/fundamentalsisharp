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

decimal jumlah34;
Console.WriteLine("Masukkan Nilai Harga : ");
String hargacatcherror = Console.ReadLine() ?? "0";

if (decimal.TryParse(hargacatcherror, out jumlah34 ))
{
    Console.WriteLine("Harga Valid!");
}
else
{
    Console.WriteLine("Masukkan Harga Berupa Angka!");
}