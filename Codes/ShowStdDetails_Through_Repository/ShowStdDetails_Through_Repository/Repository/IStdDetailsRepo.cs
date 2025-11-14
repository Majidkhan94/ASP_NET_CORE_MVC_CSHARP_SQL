namespace ShowStdDetails_Through_Repository.Repository
{
    public interface IStdDetailsRepo
    {
        List<StdDetailsModel> GetAllStdDetails();
        StdDetailsModel GetAllStdDetailsById(int id);
    }
}
