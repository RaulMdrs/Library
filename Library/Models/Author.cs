namespace Library;
public class Author
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Birthplace { get; set; }
    public Author(string name, int age, string birthplace)
    {
        if (name == null)
        {
            throw new ArgumentNullException("O nome não pode ser nulo");
        }

        if (age <= 0)
        {
            throw new ArgumentException("A idade deve ser maior que zero");
        }
            
        Name = name;
        Age = age < 0 ? 0 : age;
        Birthplace = birthplace ?? "Não informado";
    }
    public override string ToString()
    {
        return $"{Name}, {Age}, {Birthplace}";
    }
    
    public void Print()
    {
        Console.WriteLine(ToString());
    }
    
}