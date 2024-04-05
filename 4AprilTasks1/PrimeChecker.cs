using System.Globalization;

public static class PrimeChecker
{
    public static bool IsPrimeStatic(int number){
        if(number<=1) {
            return false;
        }

        for (int i = 2; i < Math.Sqrt(number); i++)
        {
           if (number%i==0)
           {
            return false;
            
           } 
            
        }
        return true;
        
    }

    public static bool IsPrimeExtension(this int number)
    {
        if (number<=1){
            return false;
        }
        for (int i = 2; i < Math.Sqrt(number); i++)
        {
            if (number%i==0)
            {
                return false;
            }
            
        }
        return true;

        
    }
    

    
}