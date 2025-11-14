namespace VibePhone.Repository.UserRepo
{
    public interface IUserRepo
    {
        List<UserRegistration> GetAllUsers();
        UserRegistration GetUserById(int id);
        UserRegistration AddUser(UserRegistration AddUser);
        UserRegistration UpdateUser(UserRegistration UpdateUser);
        UserRegistration DeleteUser(int id);
        UserRegistration ValidateUser(string email, string password);
    }
}
