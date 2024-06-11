namespace Library;

public class Admin : User
{
    public int AccessLevel;
    
    public Admin(string name, string email, int id, int accessLevel) : base(name, email, id)
    {
        AccessLevel = accessLevel;
    }
    
    public override void DisplayDetails()
    {
        Console.WriteLine("Nome: " + Name + "\nEmail: " + Email + "\nID: " + Id + "\nNível de acesso: " + AccessLevel);
    }
}