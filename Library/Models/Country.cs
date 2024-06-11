namespace Library;

public class Country
{
    public string Name { get; }
    public string CodeIsbn { get; }
    
    public Country(string name, string codeIsbn)
    {
        Name = name;
        CodeIsbn = codeIsbn;
    }

    public void Print()
    {
        Console.WriteLine(Name);
    }
}