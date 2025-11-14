namespace VibePhone.Repository.FeatureRepo
{
    public class FeatureRepo : IFeatureRepo
    {
        private readonly UploadImages _UploadImages;
        private readonly DBCONTEXT _DBCONTEXT;
        private readonly IMapper _Mapper;

        public FeatureRepo(DBCONTEXT context, UploadImages uploadImages, IMapper mapper)
        {
            _DBCONTEXT = context;
            _UploadImages = uploadImages;
            _Mapper = mapper;
        }



        //  ====================================================================
        //                                GetAllFeature
        //    ====================================================================
        public List<Feature> GetAllFeature()
        {
            var list = _DBCONTEXT.Features.Include(x => x.Category).ToList();
            return list;
        }

        //  ====================================================================
        //                                GetFeatureById
        //    ====================================================================
        public Feature GetFeatureById(int id)
        {
            var Find = _DBCONTEXT.Features.FirstOrDefault(x => x.Id == id);
            return Find;
        }

        //  ====================================================================
        //                                AddFeature
        //    ====================================================================
        public Feature AddFeature(ViewFeature AddFeature)
        {
            if (AddFeature.Image != null)
            {
                var imagePath = _UploadImages.UploadImage(AddFeature.Image);

                var model = _Mapper.Map<Feature>(AddFeature);
                model.Image = imagePath;

                _DBCONTEXT.Features.Add(model);
                _DBCONTEXT.SaveChanges();
                return model;

            }
            return null;
        }

        //  ====================================================================
        //                                UpdateFeature
        //    ====================================================================
        public Feature UpdateFeature(ViewFeature UpdateFeature)
        {
            var existing = GetFeatureById(UpdateFeature.Id);
            if (existing == null) return null;

            if (UpdateFeature.Image != null && UpdateFeature.Image.Length > 0)
            {
                if (!string.IsNullOrEmpty(existing.Image))
                    _UploadImages.DeleteImage(existing.Image);

                existing.Image = _UploadImages.UploadImage(UpdateFeature.Image);
            }

            _Mapper.Map(UpdateFeature, existing);

            _DBCONTEXT.SaveChanges();
            return existing;
        }

        //  ====================================================================
        //                                DeleteFeature
        //    ====================================================================
        public Feature DeleteFeature(int id)
        {
            var Find = GetFeatureById(id);
            if (Find != null)
            {
                if (!string.IsNullOrEmpty(Find.Image))
                {
                    _UploadImages.DeleteImage(Find.Image);
                }

                _DBCONTEXT.Features.Remove(Find);
                _DBCONTEXT.SaveChanges();
            }
            return Find;
        }








    }
}
