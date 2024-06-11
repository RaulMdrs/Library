namespace Library.Interfaces;

public interface IUserManager
{
    void AddUser(User user);
    void RemoveUser(int userId);
    void ListUsers();
    User FindUser(int userId);
}