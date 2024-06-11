namespace Library;

public class Publisher
{
    public string Name { get; set; }
    public string CodeIsbn { get; set; }
    
    public Publisher(string name, string codeIsbn)
    {
        Name = name;
        CodeIsbn = codeIsbn;
    }
}