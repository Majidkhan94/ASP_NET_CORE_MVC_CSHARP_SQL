using VibePhone.Services;

namespace VibePhone.Repository.Contact
{
    public class ContactusRepo : IContactusRepo
    {
        private readonly DBCONTEXT _DBCONTEXT;

        public ContactusRepo(DBCONTEXT context)
        {
            _DBCONTEXT = context;
        }

        // ====================================================================
        //                               GetAllContact
        // ====================================================================
        public List<Contactus> GetAllContact()
        {
            var list = _DBCONTEXT.ContactUS.ToList();
            return list;
        }

        // ====================================================================
        //                               GetContactById
        // ====================================================================
        public Contactus GetContactById(int id)
        {
            var find = _DBCONTEXT.ContactUS.FirstOrDefault(x => x.Id == id);
            return find;
        }

        // ====================================================================
        //                               AddContact
        // ====================================================================
        public Contactus AddContact(Contactus AddContact)
        {
            if (AddContact != null)
            {
                _DBCONTEXT.ContactUS.Add(AddContact);
                _DBCONTEXT.SaveChanges();
                return AddContact;
            }
            return null;
        }

        // ====================================================================
        //                               DeleteContact
        // ====================================================================
        public Contactus DeleteContact(int id)
        {
            var find = GetContactById(id);
            if (find != null)
            {
                _DBCONTEXT.ContactUS.Remove(find);
                _DBCONTEXT.SaveChanges();
                return find;
            }
            return null;
        }
    }
}
