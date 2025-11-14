namespace BlogWebsite.Repository
{
    public interface IUserlogin
    {
        Userlogin UserRegistration(Userlogin Registration);
        Userlogin UserLogin(String email, string password);
        bool EmailExists(string email);


    }
}
