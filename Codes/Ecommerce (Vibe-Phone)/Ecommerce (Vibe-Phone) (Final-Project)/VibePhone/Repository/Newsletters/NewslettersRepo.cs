namespace VibePhone.Repository.Newsletters
{
    public class NewslettersRepo : INewslettersRepo
    {
        private readonly DBCONTEXT _DBCONTEXT;

        public NewslettersRepo(DBCONTEXT context)
        {
            _DBCONTEXT = context;
        }

        //  ====================================================================
        //                                GetAllNewsletters
        //    ====================================================================
        public List<Newsletter> GetAllNewsletter()
        {
            var list = _DBCONTEXT.Newsletters.ToList();
            return list;
        }


        //  ====================================================================
        //                                GetNewsletterById
        //    ====================================================================
        public Newsletter GetNewsletterById(int id)
        {
            var find = _DBCONTEXT.Newsletters.FirstOrDefault(x => x.Id == id);
            return find;
        }


        //  ====================================================================
        //                                AddNewsletter
        //    ====================================================================
        public Newsletter AddNewsletter(Newsletter AddNewsletter)
        {
            _DBCONTEXT.Newsletters.Add(AddNewsletter);
            _DBCONTEXT.SaveChanges();
            return AddNewsletter;
        }


        //  ====================================================================
        //                                UpdateNewsletter
        //    ====================================================================
        public Newsletter UpdateNewsletter(Newsletter UpdateNewsletter)
        {
            _DBCONTEXT.Newsletters.Update(UpdateNewsletter);
            _DBCONTEXT.SaveChanges();
            return UpdateNewsletter;
        }


        //  ====================================================================
        //                                DeleteNewsletter
        //    ====================================================================
        public Newsletter DeleteNewsletter(int id)
        {
            var find = GetNewsletterById(id);
            if (find != null)
            {
                _DBCONTEXT.Newsletters.Remove(find);
                _DBCONTEXT.SaveChanges();
                return find;
            }
            return null;
        }
    }
}
