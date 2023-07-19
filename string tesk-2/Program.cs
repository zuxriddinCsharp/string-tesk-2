namespace string_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine();

            string[] name = fullName.Split(' ');

            char[] chars = name[0].ToCharArray();

            char[] chars1 = name[1].ToCharArray();

            Console.WriteLine($"Result:  {chars[0]}.{chars1[0]}.{name[2]}");
        }
    }
}