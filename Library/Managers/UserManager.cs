using Library.Interfaces;
namespace Library;

public class UserManager : IUserManager
{
    private List<User> _users = new List<User>();
    
    public void AddUser(User user)
    {
        if (user == null)
        {
            throw new ArgumentNullException("O objeto user não pode ser nulo");
        };
        if (user.Id == FindUser(user.Id).Id)
        {
            throw new ArgumentException("O ID informado ja existe");
        };

        _users.Add(user);
        Console.WriteLine("O usário foi adicionado com sucesso");
    }

    public void RemoveUser(int userId)
    {
        if (userId == null)
        {
            throw new ArgumentNullException("O ID não pode ser nulo");
        }
        if (FindUser(userId) == null)
        {
            throw new ArgumentException("O ID informado não existe");
        }

        _users.Remove(FindUser(userId));
        
        Console.WriteLine("O usário foi removido com sucesso");
    }

    public void ListUsers()
    {
        if (_users.Count == 0)
        {
            Console.WriteLine("Nenhum usário foi adicionado");
            return;
        };
        Console.WriteLine("Todos os usários: \n");
        _users.ForEach(user => user.DisplayDetails());
    }

    public User FindUser(int userId)
    {
        return _users.First(user => user.Id == userId);
    }
}