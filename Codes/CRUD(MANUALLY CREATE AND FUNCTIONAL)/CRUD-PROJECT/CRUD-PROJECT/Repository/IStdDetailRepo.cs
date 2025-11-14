namespace CRUD_PROJECT.Repository
{
    public interface IStdDetailRepo
    {
        List<StdDetail> ReadOnly();
        StdDetail Create(StdDetail Create);
        StdDetail Update(StdDetail Update);
        StdDetail Delete(int id);
        StdDetail GetById(int id);
       



    }
}
