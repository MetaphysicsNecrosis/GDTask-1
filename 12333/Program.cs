namespace _12333
{
    internal class Program
    {
        static double getTask1(object[] array)
        {
            double answer = 0;
            foreach (var item in array)
            {
                if (item is String)
                {
                    foreach (char c in (String)item)
                    {
                        if (c >= 48 && c <= (48 + 9))
                        {
                            answer--;
                        }
                    }
                    continue;
                }
                answer += (int)item;
            }
            return answer;
        }
        static void Main(string[] args)
        {
            object[] array = { 1, 2, 3, 4, 5, "12f", "1234", "12345" };
            Console.WriteLine(getTask1(array));
            Console.ReadLine();
        }
    }
}