using System;
using System.Collections.Generic;
using System.Text;

public abstract class PinjamBuku
{
    private string namaAnggota { get; set; }
    private int idAnggota { get; set; }
    private string judulBuku { get; set; }
  
    public PinjamBuku(string namaAnggota, int idAnggota, string judulBuku)
    {
        this.namaAnggota = namaAnggota;
        this.idAnggota = idAnggota;
        this.judulBuku = judulBuku;
    }

  

    public abstract void hitungBiayaPinjam(decimal jumlah);
    
    public void TampilkanInfo()
    {
        Console.WriteLine($"{namaAnggota} dengan id {idAnggota} meminjam buku dengan judul {judulBuku}");
    }
    
}

class BukuReguler : PinjamBuku
{
    private static int idAnggota;
    private static string judulBuku;
    private static string namaAnggota;
    public int biayaPerHari;
    
    public BukuReguler (int biayaPerHari) : base(string namaAnggota, int idAnggota, string judulBuku)
    {
        this.biayaPerHari = biayaPerHari;
    }

    public override void hitungBiayaPinjam(decimal jumlah)
    {
        jumlah = 10 * 10000;
    }
    
    public void TampilkanInfo()
    {  
        Console.WriteLine($"biaya Peminjaman buku reguler {biayaPerHari}");
    }
}

class BukuReferensi : PinjamBuku
{
    private static int idAnggota;
    private static string judulBuku;
    private static string namaAnggota;
    public int biayaPerHari;
    public int biayaAsuransi;

    public BukuReferensi (int biayaPerHari, int biayaAsuransi, string namaAnggota1) : base(string namaAnggota, int idAnggota,string judulBuku)
    {
        this.biayaPerHari = biayaPerHari;
        this.biayaAsuransi = biayaAsuransi;
    }

    public override void hitungBiayaPinjam(decimal jumlah)
    {
        jumlah = (10 * 10000) + 20000;
    }



}








