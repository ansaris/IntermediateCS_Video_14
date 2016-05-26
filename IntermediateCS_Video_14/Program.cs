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
    //public int Add(int x)
    //{
    //    return x + this.number;
    //}

    // C# 6.0 adds this new concise syntax for very 
    // simple methods:

    public int Add(int x) => x + this.number;

    // C# 4.0 added the ability to make arguments optional
    // but this technique sparingly

    public void OptionalArgumentMethod(int x = 10, string y = "Hello")
    {
        Console.WriteLine($"{x} {y} {this.number}");
    }

    // Optional arguments must come at the end


}


class Program
{
    static void Main()
    {
        var example = new MethodExample();

        example.OptionalArgumentMethod();
        example.OptionalArgumentMethod(12);
        example.OptionalArgumentMethod(y: "Goodbye");

        // example.ParamsMethod("required", "one", "two");
    }
}

