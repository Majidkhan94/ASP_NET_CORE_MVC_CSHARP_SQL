
namespace CRUD_PROJECT.Repository
{
    public class CStdDetailRepo : IStdDetailRepo
    {
        private readonly StdDetailData _StdDetailDataRepo;
        

        public CStdDetailRepo(StdDetailData _stdDetailData, IConfiguration configuration)
        {
            _StdDetailDataRepo = _stdDetailData;
            
        }
        public StdDetail Create(StdDetail Create)
        {
            _StdDetailDataRepo.StdDetails.Add(Create);
            _StdDetailDataRepo.SaveChanges();
            return (Create);
        }

        public StdDetail Delete(int id)
        {
            var std =  _StdDetailDataRepo.StdDetails.FirstOrDefault(x => x.ID == id);
            if (std != null) {

                _StdDetailDataRepo.StdDetails.Remove(std);
                _StdDetailDataRepo.SaveChanges();
            }
            return std;
            
        }

        public List<StdDetail> ReadOnly()
        {
            return _StdDetailDataRepo.StdDetails.ToList();
        }

        public StdDetail Update(StdDetail Update)
        {
            _StdDetailDataRepo.StdDetails.Update(Update);
            _StdDetailDataRepo.SaveChanges();
            return (Update);
        }
        public StdDetail GetById(int id)
        {
            return _StdDetailDataRepo.StdDetails.FirstOrDefault(x => x.ID == id);
        }
       

    }
}
