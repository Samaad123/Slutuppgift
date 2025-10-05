namespace Slutuppgift;

class User
{
    public string Email;
    public string _password;

    //konstruktör
    public User(string email, string password)
    {
        Email = email;
        _password = password;

    }
    
    // Getter methods for Email and Password
    public string GetUserEmail() => Email;
    public string GetPassword() => _password;


 
}


