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
    int jml = 2;
    decimal sbttl = hrg * jml;
    tttl += sbttl;

    Console.WriteLine("Barang "+brg + "-" + "subtotal : "+sbttl );
}
Console.WriteLine("Total Semua Barang : " + tttl);

Console.WriteLine("============================================");

int angkadw = 1;
do
{
    Console.WriteLine("Masukkan Angka : "+angkadw);
    angkadw++;
}
while (angkadw <= 5);


int cekbrgdw = 1;

do
{
    Console.WriteLine("Cek Barang ke -" + cekbrgdw);
    cekbrgdw++;
} while (cekbrgdw <= 5);

decimal hrgdw;
do
{


    Console.WriteLine("Masukkan Harga : ");
    hrgdw = int.Parse(Console.ReadLine() ?? "0");

    if (hrgdw <= 0)
    {
        Console.WriteLine("Harga Tidak Valid!");
    }
    else
    {
        Console.WriteLine("Harga Valid");
    }

} while (hrgdw > 0);

int jmlhdw;

do
{
    Console.WriteLine("Masukkan Jumlah : ");
    jmlhdw = int.Parse(Console.ReadLine() ?? "0");

    if (jmlhdw <= 0)
    {
        Console.WriteLine("Jumlah Tidak Valid!");
    }
    else
    {
        Console.WriteLine("Jumlah Valid!");
    }
} while (jmlhdw <= 0);

int stok;

do
{
    Console.WriteLine("Masukkan Jumlah Stok : ");
    stok = int.Parse(Console.ReadLine() ?? "0");

    if (stok < 0)
    {
        Console.WriteLine("Stok Tidak Valid!");
    }
    else if (stok == 0)
    {
        Console.WriteLine("Stok Habis!");
    }
    else
    {
        Console.WriteLine("Stok Tersedia");
    }
   


}while (stok < 0) ;


decimal hrg1 = 0;

int jm1 =0 ;

do
{
    Console.WriteLine("Masukkan Harga Barang : ");
    String hrgbarangdw =Console.ReadLine() ?? "0";

    if(!decimal.TryParse(hrgbarangdw, out hrg1))
    {
        Console.WriteLine("Masukkan Angka!");
        continue;
    }
    else
    {
        Console.WriteLine("Valid!");
       
    }

    Console.WriteLine("Masukkan Jumlah Barang : ");
    String jmlbarangdw =Console.ReadLine() ?? "0";

    if (!int.TryParse(jmlbarangdw, out jm1))
    {
        Console.WriteLine("Masukkan Angka!");
        continue;
    }
    else
    {
        Console.WriteLine("Valid!");
       
    }

    if (hrg1 <=0 )
    { 
        Console.WriteLine("Harga Tidak Valid!");
        continue;
    }
    else
    {
        Console.WriteLine("Harga Valid!");
    }

    if(jm1 <=0)
    {
        Console.WriteLine("Jumlah Tidak Valid!");
        continue;
    }
    else
    {
        Console.WriteLine("Jumlah Valid!");
    }
    



} while ( hrg1 <=0 || jm1 <= 0 );


decimal tlbarangdw = hrg1 * jm1;
Console.WriteLine("Total : " + tlbarangdw);

Console.WriteLine("================================================");

String namall;
decimal hrgll = 0;
int stkll = 0;


do
{


    Console.WriteLine("Nama Barang : ");
    namall = Console.ReadLine() ?? "";

    Console.WriteLine("Harga Barang : ");
    String hrop = Console.ReadLine() ?? "0";

    if (!decimal.TryParse(hrop, out hrgll))
    {
        Console.WriteLine("Masukkan Angka!!");
        continue;
    }
    else
    {
        Console.WriteLine("Lanjut");
    }

    Console.WriteLine("Jumlah Stok : ");
    String jmsk = Console.ReadLine() ?? "0";

    if (!int.TryParse(jmsk, out stkll))
    {
        Console.WriteLine("Masukkan Angka!!");
        continue;
    }
    else
    {
        Console.WriteLine("Lanjut");
    }

    if (hrgll <= 0)
    {
        Console.WriteLine("Masukkan Harga Yang Sesuai!");
        continue;
    }
    else
    {
        Console.WriteLine("Lanjut");
    }

    if (stkll < 0)
    {
        Console.WriteLine("Masukkan Stok Yang Benar!");
        continue;
    }
    else if (stkll == 0)
    {
        Console.WriteLine("Stok Habis!");
    }
    else
    {
        Console.WriteLine("Stok Tersedia!");
    }

} while (hrgll <= 0 || stkll < 0);

Console.WriteLine("Nama Barang : " + namall);
Console.WriteLine("Harga : " + hrgll);
Console.WriteLine("Stok : " + stkll);

Console.WriteLine("============================");

String nmb1;
decimal hgb1 = 0;
int jmb1 = 0;
decimal upp1 = 0;
decimal ttl11 = 0;



do
{


    Console.WriteLine("Nama Barang : ");
    nmb1 = Console.ReadLine() ?? "";

    Console.WriteLine("Harga Barang ; ");
    String hggb1 = Console.ReadLine() ?? "0";

    if (!decimal.TryParse(hggb1, out hgb1))
    {
        Console.WriteLine("Masukkan Sesuai Angka!");
        continue;
    }



    if (hgb1 <= 0)
    {
        Console.WriteLine("Masih Belum Valid!");
        continue;
    }



    Console.WriteLine("Jumlah Barang : ");
    String jmmb1 = Console.ReadLine() ?? "0";

    if (!int.TryParse(jmmb1, out jmb1))
    {
        Console.WriteLine("Masukkan Sesuai Angka");
        continue;
    }


    if (jmb1 <= 0)
    {
        Console.WriteLine("Masih Belum Valid!");
        continue;
    }



    ttl11 = hgb1 * jmb1;


    Console.WriteLine("Uang Pembayaran : ");
    String umpp1 = Console.ReadLine() ?? "0";

    if (!decimal.TryParse(umpp1, out upp1))
    {
        Console.WriteLine("Masih Belum Sesuai!");
        continue;
    }




} while (upp1 < ttl11);

Console.WriteLine("Total : " + ttl11);
decimal kb11 = upp1 - ttl11;

Console.WriteLine("Kembalian : " + kb11);
Console.WriteLine("Transaksi Selesai");

Console.WriteLine("=====================================");

String nmbd;
decimal hbrbd = 0;
int jmhbd = 0;
decimal upbd = 0;
decimal tthbd = 0;
decimal diskon = 0.10m;
decimal nilaiDiskon = 0;
decimal ttlhbd = 0;
decimal ckmbhd = 0;

do
{
    Console.WriteLine("Nama Barang : ");
    nmbd = Console.ReadLine() ?? "";

    Console.WriteLine("Harga Barang : ");
    String hbbrbd = Console.ReadLine() ?? "0";

    if (!decimal.TryParse(hbbrbd, out hbrbd))
    {
        Console.WriteLine("Masukkan Harga Berupa Angka!");
        continue;
    }

    if (hbrbd <= 0)
    {
        Console.WriteLine("Harga Tidak Valid!");
        continue;
    }

    Console.WriteLine("Jumlah Barang : ");
    String jmmhbd = Console.ReadLine() ?? "0";

    if (!int.TryParse(jmmhbd, out jmhbd))
    {
        Console.WriteLine("Masukkan Jumlah Berupa Angka!");
        continue;
    }

    if (jmhbd <= 0)
    {
        Console.WriteLine("Jumlah Tidak Valid!");
        continue;
    }
    tthbd = hbrbd * jmhbd;

    if (tthbd >= 100000)
    {
        nilaiDiskon = tthbd * diskon;
        ttlhbd = tthbd - nilaiDiskon;

        nilaiDiskon = tthbd - diskon;
        ttlhbd = tthbd * nilaiDiskon;

        Console.WriteLine("Dapat Diskon 10%");


        Console.WriteLine("Dapat Diskon 10%!");
    }
    else
    {
        nilaiDiskon = 0;
        ttlhbd = tthbd;

        Console.WriteLine("Tidak Dapat Diskon!");
    }

    Console.WriteLine("Total Awal : " + tthbd);
    Console.WriteLine("Nilai Diskon : " + nilaiDiskon);
    Console.WriteLine("Total Bayar : " + ttlhbd);

    Console.WriteLine("Uang Pembayaran : ");
    String uupbd = Console.ReadLine() ?? "0";

    if (!decimal.TryParse(uupbd, out upbd))
    {
        Console.WriteLine("Masukkan Uang Pembayaran Berupa Angka!");
        continue;
    }

    if (upbd <= 0)
    {
        Console.WriteLine("Uang Pembayaran Tidak Valid!");
        continue;
    }

    if (upbd < ttlhbd)
    {
        Console.WriteLine("Uang Pembayaran Tidak Cukup!");
        continue;
    }

    ckmbhd = upbd - ttlhbd;

} while (upbd < ttlhbd);

Console.WriteLine();
Console.WriteLine("=== TRANSAKSI ===");
Console.WriteLine("Nama Barang : " + nmbd);
Console.WriteLine("Harga : " + hbrbd);
Console.WriteLine("Jumlah : " + jmhbd);
Console.WriteLine("Total Awal : " + tthbd);
Console.WriteLine("Diskon : " + nilaiDiskon);
Console.WriteLine("Total Bayar : " + ttlhbd);
Console.WriteLine("Uang Pembayaran : " + upbd);
Console.WriteLine("Kembalian : " + ckmbhd);
Console.WriteLine("Transaksi Berhasil!");


Console.WriteLine("===========================");

String[] gharray =
{
    "pensil",
    "penghapus",
    "penggaris",
    "tipex"
};

for(int iaray=0; iaray < gharray.Length; iaray++)
{
    Console.WriteLine(gharray[iaray]);
}

Console.WriteLine("=============================");

String [] namabarangArray = new string[4];

for (int waray = 0; waray < namabarangArray.Length; waray++)
{
    Console.WriteLine("Masukkan Barang ke-"+(waray+1)+" : ");
    namabarangArray[waray] = Console.ReadLine() ?? "";

}

for (int ui = 0; ui < namabarangArray.Length; ui++)
{
    Console.WriteLine(namabarangArray[ui]);
}

Console.WriteLine("================================");

int[] hrgarray = new int[5];
decimal totalarrrtt = 0;

for (int hrgusrarray = 0; hrgusrarray < hrgarray.Length; hrgusrarray++)
{
    Console.WriteLine("Masukkan 5 Harga Barang : ");
    hrgarray[hrgusrarray] = int.Parse(Console.ReadLine() ?? "0");

    if (hrgarray[hrgusrarray] <= 0)
    {
        Console.WriteLine("ODOD");
        continue;
    }
}

for( int jaja = 0; jaja < hrgarray.Length; jaja++)
{

    Console.WriteLine(hrgarray[jaja]);
    decimal totalhararray = totalarrrtt + hrgarray[jaja];
    Console.WriteLine("Total Harga: " + totalhararray);
}

Console.WriteLine("===================================");


int[] hrgarray2 = new int[5];
decimal totalarrrtt2 = 0;

for (int hrgusrarray2 = 0; hrgusrarray2 < hrgarray2.Length; hrgusrarray2++)
{
    Console.Write("Masukkan Harga Barang ke-" + (hrgusrarray2 + 1) + " : ");
    string inputHarga = Console.ReadLine() ?? "";

    if (!int.TryParse(inputHarga, out int hargasdf))
    {
        Console.WriteLine("Input harus berupa angka!");
        hrgusrarray2--;
        continue;
    }

    if (harga <= 0)
    {
        Console.WriteLine("Harga harus lebih dari 0!");
        hrgusrarray2--;
        continue;
    }

    hrgarray2[hrgusrarray2] = hargasdf;
}

Console.WriteLine("\nDaftar Harga:");

for (int jaja2 = 0; jaja2 < hrgarray2.Length; jaja2++)
{
    Console.WriteLine(hrgarray2[jaja2]);

    totalarrrtt2 = totalarrrtt2 + hrgarray2[jaja2];
}

Console.WriteLine("Total Harga: " + totalarrrtt2);

decimal[] bhr = new decimal[6];
decimal harggterbbsr = 0;
decimal harggterkcll = 0;
decimal harggtotll = 0;
decimal harggrattt = 0;

for (int bhhr = 0; bhhr < bhr.Length; bhhr++)
{
    Console.WriteLine("Masukkan Harga Barang");
    String inpttbhr = Console.ReadLine() ?? "0";

    if (!decimal.TryParse(inpttbhr, out decimal inputybhr))
    {
        Console.WriteLine("Input Harus Berupa Angka!!");
        bhhr--;
        continue;
    }
    if(inputybhr <= 0)
    {
        Console.WriteLine("Harga Harus Lebih Dari Nol!");
        bhhr--;
        continue;
    }
    bhr[bhhr] = inputybhr;

}
harggterbbsr = bhr[0];
harggterkcll = bhr[0];
harggtotll = 0;
harggrattt = bhr[0];

for (int harggttlrattt = 0; harggttlrattt < bhr.Length; harggttlrattt++)
{
    harggtotll = harggtotll + bhr[harggttlrattt];
}

harggrattt = harggtotll / bhr.Length;

Console.WriteLine("Harga Terbesar : " + harggterbbsr);
Console.WriteLine("Harga Terkecil : " + harggterkcll);
Console.WriteLine("Total Harga : " + harggtotll);
Console.WriteLine("Rata-Rata Harga : " + harggrattt);