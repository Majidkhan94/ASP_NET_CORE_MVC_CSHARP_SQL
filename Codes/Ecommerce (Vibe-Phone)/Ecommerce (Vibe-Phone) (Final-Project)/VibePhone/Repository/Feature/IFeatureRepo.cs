namespace VibePhone.Repository.FeatureRepo
{
    public interface IFeatureRepo
    {
        List<Feature> GetAllFeature();
        Feature GetFeatureById(int id);
        Feature AddFeature(ViewFeature AddFeature);
        Feature UpdateFeature(ViewFeature UpdateFeature);
        Feature DeleteFeature(int id);
    }
}
