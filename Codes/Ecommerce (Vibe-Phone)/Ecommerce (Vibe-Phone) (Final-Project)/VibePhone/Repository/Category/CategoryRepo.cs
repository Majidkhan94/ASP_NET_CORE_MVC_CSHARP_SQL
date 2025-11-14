namespace VibePhone.Repository.CategoryRepo
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly DBCONTEXT _DBCONTEXT;

        public CategoryRepo(DBCONTEXT context)
        {
            _DBCONTEXT = context;
        }

        //  ====================================================================
        //                                GetAllCategories
        //    ====================================================================
        public List<Category> GetAllCategories()
        {
            var list = _DBCONTEXT.Categories.ToList();
            return list;
        }

        
        //  ====================================================================
        //                                GetCategoryById
        //    ====================================================================
        public Category GetCategoryById(int id)
        {
            var Find = _DBCONTEXT.Categories.FirstOrDefault(x => x.CategoryId == id);
            return Find;
        }


        //  ====================================================================
        //                                AddCategory
        //    ====================================================================
        public Category AddCategory(Category AddCategory)
        {
            var add = _DBCONTEXT.Categories.Add(AddCategory);
            _DBCONTEXT.SaveChanges();
            return AddCategory;
        }


        //  ====================================================================
        //                                UpdateCategory
        //    ====================================================================
        public Category UpdateCategory(Category UpdateCategory)
        {
            var Update = _DBCONTEXT.Categories.Update(UpdateCategory);
            _DBCONTEXT.SaveChanges();
            return UpdateCategory;
        }
       
        
        //  ====================================================================
        //                                DeleteCategory
        //    ====================================================================
        public Category DeleteCategory(int id)
        {
            var Find = GetCategoryById(id);
            if (Find != null)
            {
                _DBCONTEXT.Categories.Remove(Find);
                _DBCONTEXT.SaveChanges();
                return Find;
            }
            return null;
        }
        
    }
}
