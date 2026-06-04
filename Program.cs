class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        BukuReferensi buku1 = new BukuReferensi("Joko", "A102", "Ensiklopedia", 5000, 20000);

        int lamaHari = 5;
        int totalBiaya = buku1.HitungBiayaPinjam(lamaHari);

        buku1.TampilInfo();
        Console.WriteLine($"Total Biaya: Rp {totalBiaya}");

        RiwayatPinjam riwayat = new RiwayatPinjam("Referensi", lamaHari, "15-10-2025");
        riwayat.TambahPinjam();
        RiwayatPinjam.CetakRiwayat();
    }
}