namespace VibePhone.Repository.Testimonials
{
    public interface ITestimonialRepo
    {
        List<Testimonial> GetAllTestimonials();
        Testimonial GetTestimonialById(int id);
        Testimonial AddTestimonial(Testimonial addTestimonial);
        Testimonial UpdateTestimonial(Testimonial updateTestimonial);
        Testimonial DeleteTestimonial(int id);
    }
}
