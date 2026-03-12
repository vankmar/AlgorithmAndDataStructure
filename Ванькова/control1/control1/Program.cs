namespace control1
{
    internal class Program
    {
        static int[] test1 = { 1,2,2,3,4,5};
        static bool IsAscending(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] >= array[i + 1] )
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            if (IsAscending(test1) == true)
            {
                Console.WriteLine("Массив возрастает");
            }
            else
            {
                Console.WriteLine("Массив не возрастает");
            }
        }
    }
}
