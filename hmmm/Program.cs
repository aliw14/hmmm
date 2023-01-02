namespace hmmm;
class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        int count = 0;
        int[] numbers = { 5, 7, 10, 15 };
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 5 == 0)
            {
                sum += numbers[i];
                count++;
            }
        }Console.WriteLine(sum);
        Console.WriteLine(count);

        
    }
}

