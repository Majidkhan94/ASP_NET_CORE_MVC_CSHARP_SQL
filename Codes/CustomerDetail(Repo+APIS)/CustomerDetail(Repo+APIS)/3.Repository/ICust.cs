namespace CustomerDetail_Repo_APIS_._3.Repository
{
    public interface ICust
    {
        List<CustModel> GetAllCust();
        CustModel CreateCust(CustModel CreateCust);
        CustModel UpdateCust(int id, CustModel UpdateCust);
        CustModel DeleteCust(int id);
        CustModel CustByID(int id);


    }
}
