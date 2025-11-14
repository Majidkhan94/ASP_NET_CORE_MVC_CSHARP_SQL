using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VibePhone.ViewModel
{
    public class ViewDashboard
    {
        // List Form Binding


        public List<Slider> Slider { get; set; }
        public List<Feature> Feature { get; set; }
        public List<Category> Category { get; set; }
        public List<Gallery> Gallery { get; set; }
        public List<Blog> Blog { get; set; }
        public List<Testimonial> Testimonial { get; set; }
        public List<Newsletter> Newsletter { get; set; }
        public List<Contactus> Contactus { get; set; }

        // Single Form Binding
        public Newsletter Newsletters { get; set; } = new Newsletter();
        public Contactus ContactUS { get; set; } = new Contactus();

    }
}
