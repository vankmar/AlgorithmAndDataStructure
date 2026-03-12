namespace control2
{
    internal class Program
    {
        static int n = 4;
        static int GetFibonacci(int n)
        {
            if (n < 0) return -1;
            int fibonacci = 0;
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                if (fibonacci == 0)
                    temp++;
                if (fibonacci >0)
                    temp = fibonacci;
                fibonacci += temp;
                i++;
            }
            return fibonacci;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetFibonacci(n));
        }
    }
}
