using CustomIoCContainer_CSharp.Interfaces;

namespace CustomIoCContainer_CSharp.Implementations;

public class UserController
{
    private readonly IUserManager _userManager;

    public UserController(IUserManager userManager)
    {
        _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
    }

    public void AddUser(string username)
    {
        _userManager.AddUser(username);
    }

    public void PrintUsers()
    {
        _userManager.PrintUsers();
    }
}
