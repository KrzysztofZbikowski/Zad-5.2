class zad
{
    static bool sprawdz(double a, double b, double x)
    {
        if (x > a && x < b)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main(string[] args)
    {
        double a, b, x;
        Console.WriteLine("Podaj dolny zakres: ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj górny zakres: ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj twoją liczbę: ");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine(sprawdz(a, b, x));
        Console.ReadKey();
    }
}