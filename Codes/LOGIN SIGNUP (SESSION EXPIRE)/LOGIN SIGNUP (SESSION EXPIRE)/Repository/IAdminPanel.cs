

namespace BlogWebsite.Repository
{
    public interface IAdminPanel
    {
        AdminPanel Registration(AdminPanel AddUser);
        AdminPanel Login(string email, string password );
        bool EmailExists(string email);
    }
}
