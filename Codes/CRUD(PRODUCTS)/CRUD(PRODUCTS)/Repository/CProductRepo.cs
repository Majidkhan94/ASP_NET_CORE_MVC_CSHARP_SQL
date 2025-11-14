
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.Identity.Client;

namespace CRUD_PRODUCTS_.Repository
{
    public class CProductRepo : IProductRepo
    {
        private readonly ProductContext ProductRepo;
        private readonly IWebHostEnvironment HostEnvironment;
        public CProductRepo (ProductContext _Context, IWebHostEnvironment _Environment)
        {
            ProductRepo = _Context;
            HostEnvironment = _Environment;
        }
                                        //Search By ID
        public ProductModel GetProductByID(int Id)
        {
            return ProductRepo.Products.FirstOrDefault(Product => Product.ID == Id);
        }
                                       //Create

        public ProductModel CreateProduct(ProductModel Create, ProductModelView NewImage)
        {
            if (NewImage.Image != null)
            {
                string Folder = Path.Combine(HostEnvironment.WebRootPath, "Uploads");
                if(!Directory.Exists(Folder))
                {
                    Directory.CreateDirectory(Folder);
                }

                string File = Guid.NewGuid().ToString() + "_" + Path.GetFileName(NewImage.Image.FileName);
                string FilePath = Path.Combine(Folder, File);

                using (var Stream = new FileStream(FilePath, FileMode.Create))
                {
                    NewImage.Image.CopyTo(Stream);
                }
                Create.Image = Path.Combine ("/Uploads/", File);
                ProductRepo.Products.Add(Create);
                ProductRepo.SaveChanges();
            }
            return Create;

        }
                                     // Get All Products
        
        public List<ProductModel> GetAllProducts()
        {
            return ProductRepo.Products.ToList();
        }
        // Update Product

        public ProductModel UpdateProduct(ProductModel ExistingImage, ProductModelView NewImage)
        {
            if (NewImage.Image != null)
            {
                string folder = Path.Combine(HostEnvironment.WebRootPath, "Uploads");

                // Pehle wali image delete karni hai (agar exist karti hai)
                if (!string.IsNullOrEmpty(ExistingImage.Image))
                {
                    string oldImagePath = Path.Combine(HostEnvironment.WebRootPath, ExistingImage.Image.TrimStart('/').Replace("/", Path.DirectorySeparatorChar.ToString()));
                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }
                }

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                string fileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(NewImage.Image.FileName);
                string filePath = Path.Combine(folder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    NewImage.Image.CopyTo(stream);
                }

                ExistingImage.Image = Path.Combine("/Uploads/", fileName);
            }

            // Baaki fields update karlo
            ExistingImage.Title = NewImage.Title;
            ExistingImage.Price = NewImage.Price;
            ExistingImage.Description = NewImage.Description;

            ProductRepo.Products.Update(ExistingImage);
            ProductRepo.SaveChanges();

            return ExistingImage;
        }

        // Delete Product


        public ProductModel DeleteProduct(int id)
        {
            var del = ProductRepo.Products.FirstOrDefault(p => p.ID == id);
            if (del != null)
            {
                if (!string.IsNullOrEmpty(del.Image))
                {
                    string imagePath = Path.Combine(HostEnvironment.WebRootPath, del.Image.TrimStart('/').Replace("/", Path.DirectorySeparatorChar.ToString()));
                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete(imagePath);
                    }
                }

                ProductRepo.Products.Remove(del);
                ProductRepo.SaveChanges();
            }
            return del;
        }

    }
}
