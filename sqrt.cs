internal class sqrt
{
    public static double MethodSqrt(double x, double target)
    {
        double oldx;
        do
        {
            oldx = x;
            x = (x + target / x) / 2;
        }
        while (oldx != x);
        Console.WriteLine("x= {0}", x);
        Console.WriteLine("x= {0}", x * x);
        return x;



    }
    private static void Main(string[] args)
    {
        double target = 2013;
        double x = 1;
        double result = MethodSqrt(x, target);
        
    }
}
    
