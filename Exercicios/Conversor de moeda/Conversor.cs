namespace ConsoleApp1
{
    public class Conversor
    {
        static double IoF = 6.0;
        public static double Converte(double d, double q)
        {
            double total =  (d * q) ;
            return total + total * IoF / 100.0;
        }
    }
}
