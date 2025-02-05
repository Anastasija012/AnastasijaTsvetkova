namespace FigurePindala
//Anastasija Tsvetkova TITge24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisestage figure (Ruut/ring/ristkülik): ");
            Console.WriteLine(" ");

            string figure = Console.ReadLine();

            switch (figure)
            {
                case "ring":
                case "Ring":
                    Console.WriteLine(" ");
                    Console.WriteLine("Ringi suurus: ");
                    double ri = Convert.ToInt32(Console.ReadLine());
                    double Ripindala = Math.PI * ri * ri;
                    Console.WriteLine("Ringi pindala: " + Ripindala);
                    break;

                case "ruut":
                case "Ruut":
                    Console.WriteLine(" ");
                    Console.WriteLine("Ruudu suurus: ");
                    double ru = Convert.ToInt32(Console.ReadLine());
                    double Rupindala = ru * ru;
                    Console.WriteLine("Ruudu pindala: " + Rupindala);
                    break;

                case "ristkülik":
                case "Ristkülik":
                    Console.WriteLine(" ");
                    Console.WriteLine("Ristkülik suurus: ");
                    double r = Convert.ToInt32(Console.ReadLine());
                    double st = Convert.ToInt32(Console.ReadLine());
                    double Rikpindala = r * st;
                    Console.WriteLine("Ristkülik pindala: " + Rikpindala);
                    break;

                default:
                    Console.WriteLine(" ");
                    Console.WriteLine("Vale");
                    break;
            }
        }
    }
}

