namespace ClassesDemoCSharp_51;

public class Person
{
    //fields - a variable inside of a class (camelCase)
    public double wallet = 0;
    public string clothes;
    
    //properties - things that define the class (PascalCase)
    public string Name { get; set; } = "Bob";
    public int Age { get; set; }
    
    //methods (non static methods for now)
    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name}!");
    }
    
    //constructors
    
    //custom constructor
    public Person(string name, int age, double wallet, string clothes)
    {
        Name = name;
        Age = age;
        this.wallet = wallet;
        this.clothes = clothes;
    }

    //default constructor
    public Person()
    {
        
    }
    
}