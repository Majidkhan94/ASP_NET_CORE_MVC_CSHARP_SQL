

namespace BlogWebsite.Repository
{
    public class CPosts : IPosts
    {
        private readonly DBCONTEXT CONTEXTREPO;
        private readonly IWebHostEnvironment HostEnvironment;
        public  CPosts(DBCONTEXT _CONTEXT, IWebHostEnvironment _HostEnvironment)
        {
            CONTEXTREPO = _CONTEXT;
            HostEnvironment = _HostEnvironment;
        }
        //Create

        public PostsModel Create(PostsModel NewPost, ViewPostsModel ViewModel)
        {
            if (ViewModel.Image != null && ViewModel.Image.Length > 0)
            {
                string folder = Path.Combine(HostEnvironment.WebRootPath, "upload");
                
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                string fileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(ViewModel.Image.FileName);
                string filePath = Path.Combine(folder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    ViewModel.Image.CopyTo(stream);
                }

                
                NewPost.Image = "/upload/" + fileName;

                CONTEXTREPO.UserPosts.Add(NewPost);
                CONTEXTREPO.SaveChanges();
            }

            return NewPost;
        }

        //Delete


        public void Delete(int id)
        {
            var post = CONTEXTREPO.UserPosts.FirstOrDefault(p => p.ID == id);
            if (post != null)
            {
                CONTEXTREPO.UserPosts.Remove(post);
                CONTEXTREPO.SaveChanges();
            }
        }

        //Search By ID

        public PostsModel GetByID(int Id)
        {
            return CONTEXTREPO.UserPosts.FirstOrDefault(Product => Product.ID == Id);

        }

                                        // Get All Posts
        public List<PostsModel> GetAllPosts()
        {
            return CONTEXTREPO.UserPosts.ToList();
        }
                                         
        
    }
}
