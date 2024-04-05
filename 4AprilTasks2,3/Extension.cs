public static class Extension
{
    public static long Factorial(this int number){
        if(number<0){
            System.Console.WriteLine("Eded menfi ola bilmez");
        }
    int factorial=1;
    for (int i = 1; i <=number; i++)
    {
        factorial*=i;
        
    }
    return factorial;

    }
    
}