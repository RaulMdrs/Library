namespace Library;

public class User
{
    public string Name;
    public string Email;
    public int Id;
    
    public User(string name, string email, int id)
    {
        if (name == null)
        {
            throw new ArgumentNullException("O nome não pode ser nulo");
        }
        if (email == null)
        {
            throw new ArgumentNullException("O email não pode ser nulo");
        }
        if (id == null)
        {
            throw new ArgumentNullException("O ID não pode ser nulo");
        }
        
        Name = name;
        Email = email;
        Id = id;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine("Nome: " + Name + "\nEmail: " + Email + "\nID: " + Id);
    }
}