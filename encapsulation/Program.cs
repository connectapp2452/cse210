namespace encapsulation
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Hello world this is hard oo but we keep pushing...");
        }
        Person person1 = new Person();
        person1.SetFirstName("Joy");

        Console.WriteLine(person1.GetFirstName());
    }
}