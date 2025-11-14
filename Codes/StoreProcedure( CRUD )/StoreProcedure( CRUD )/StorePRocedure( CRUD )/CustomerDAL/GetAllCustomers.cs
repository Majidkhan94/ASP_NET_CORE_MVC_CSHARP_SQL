

namespace StorePRocedure__CRUD__.CustomerDAL
{
    public class GetAllCustomers
    {
        private readonly String _CS = StorePRocedure__CRUD__.ConnectionStrings.ConnectionStrings.ConnectionString;
    
        public List<CustModel> GetAllCustomer()
        {
            List<CustModel> Customers = new List<CustModel>();

            using (SqlConnection Connection = new SqlConnection(_CS))
            {
                Connection.Open();

                SqlCommand Command = new SqlCommand("SP_GetAllCustomers", Connection);
                Command.CommandType = CommandType.StoredProcedure;

                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    CustModel Customer = new CustModel();
                    Customer.id = Convert.ToInt16(Reader["id"]);
                    Customer.Name = Reader["Name"].ToString();
                    Customer.Address = Reader["Address"].ToString();
                    Customer.Phone = Reader["Phone"].ToString();
                    Customer.Gender = Reader["Gender"].ToString();

                    Customers.Add(Customer);
                }
                return Customers;

            }

        }
    
    }
}
