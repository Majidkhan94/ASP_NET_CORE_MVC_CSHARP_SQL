namespace CRUD_PRODUCTS_.Repository
{
    public interface IProductRepo
    {
        ProductModel CreateProduct(ProductModel Create, ProductModelView NewImage);
        
        List<ProductModel> GetAllProducts();

        ProductModel UpdateProduct(ProductModel ExistingImage, ProductModelView NewImage);

        ProductModel DeleteProduct(int id);

        ProductModel GetProductByID(int Id);
        

    }
}
