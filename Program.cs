namespace ConcatenateData
{
    public class Program
    {
        static void Main(string[] args)
        {
            string firstName=Console.ReadLine();
            string lastName=Console.ReadLine();
            int age=int.Parse(Console.ReadLine());
            string town=Console.ReadLine();
            if (age > 1)
            {
                Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
            }
            else if( age < 1)
            {
                Console.WriteLine("Invalid number of age! Please try again.");
            }
            else
            {
                Console.WriteLine($"You are {firstName} {lastName}, a {age}-year old person from {town}.");
            }
        }
    }
}
