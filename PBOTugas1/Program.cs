public class Program
{
    public static void Main(string[] args)
    {
        KebunBinatang kebunBinatang = new KebunBinatang();

        Singa singa = new Singa("Griff", 7);
        Gajah gajah = new Gajah("Ele", 3);
        Ular ular = new Ular("Sissy", 4, 5.5);
        Buaya buaya = new Buaya("Broski", 5, 4.0);

        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);

        kebunBinatang.DaftarHewan();

        Console.WriteLine(singa.Suara());
        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara());
        Console.WriteLine(buaya.Suara());

        singa.Mengaum();
        ular.Merayap();

        Reptil reptil = new Buaya("Ngabski", 6, 4.5);
        Console.WriteLine(reptil.Suara());
    }
}

public class Hewan
{
    public string Nama;
    public int Umur;

    public Hewan(string Nama, int Umur)
    {
        this.Nama = Nama;
        this.Umur = Umur;
    }

    public virtual string Suara()
    {
       return "Hewan ini bersuara";
    }

    public virtual string InfoHewan()
    {
        return $"Nama: {Nama}, Umur: {Umur}";
    }
}


public class Mamalia : Hewan
{
    public int jumlahKaki;

    public Mamalia(string Nama, int Umur, int jumlahKaki) : base(Nama, Umur)
    {
        this.jumlahKaki = jumlahKaki;
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Jumlah Kaki: {jumlahKaki}";
    }
}

public class Reptil : Hewan
{
    public double panjangTubuh;

    public Reptil(string Nama, int Umur, double panjangTubuh) : base(Nama, Umur)
    {
        this.panjangTubuh = panjangTubuh;
    }
}

public class Singa : Mamalia
{
    public Singa(string Nama, int Umur) : base(Nama, Umur, 4)
    {
    }

    public override string Suara()
    {
        return "Singa mengaum";
    }

    public void Mengaum()
    {
        Console.WriteLine($"{Nama} sedang mengaum");
    }
}

public class Gajah : Mamalia
{
    public Gajah(string Nama, int Umur) : base(Nama, Umur, 4)
    {
    }

    public override string Suara()
    {
        return "Gajah bersuara seperti terompet";
    }
}

public class Ular : Reptil
{
    public Ular(string Nama, int Umur, double panjangTubuh) : base(Nama, Umur, panjangTubuh)
    {
    }

    public override string Suara()
    {
        return "Ular mendesis";
    }

    public void Merayap()
    {
        Console.WriteLine($"{Nama} sedang merayap");
    }
}

public class Buaya : Reptil
{
    public Buaya(string Nama, int Umur, double panjangTubuh) : base(Nama, Umur, panjangTubuh)
    {
    }

    public override string Suara()
    {
        return "Buaya menggeram";
    }
}

public class KebunBinatang
{
    private List<Hewan> koleksiHewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        Console.WriteLine("Daftar hewan di kebun binatang:");
        foreach (Hewan hewan in koleksiHewan)
        {
            Console.WriteLine(hewan.InfoHewan());
        }
    }
}
