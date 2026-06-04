using System;
using System.Collections.Generic;

public abstract class PinjamBuku
{
    private string namaAnggota;
    private string idAnggota;
    private string judulBuku;

    public string NamaAnggota
    {
        get { return namaAnggota; }
        set { namaAnggota = value; }
    }

    public string IdAnggota
    {
        get { return idAnggota; }
        set { idAnggota = value; }
    }

    public string JudulBuku
    {
        get { return judulBuku; }
        set { judulBuku = value; }
    }

    public PinjamBuku(string namaAnggota, string idAnggota, string judulBuku)
    {
        this.namaAnggota = namaAnggota;
        this.idAnggota = idAnggota;
        this.judulBuku = judulBuku;
    }

    public abstract int HitungBiayaPinjam(int lamaHari);

    public virtual void TampilInfo()
    {
        Console.WriteLine($"Anggota: {namaAnggota} | ID: {idAnggota} | Buku: {judulBuku}");
    }
}

class BukuReguler : PinjamBuku
{
    public int BiayaPerHari { get; set; }

    public BukuReguler(string namaAnggota, string idAnggota, string judulBuku, int biayaPerHari)
        : base(namaAnggota, idAnggota, judulBuku)
    {
        this.BiayaPerHari = biayaPerHari;
    }

    public override int HitungBiayaPinjam(int lamaHari)
    {
        return lamaHari * BiayaPerHari;
    }
}

class BukuReferensi : PinjamBuku
{
    public int BiayaPerHari { get; set; }
    public int BiayaAsuransi { get; set; }

    public BukuReferensi(string namaAnggota, string idAnggota, string judulBuku, int biayaPerHari, int biayaAsuransi)
        : base(namaAnggota, idAnggota, judulBuku)
    {
        this.BiayaPerHari = biayaPerHari;
        this.BiayaAsuransi = biayaAsuransi;
    }

    public override int HitungBiayaPinjam(int lamaHari)
    {
        return (lamaHari * BiayaPerHari) + BiayaAsuransi;
    }
}

class RiwayatPinjam
{
    public string JenisBuku { get; set; }
    public int LamaHari { get; set; }
    public string TanggalPinjam { get; set; }

    private static List<RiwayatPinjam> daftarRiwayat = new List<RiwayatPinjam>();

    public RiwayatPinjam(string jenisBuku, int lamaHari, string tanggalPinjam)
    {
        this.JenisBuku = jenisBuku;
        this.LamaHari = lamaHari;
        this.TanggalPinjam = tanggalPinjam;
    }

    public void TambahPinjam()
    {
        daftarRiwayat.Add(this);
    }

    public static void CetakRiwayat()
    {
        for (int i = 0; i < daftarRiwayat.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {daftarRiwayat[i].JenisBuku} | {daftarRiwayat[i].LamaHari} hari | {daftarRiwayat[i].TanggalPinjam}");
        }
    }

    public override string ToString()
    {
        return $"{JenisBuku} | {LamaHari} hari | {TanggalPinjam}";
    }
}

