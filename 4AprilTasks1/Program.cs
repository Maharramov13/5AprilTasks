internal class Program
{
    public static void Main(string[] args)
    {
        int num=23;

        if(PrimeChecker.IsPrimeStatic(num)){
            System.Console.WriteLine(num+"is prime(using static method).");
        }
        else
        {
            System.Console.WriteLine(num+"is not prime(using static method)");
        }

        if(num.IsPrimeExtension()){
            System.Console.WriteLine(num+"is prime(using extension method)");
        }
        else
        {
            System.Console.WriteLine(num+"is not prime(using extension method)");
        }
    }
}