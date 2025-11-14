namespace VibePhone.Repository.Newsletters
{
    public interface INewslettersRepo
    {
        List<Newsletter> GetAllNewsletter();
        Newsletter GetNewsletterById(int id);
        Newsletter AddNewsletter(Newsletter AddNewsletter);
        Newsletter UpdateNewsletter(Newsletter UpdateNewsletter);
        Newsletter DeleteNewsletter(int id);
    }
}
