using System;

class MethodExample
{
    int number;

    // Methods useful for side effects
    public void SomeMethod(int newValue)
    {
        this.number = newValue;
    }

    public void AnotherMethod()
    {
        Console.WriteLine(this.number);
    }

    // Method useful for value
    public int Add(int x)
    {
        return x + this.number;
    }
}


    class Program
    {
        static void Main(string[] args)
        {
        }
    }

