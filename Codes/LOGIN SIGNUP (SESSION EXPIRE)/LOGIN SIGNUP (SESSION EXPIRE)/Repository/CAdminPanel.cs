
namespace BlogWebsite.Repository
{
    public class CAdminPanel : IAdminPanel
    {
        private readonly AdminPanelData AdminPanelRepo;
        public  CAdminPanel(AdminPanelData _AdminPanelData)
        {
            AdminPanelRepo = _AdminPanelData;
        }

        public AdminPanel Registration(AdminPanel AddUser)
        {
           AdminPanelRepo.AdminPanels.Add(AddUser);
           AdminPanelRepo.SaveChanges();
           return AddUser;
            
            
        }

        public AdminPanel Login(string email, string password)
        {
            return AdminPanelRepo.AdminPanels.FirstOrDefault(x => x.Email == email && x.Password == password);
        }

        public bool EmailExists(string email)
        {
            return AdminPanelRepo.AdminPanels.Any(x => x.Email.ToLower() == email.ToLower());
        }
    }
}
