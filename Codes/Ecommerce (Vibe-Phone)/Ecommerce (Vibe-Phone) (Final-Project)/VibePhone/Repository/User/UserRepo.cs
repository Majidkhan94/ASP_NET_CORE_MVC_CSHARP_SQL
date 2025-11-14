namespace VibePhone.Repository.UserRepo
{
    public class UserRepo : IUserRepo
    {
        private readonly DBCONTEXT _DBCONTEXT;

        public UserRepo(DBCONTEXT context)
        {
            _DBCONTEXT = context;
        }
        
        //  ====================================================================
        //                                GetAllUsers
        //    ====================================================================
        public List<UserRegistration> GetAllUsers()
        {
            var list = _DBCONTEXT.UserRegistrations.ToList();
            return list;
        }

        //  ====================================================================
        //                                GetUserById
        //    ====================================================================
        public UserRegistration GetUserById(int id)
        {
            var Find = _DBCONTEXT.UserRegistrations.FirstOrDefault(x => x.Id == id);
            return Find;
        }

        //  ====================================================================
        //                                AddUser
        //    ====================================================================
        public UserRegistration AddUser(UserRegistration AddUser)
        {
            var Add = _DBCONTEXT.UserRegistrations.Add(AddUser);
            _DBCONTEXT.SaveChanges();
            return AddUser;
        }
       
        //  ====================================================================
        //                                UpdateUser
        //    ====================================================================
        public UserRegistration UpdateUser(UserRegistration UpdateUser)
        {
            var Update = _DBCONTEXT.UserRegistrations.Update(UpdateUser);
            _DBCONTEXT.SaveChanges();
            return UpdateUser;
        }
        
        //  ====================================================================
        //                                DeleteUser
        //    ====================================================================
        public UserRegistration DeleteUser(int id)
        {
            var Find = GetUserById(id);
            if (Find != null) {

                _DBCONTEXT.UserRegistrations.Remove(Find);
                _DBCONTEXT.SaveChanges();
                return Find;
            }
            return null;

        }
        
        //  ====================================================================
        //                                ValidateUser
        //    ====================================================================
        public UserRegistration ValidateUser(string email, string password)
        {
            var validate = _DBCONTEXT.UserRegistrations.FirstOrDefault(u => u.Email == email && u.Password == password);
            return validate;
        }
    }
}
