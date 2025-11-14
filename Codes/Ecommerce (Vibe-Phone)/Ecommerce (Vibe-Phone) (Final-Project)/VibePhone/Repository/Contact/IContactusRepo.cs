namespace VibePhone.Repository.Contact
{
    public interface IContactusRepo
    {
        List<Contactus> GetAllContact();
        Contactus GetContactById(int id);
        Contactus AddContact(Contactus AddContact);
        Contactus DeleteContact(int id);
    }
}
