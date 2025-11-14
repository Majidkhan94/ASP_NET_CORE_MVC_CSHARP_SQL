
namespace ShowStdDetails_Through_Repository.Repository
{
    public class StdDetailsRepo : IStdDetailsRepo
    {
        private readonly StdDetailsModelData _StdDetailsModelData;
        public StdDetailsRepo(StdDetailsModelData stdDetailsModelData)
        {
            _StdDetailsModelData = stdDetailsModelData;
        }

        public List<StdDetailsModel> GetAllStdDetails()
        {
            return _StdDetailsModelData.stdDetailsModel();
        }

        public StdDetailsModel GetAllStdDetailsById(int id)
        {
            return _StdDetailsModelData.stdDetailsModel().FirstOrDefault(s => s.ID == id);
        }
    }
}
