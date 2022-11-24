namespace HelloWorld
{
    class Program
    {
        static int[] DiakokTMB = new int[17];
        static int[] DiakokMagassagaTMB = new int[17];
        static double[] DiakokTanulmanyaTMB = new double[17];
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Beugro1();
            DiakokAdati();
        }

        private static void DiakokAdati()
        {
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat8();
            Feladat7();
            Feladat9();
        }

        private static void Feladat9()
        {
            Console.WriteLine("\nFeladat 9: 7 méter a cél");
        }

        private static void Feladat7()
        {
            Console.WriteLine("\nFeladat 7: Volt-e átlag feletti magasság");
        }

        private static void Feladat8()
        {
            Console.WriteLine("\nFeladat 8: Rendezés");
            int Csere;
            for (int i = 0; i < DiakokTMB.Length; i++)
            {
                for (int j = 0; j < DiakokTMB.Length - 1; j++)
                {
                    if (DiakokTMB[j] > DiakokTMB[j + 1])
                    {
                        Csere = DiakokTMB[j];
                        DiakokTMB[j] = DiakokTMB[j + 1];
                        DiakokTMB[j + 1] = Csere;
                    }
                }
            }
            for (int i = 0;i < DiakokTMB.Length; i++)
            { Console.WriteLine($"{i + 1} Diákok magassága: {DiakokMagassagaTMB[i]} cm -> Átlaga: {DiakokTanulmanyaTMB[i]:0.00}"); }
        }

        private static void Feladat5()
        {
            Console.WriteLine("\nFeladat 5: A legmagasabb diák sorszáma és átlaga");
            double MaxMagassag = DiakokMagassagaTMB.Max();
            int MaxSorszama = 0;
            int MaxAtlag = 0;
            for (int i = 0; i < 17; i++)
            {
                if (MaxMagassag == DiakokMagassagaTMB[i])
                {
                    MaxSorszama = i + 1;
                }
                MaxAtlag = i + 1;
            }
            Console.WriteLine($"Magassága: {MaxMagassag} cm");
            Console.WriteLine($"Sorszáma: {MaxSorszama}");
            Console.WriteLine($"Átlaga: {MaxAtlag}");
        }

        private static void Feladat4()
        {
            Console.WriteLine("\nFeladat 4: Átlag magasság");
            int AtlagMagassag = 0;
            for (int i = 0; i < 17; i++)
            {
                AtlagMagassag = DiakokMagassagaTMB[i];
            }
            double AtlagDiakokMagassaga = (double) AtlagMagassag / DiakokMagassagaTMB.Length;
            Console.WriteLine($"A diákok átlag magassága: {AtlagDiakokMagassaga:0.00}");
        }

        private static void Feladat3()
        {
            Console.WriteLine("\nFeladat 3: Átmentek száma");
            int darab = 0;
            for (int i = 0; i < DiakokTanulmanyaTMB.Length; i++)
            {
                darab++;
            }
            Console.WriteLine($"Ennyi diák ment át a tanév végén: {darab}");
        }

        private static void Feladat2()
        {
            Console.WriteLine("\nFeladat 2: Kiiratás");
            for (int i = 0; i < 17; i++)
            {
                Console.WriteLine($"{i + 1} Diák magassága: {DiakokMagassagaTMB[i]} cm -> Átlaga: {DiakokTanulmanyaTMB[i]:0.00}");
            }
        }

        private static void Feladat1()
        {
            Console.WriteLine("\nFeladat 1: Tömbök feltöltése");
            for (int i = 0;i < 17; i++)
            {
                DiakokTMB[i] = rnd.Next(1, 17);
                DiakokMagassagaTMB[i] = rnd.Next(155, 205);
                DiakokTanulmanyaTMB[i] = rnd.Next(1, 5);
            }
        }

        private static void Beugro1()
        {
            Console.WriteLine("Beugró 1:");
            int[] MunkaTMB = { 23, 62, 62, 92, 73, 45, 32, 25, 96, 58, 99, 42, 72, 40 };
            int CsereSzam;
            for (int i = 0; i < MunkaTMB.Length; i++)
            {
                for (int j = 0; j < MunkaTMB.Length - 1; j++)
                {
                    if (MunkaTMB[j] > MunkaTMB[j + 1])
                    {
                        CsereSzam = MunkaTMB[j];
                        MunkaTMB[j] = MunkaTMB[j + 1];
                        MunkaTMB[j + 1] = CsereSzam;
                    }
                }
            }
            for (int i = 0;i < MunkaTMB.Length; i++)
            { Console.WriteLine($"{MunkaTMB[i]}, "); }
        }
    }
}