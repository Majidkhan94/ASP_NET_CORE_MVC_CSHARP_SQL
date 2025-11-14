namespace VibePhone.Repository.Blogs
{
    public class BlogRepo : IBlogRepo
    {
        private readonly UploadImages _UploadImages;
        private readonly DBCONTEXT _DBCONTEXT;
        private readonly IMapper _Mapper;

        public BlogRepo(DBCONTEXT context, UploadImages uploadImages, IMapper mapper)
        {
            _DBCONTEXT = context;
            _UploadImages = uploadImages;
            _Mapper = mapper;
        }

        // ====================================================================
        //                               GetAllBlog
        // ====================================================================
        public List<Blog> GetAllBlog()
        {
            var list = _DBCONTEXT.Blogs.Include(x => x.Category).ToList();
            return list;
        }

        // ====================================================================
        //                               GetBlogById
        // ====================================================================
        public Blog GetBlogById(int id)
        {
            var find = _DBCONTEXT.Blogs.FirstOrDefault(x => x.Id == id);
            return find;
        }

        // ====================================================================
        //                               AddBlog
        // ====================================================================
        public Blog AddBlog(ViewBlog AddBlog)
        {
            if (AddBlog.Image != null)
            {
                var imagePath = _UploadImages.UploadImage(AddBlog.Image);

                var model = _Mapper.Map<Blog>(AddBlog);
                model.Image = imagePath;

                _DBCONTEXT.Blogs.Add(model);
                _DBCONTEXT.SaveChanges();

                return model;
            }
            return null;
        }

        // ====================================================================
        //                               UpdateBlog
        // ====================================================================
        public Blog UpdateBlog(ViewBlog UpdateBlog)
        {
            var existing = GetBlogById(UpdateBlog.Id);
            if (existing == null) return null;

            if (UpdateBlog.Image != null && UpdateBlog.Image.Length > 0)
            {
                if (!string.IsNullOrEmpty(existing.Image))
                    _UploadImages.DeleteImage(existing.Image);

                existing.Image = _UploadImages.UploadImage(UpdateBlog.Image);
            }

            _Mapper.Map(UpdateBlog, existing);

            _DBCONTEXT.SaveChanges();
            return existing;
        }

        // ====================================================================
        //                               DeleteBlog
        // ====================================================================
        public Blog DeleteBlog(int id)
        {
            var find = GetBlogById(id);
            if (find != null)
            {
                if (!string.IsNullOrEmpty(find.Image))
                {
                    _UploadImages.DeleteImage(find.Image);
                }

                _DBCONTEXT.Blogs.Remove(find);
                _DBCONTEXT.SaveChanges();
            }
            return find;
        }
    }
}
