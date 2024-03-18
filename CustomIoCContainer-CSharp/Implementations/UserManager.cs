using CustomIoCContainer_CSharp.Interfaces;

namespace CustomIoCContainer_CSharp.Implementations;

public class UserManager : IUserManager
{
    private readonly List<string> _users;
    
    public UserManager()
    {
        _users = new List<string>();
    }

    public void AddUser(string username)
    {
        _users.Add(username);
    }

    public void PrintUsers()
    {
        foreach (var user in _users)
        {
            Console.WriteLine(user);
        }
    }
}