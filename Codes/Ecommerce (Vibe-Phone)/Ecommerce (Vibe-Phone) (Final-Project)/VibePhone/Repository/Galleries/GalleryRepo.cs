
namespace VibePhone.Repository.Galleries
{
    public class GalleryRepo : IGalleryRepo
    {
        private readonly UploadImages _UploadImages;
        private readonly DBCONTEXT _DBCONTEXT;
        private readonly IMapper _Mapper;

        public GalleryRepo(DBCONTEXT context, UploadImages uploadImages, IMapper mapper)
        {
            _DBCONTEXT = context;
            _UploadImages = uploadImages;
            _Mapper = mapper;
        }

        //  ====================================================================
        //                                GetAllGallery
        //    ====================================================================

        public List<Gallery> GetAllGallery()
        {
            var list = _DBCONTEXT.ImageGallery.Include(x => x.Category).ToList();
            return list;
        }
        //  ====================================================================
        //                                GetGalleryById
        //    ====================================================================
        public Gallery GetGalleryById(int id)
        {
            var Find = _DBCONTEXT.ImageGallery.Include(x => x.Category).FirstOrDefault(x => x.Id == id);
            return Find;
        }
        //  ====================================================================
        //                                AddGallery
        //    ====================================================================
        public Gallery AddGallery(ViewGallery AddGallery)
        {
            if (AddGallery.ImageGallery != null)
            {
                var imagePath = _UploadImages.UploadImage(AddGallery.ImageGallery);

                var model = _Mapper.Map<Gallery>(AddGallery);
                model.ImageGallery = imagePath;

                _DBCONTEXT.ImageGallery.Add(model);
                _DBCONTEXT.SaveChanges();
                return model;
            }
            return null;
        }

        //  ====================================================================
        //                                DeleteGallery
        //    ====================================================================
        public Gallery DeleteGallery(int id)
        {
            var Find = GetGalleryById(id);
            if (Find != null)
            {
                if (!string.IsNullOrEmpty(Find.ImageGallery))
                {
                    _UploadImages.DeleteImage(Find.ImageGallery);
                }

                _DBCONTEXT.ImageGallery.Remove(Find);
                _DBCONTEXT.SaveChanges();
            }
            return Find;
        }

       

        
    }
}
