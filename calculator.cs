class Calculator
{
    static void Main(string[] args)
    {
        int a;
        int b;

        Console.WriteLine("Hasil pertambahan: {0} + {1} = {2}", a, b, Pertambahan(a, b));
        Console.WriteLine("Hasil pertambahan: {0} - {1} = {2}", a, b, Pengurangan(a, b));

        Console.WriteLine("\nTekan sembarang key untuk keluar");
		Console.Readkey();
    }

    static int Pertambahan(int a, int b)
    {
        return a + b;
    }
    static int Pengurangan(int a, int b)
    {
        return a - b;
    }
}
