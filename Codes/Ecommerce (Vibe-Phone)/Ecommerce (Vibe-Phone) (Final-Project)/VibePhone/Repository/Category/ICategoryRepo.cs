namespace VibePhone.Repository.CategoryRepo
{
    public interface ICategoryRepo
    {
        List<Category> GetAllCategories();
        Category GetCategoryById(int id);
        Category AddCategory(Category AddCategory);
        Category UpdateCategory(Category UpdateCategory);
        Category DeleteCategory(int id);
    }
}
