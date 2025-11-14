namespace VibePhone.Repository.AdminRepo
{
    public interface IAdminRepo
    {
        List<AdminRegistration> GetAllAdmin();
        AdminRegistration GetAdminById(int id);
        AdminRegistration AddAdmin(AdminRegistration AddAdmin);
        AdminRegistration UpdateAdmin(AdminRegistration UpdateAdmin);
        AdminRegistration DeleteAdmin(int id);
        AdminRegistration ValidateAdmin(string email, string password);
    }
}
