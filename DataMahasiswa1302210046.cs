using System;
using System.Text.Json;

namespace tpmodul7_kelompok_4
{
	public class DataMahasiswa1302210046
	{
		public void ReadJSON()
		{
            String jsonString = File.ReadAllText("/Users/muhammadzulfadly/Documents/GitHub/tpmodul7_kelompok_4/tp7_1_1302210046.json");

            Mahasiswa mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

            Console.WriteLine("Nama {0:s} {1:s} dengan nim {2:d} dari fakultas {3:s}",
                    mahasiswa.nama.depan, mahasiswa.nama.belakang, mahasiswa.nim, mahasiswa.fakultas);
        }
	}

    public class Mahasiswa
    {
        public Nama nama { get; set; }
        public int nim { get; set; }
        public string fakultas { get; set; }
        public Mahasiswa() { }
    public Mahasiswa(Nama nama, int nim, string fakultas)
    {
        this.nama = nama;
        this.nim = nim;
        this.fakultas = fakultas;
    }
    }

    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
        public Nama() { }
        public Nama(string depan, string belakang)
        {
            this.depan = depan;
            this.belakang = belakang;
        }
    }
}

