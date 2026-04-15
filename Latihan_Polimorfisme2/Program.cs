using System;

class MetodePembayaran
{
    public virtual void Bayar(int jumlah)
    {
        Console.WriteLine("Memproses pembayaran...");
    }
}

class BankTransfer : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine("Silahkan transfer sejumlah Rp " + jumlah + " ke nomor 12345678");
    }
}

class EWallet : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine("Saldo terpotong sejumlah Rp " + jumlah);
    }
}

class KartuKredit : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine("Transaksi sejumlah Rp " + jumlah + " berhasil dilakukan");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("-----Simulasi Checkout-----");
        Console.WriteLine("Pilih metode:");
        Console.WriteLine("1. Bank Transfer");
        Console.WriteLine("2. E-Wallet");
        Console.WriteLine("3. Kartu Kredit");

        Console.Write("Pilihan Anda (1/2/3): ");
        int pilihan = int.Parse(Console.ReadLine());

        int jumlah = 100000;
        MetodePembayaran pembayaran = null;

        if (pilihan == 1)
            pembayaran = new BankTransfer();
        else if (pilihan == 2)
            pembayaran = new EWallet();
        else if (pilihan == 3)
            pembayaran = new KartuKredit();
        else
        {
            Console.WriteLine("Pilihan tidak valid");
            return;
        }

        pembayaran.Bayar(jumlah);
    }
}