
    namespace VibePhone.Repository.Testimonials
    {
        public class TestimonialRepo : ITestimonialRepo
        {
            private readonly DBCONTEXT _DBCONTEXT;

            public TestimonialRepo(DBCONTEXT context)
            {
                _DBCONTEXT = context;
            }

            //  ====================================================================
            //                                GetAllTestimonials
            //    ====================================================================
            public List<Testimonial> GetAllTestimonials()
            {
                var list = _DBCONTEXT.Testimonials.ToList();
                return list;
            }


            //  ====================================================================
            //                                GetTestimonialById
            //    ====================================================================
            public Testimonial GetTestimonialById(int id)
            {
                var find = _DBCONTEXT.Testimonials.FirstOrDefault(x => x.Id == id);
                return find;
            }


            //  ====================================================================
            //                                AddTestimonial
            //    ====================================================================
            public Testimonial AddTestimonial(Testimonial addTestimonial)
            {
                var add = _DBCONTEXT.Testimonials.Add(addTestimonial);
                _DBCONTEXT.SaveChanges();
                return addTestimonial;
            }


            //  ====================================================================
            //                                UpdateTestimonial
            //    ====================================================================
            public Testimonial UpdateTestimonial(Testimonial updateTestimonial)
            {
                var update = _DBCONTEXT.Testimonials.Update(updateTestimonial);
                _DBCONTEXT.SaveChanges();
                return updateTestimonial;
            }


            //  ====================================================================
            //                                DeleteTestimonial
            //    ====================================================================
            public Testimonial DeleteTestimonial(int id)
            {
                var find = GetTestimonialById(id);
                if (find != null)
                {
                    _DBCONTEXT.Testimonials.Remove(find);
                    _DBCONTEXT.SaveChanges();
                    return find;
                }
                return null;
            }
        }
    }
