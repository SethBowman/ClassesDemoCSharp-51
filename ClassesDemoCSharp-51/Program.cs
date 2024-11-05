using ClassesDemoCSharp_51;

public class Program
{
    public static void Main(string[] args)
    {
        var csharp51 = new Classroom();
        
        var seth = new Person();
        //Dot notation
        //seth.Name = "Seth";
        seth.Age = 30;
        seth.clothes = "t shirt and slacks";
        seth.wallet = 500.00;

        seth.Greet();
        
        csharp51.CodingClass.Add(seth);
        
        //Object initializer syntax
        var cruz = new Person()
        {
            Name = "Cruz",
            Age = 33,
            clothes = "hoodie",
            wallet = 100.00
        };
        
        cruz.Greet();
        
        csharp51.CodingClass.Add(cruz);
        
        //using a custom constructor
        var miah = new Person("Miah", 31, 5000.00, "hoodie");
        
        miah.Greet();
        
        csharp51.CodingClass.Add(miah);


        foreach (var student in csharp51.CodingClass)
        {
            Console.WriteLine($"Student: {student.Name} Age: {student.Age}");
        }
    }
}