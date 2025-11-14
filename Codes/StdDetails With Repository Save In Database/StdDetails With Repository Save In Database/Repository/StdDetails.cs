namespace StdDetails_With_Repository_Save_In_Database.Repository
{
    public class StdDetails : IStdDetails
    {
        private readonly StdDetailsData _StdDetailsData;
        public StdDetails(StdDetailsData stdDetailsData)
        {
            _StdDetailsData = stdDetailsData;   
        }

        public void AddStudent(StdDetailsModel model)
        {
            _StdDetailsData.stdDetailsModel.Add(model);
            _StdDetailsData.SaveChanges();
                   
        }

        public List<StdDetailsModel> GetAllStdDetails()
        {
           return _StdDetailsData.stdDetailsModel.ToList();
        }
    }
}
