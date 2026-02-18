public class Hello
{
    public void SayHello()
    {
        Console.WriteLine("Hello, World from Hello class!");
    }
}

class Program
{
    static void Main()
    {
        Hello hello = new Hello();
        hello.SayHello();
    }
}
