
namespace BlogWebsite.Repository
{
    public class CUserlogin : IUserlogin
    {
        private readonly DBCONTEXT _ContextRepo;
        public CUserlogin(DBCONTEXT _CONTEXT)
        {
            _ContextRepo = _CONTEXT;
        }
        public Userlogin UserRegistration(Userlogin Registration)
        {
            _ContextRepo.Userlogin.Add(Registration);
            _ContextRepo.SaveChanges();
            return Registration;
        }
        public Userlogin UserLogin(string email, string password)
        {
            return _ContextRepo.Userlogin.FirstOrDefault(U => U.Email==email && U.Password == password);
        }

        public bool EmailExists(string email)
        {
            return _ContextRepo.Userlogin.Any(x => x.Email.ToLower() == email.ToLower());
        }
    }
}
