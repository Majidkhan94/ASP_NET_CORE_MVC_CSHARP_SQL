namespace StorePRocedure__CRUD__.CustomerDAL
{
    public class CreateCustomer
    {
        private readonly string _CS = StorePRocedure__CRUD__.ConnectionStrings.ConnectionStrings.ConnectionString;

        public CustModel Create(CustModel Createcustomer)
        {
            using (SqlConnection Connection = new SqlConnection(_CS))
            {
                Connection.Open();

                SqlCommand Command = new SqlCommand("SP_CreateCustomer", Connection);
                Command.CommandType = CommandType.StoredProcedure;

                Command.Parameters.AddWithValue("@Name", Createcustomer.Name);
                Command.Parameters.AddWithValue("@Address", Createcustomer.Address);
                Command.Parameters.AddWithValue("@Phone", Createcustomer.Phone);
                Command.Parameters.AddWithValue("@Gender", Createcustomer.Gender);

                Command.ExecuteNonQuery();
                return Createcustomer;

            }
            
                
        }
    }
}
