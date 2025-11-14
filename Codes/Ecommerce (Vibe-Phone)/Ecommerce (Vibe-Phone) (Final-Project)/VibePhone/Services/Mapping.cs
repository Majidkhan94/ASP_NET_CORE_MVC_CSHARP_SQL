public class Mapping : Profile
{
    public Mapping()
    {
                                // ==============================
                                //              Slider
                                // ==============================
        
        
        CreateMap<ViewSlider, Slider>()
            .ForMember(dest => dest.Image, opt => opt.Ignore());

        CreateMap<Slider, ViewSlider>()
            .ForMember(dest => dest.Image, opt => opt.Ignore());




        // ==============================
        //              Feature
        // ==============================

        CreateMap<ViewFeature, Feature>()
            .ForMember(dest => dest.Image, opt => opt.Ignore());

        CreateMap<Feature, ViewFeature>()
            .ForMember(dest => dest.Image, opt => opt.Ignore());

        // ==============================
        //              Gallery
        // ==============================

        CreateMap<Gallery, ViewGallery>()
    .ForMember(dest => dest.ImagePath, opt => opt.MapFrom(src => src.ImageGallery))
    .ForMember(dest => dest.ImageGallery, opt => opt.Ignore());

        CreateMap<ViewGallery, Gallery>()
            .ForMember(dest => dest.ImageGallery, opt => opt.Ignore()); // upload separate handle



        // ==============================
        //            Blog
        // ==============================


        CreateMap<ViewBlog, Blog>()
            .ForMember(dest => dest.Image, opt => opt.Ignore());

        CreateMap<Blog, ViewBlog>()
            .ForMember(dest => dest.Image, opt => opt.Ignore());




    }
}
