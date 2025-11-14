namespace VibePhone.Repository.AdminRepo
{
    public class AdminRepo : IAdminRepo
    {
        private readonly DBCONTEXT _DBCONTEXT;

        public AdminRepo(DBCONTEXT context)
        {
            _DBCONTEXT = context;
        }

             //  ====================================================================
            //                                GetAllAdmin
           //    ====================================================================

        public List<AdminRegistration> GetAllAdmin()
        {
            var list = _DBCONTEXT.AdminRegistrations.ToList();
            return list;
        }

            //  ====================================================================
           //                                GetAdminById
          //    ====================================================================

        public AdminRegistration GetAdminById(int id)
        {
            var Find = _DBCONTEXT.AdminRegistrations.FirstOrDefault(x => x.Id == id);
            return Find;
        }
        
        //  ====================================================================
        //                                AddAdmin
        //    ====================================================================

        public AdminRegistration AddAdmin(AdminRegistration AddAdmin)
        {
            var Add = _DBCONTEXT.AdminRegistrations.Add(AddAdmin);
            _DBCONTEXT.SaveChanges();
            return AddAdmin;
        }
        
        //  ====================================================================
        //                                UpdateAdmin
        //    ====================================================================

        public AdminRegistration UpdateAdmin(AdminRegistration UpdateAdmin)
        {
            var Update = _DBCONTEXT.AdminRegistrations.Update(UpdateAdmin);
            _DBCONTEXT.SaveChanges();
            return UpdateAdmin;
        }
       
        //  ====================================================================
        //                                DeleteAdmin
        //    ====================================================================

        public AdminRegistration DeleteAdmin(int id)
        {
            var Find = GetAdminById(id);
            if (Find != null)
            {

                _DBCONTEXT.AdminRegistrations.Remove(Find);
                _DBCONTEXT.SaveChanges();
                return Find;
            }
            return null;
        }

        //  ====================================================================
        //                                ValidateAdmin
        //    ====================================================================
        public AdminRegistration ValidateAdmin(string email, string password)
        {
            var validate = _DBCONTEXT.AdminRegistrations.FirstOrDefault(u => u.Email == email && u.Password == password);
            return validate;
        }
    }
}


