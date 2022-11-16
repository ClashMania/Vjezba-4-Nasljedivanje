using System;
namespace nasljedjivanje_ponavljanje
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Izračunavanje opsega trokuta i četverokuta\r\n");
            Trokut trokut = new Trokut();
            Console.WriteLine("Unesi duljine stranica trokuta\r\n");
            trokut.UcitajStranice();
            Console.WriteLine("Opseg trokuta je: " + trokut.Opseg());

            Cetverokut cetverokut = new Cetverokut();
            Console.WriteLine("Unesi duljine stranica četverokuta\r\n");
            cetverokut.UcitajStranice();
            Console.WriteLine("Opseg četverokuta je: " + cetverokut.Opseg());

            Console.ReadKey();
        }

        class GeometrijskiLik
        {
            int brojStranica;
            double[] stranice = new double[10];

            

            public double Opseg()
            {
                double opseg = 0;
                for (int i = 0; i < brojStranica; i++)
                {
                    opseg = +stranice[i];
                }
                return opseg;
            }
            
            public void UcitajStranice()
            {
                for (int i = 0; i < brojStranica; i++)
                {
                    Console.WriteLine("Upišite duljinu {0} stranice: ", i + 1);
                    string s = Console.ReadLine();
                    stranice[i] = Convert.ToDouble(s);
                }

            }

            public int BrojStranica { get => brojStranica; set => brojStranica = value; }
            public double[] Stranice { get => stranice; set => stranice = value; }
        }

        class Trokut : GeometrijskiLik
        {
            public Trokut()
            {
                BrojStranica = 3;
            }

        }

        class Cetverokut : GeometrijskiLik
        {
            public Cetverokut()
            {
                BrojStranica = 4;
            }



        }

    }
}
