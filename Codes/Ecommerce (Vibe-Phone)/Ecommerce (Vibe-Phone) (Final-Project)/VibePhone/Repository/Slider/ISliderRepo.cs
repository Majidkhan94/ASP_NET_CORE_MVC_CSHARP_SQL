namespace VibePhone.Repository.SliderDetailsRepo
{
    public interface ISliderRepo
    {
        List<Slider> GetAllSlider();
        Slider GetSliderById(int id);
        Slider AddSlider(ViewSlider AddSlider);
        Slider UpdateSlider(ViewSlider UpdateSlider);
        Slider DeleteSlider(int id);
    }
}
