using System;

class Program
{
    static void Main()
    {
        CovidConfig config = new CovidConfig();

        Console.WriteLine($"Berapa suhu badan anda saat ini? Dalam nilai {config.SatuanSuhu}");
        double suhu = double.Parse(Console.ReadLine());

        Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam?");
        int hariDeman = int.Parse(Console.ReadLine());

        if ((config.SatuanSuhu == "celcius" && suhu >= 36.5 && suhu <= 37.5) ||
            (config.SatuanSuhu == "fahrenheit" && suhu >= 97.7 && suhu <= 99.5) &&
            hariDeman < config.BatasHariDemam)
        {
            Console.WriteLine(config.PesanDiterima);
        }
        else
        {
            Console.WriteLine(config.PesanDitolak);
        }

        config.UbahSatuan();
        Console.WriteLine($"Dalam penggunaan program selanjutnya, akan digunakan satuan {config.SatuanSuhu}");
    }
}
