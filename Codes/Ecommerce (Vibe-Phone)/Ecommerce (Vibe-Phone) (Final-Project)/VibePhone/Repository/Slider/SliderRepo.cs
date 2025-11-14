namespace VibePhone.Repository.SliderDetailsRepo
{
    public class SliderRepo : ISliderRepo
    {
        private readonly UploadImages _UploadImages;
        private readonly DBCONTEXT _DBCONTEXT;
        private readonly IMapper _Mapper;

        public SliderRepo(DBCONTEXT context, UploadImages uploadImages, IMapper mapper)
        {
            _DBCONTEXT = context;
            _UploadImages = uploadImages;
            _Mapper = mapper;
        }


        //  ====================================================================
        //                                GetAllSlider
        //    ====================================================================
        public List<Slider> GetAllSlider()
        {
            var list = _DBCONTEXT.SliderDetails.Include(x => x.Category).ToList();
            return list;
        }


        //  ====================================================================
        //                                GetSliderById
        //    ====================================================================
        public Slider GetSliderById(int id)
        {
            var Find = _DBCONTEXT.SliderDetails.FirstOrDefault(x => x.Id == id);
            return Find;
        }

        //  ====================================================================
        //                                AddSlider
        //    ====================================================================
        public Slider AddSlider(ViewSlider AddSlider)
        {
            if (AddSlider.Image != null)
            {
                var imagePath = _UploadImages.UploadImage(AddSlider.Image);
                
                var model = _Mapper.Map<Slider>(AddSlider);
                model.Image = imagePath; 

                _DBCONTEXT.SliderDetails.Add(model);
                _DBCONTEXT.SaveChanges();
                return model;
            }
            return null;
            
        }


        //  ====================================================================
        //                                UpdateSlider
        //    ====================================================================
        public Slider UpdateSlider(ViewSlider UpdateSlider)
        {
            var existing = GetSliderById(UpdateSlider.Id);
            if (existing == null) return null;

            if (UpdateSlider.Image != null && UpdateSlider.Image.Length > 0)
            {
                if (!string.IsNullOrEmpty(existing.Image))
                    _UploadImages.DeleteImage(existing.Image);

                existing.Image = _UploadImages.UploadImage(UpdateSlider.Image);
            }

            _Mapper.Map(UpdateSlider, existing);

            _DBCONTEXT.SaveChanges();
            return existing;
        }

        //  ====================================================================
        //                                DeleteSlider
        //    ====================================================================
        public Slider DeleteSlider(int id)
        {
            var Find = GetSliderById(id);
            if (Find != null)
            {
                if (!string.IsNullOrEmpty(Find.Image))
                {
                    _UploadImages.DeleteImage(Find.Image);
                }

                _DBCONTEXT.SliderDetails.Remove(Find);
                _DBCONTEXT.SaveChanges();
            }
            return Find;
        }

    }
}


