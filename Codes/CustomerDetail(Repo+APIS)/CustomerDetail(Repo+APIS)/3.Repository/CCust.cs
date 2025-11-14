namespace CustomerDetail_Repo_APIS_._3.Repository
{
    public class CCust : ICust
    {
        private readonly CustDBContext _CustRepo;
        public CCust(CustDBContext _ICust)
        {
            _CustRepo = _ICust;
        }
        public List<CustModel> GetAllCust()
        {
            var Data = _CustRepo.Customers.ToList();
            return Data;
        }

        public CustModel CustByID(int id)
        {
            var data = _CustRepo.Customers.Find(id);
            return data;
            
        }

        public CustModel CreateCust(CustModel CreateCust)
        {
            var data = _CustRepo.Customers.Add(CreateCust);
            _CustRepo.SaveChanges();
            return CreateCust;
        }

        public CustModel UpdateCust(int id, CustModel UpdateCust)
        {
            var Data = _CustRepo.Customers.Find(id);
            if(Data != null)
            {
                Data.Name = UpdateCust.Name;
                Data.Address = UpdateCust.Address;
                Data.Phone = UpdateCust.Phone;

                _CustRepo.Customers.Update(Data);
                _CustRepo.SaveChanges();
                return Data;
            }
                return null;
        }

        public CustModel DeleteCust(int id)
        {
            var Data = _CustRepo.Customers.Find(id);
            if(Data != null)
            {
                _CustRepo.Customers.Remove(Data);
                _CustRepo.SaveChanges();
            }
            return Data;
        }
    }
}
