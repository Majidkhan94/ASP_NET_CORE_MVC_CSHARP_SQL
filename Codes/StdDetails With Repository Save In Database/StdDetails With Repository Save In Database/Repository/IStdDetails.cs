namespace StdDetails_With_Repository_Save_In_Database.Repository
{
    public interface IStdDetails
    {
        List<StdDetailsModel> GetAllStdDetails();
        void AddStudent(StdDetailsModel model);
    }
}
