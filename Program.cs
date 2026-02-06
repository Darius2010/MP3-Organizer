using System;

namespace MP3_Sortierung
{
    class Program
    {
        public static string[] GetFiles(string path)
        {
            return System.IO.Directory.GetFiles(path);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Starte MP3 Suche...");

            string MusiKPfad = @"C:\Users\Darius\Music\";

            string[] GefundenerPfad = GetFiles(MusiKPfad);

            Console.WriteLine($"{GefundenerPfad.Length} Lieder gefunden in {MusiKPfad}");
            Console.WriteLine("-----------------------------");

            foreach (string Datei in GefundenerPfad)
            {
                Console.WriteLine(Datei);
            }
        }
    }
}