namespace VibePhone.Repository.Galleries
{
    public interface IGalleryRepo
    {
        List<Gallery> GetAllGallery();
        Gallery GetGalleryById(int id);
        Gallery AddGallery(ViewGallery AddGallery);
        Gallery DeleteGallery(int id);
    }
}
