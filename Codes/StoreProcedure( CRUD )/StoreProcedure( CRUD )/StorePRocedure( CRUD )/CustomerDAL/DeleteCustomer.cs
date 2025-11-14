

namespace StorePRocedure__CRUD__.CustomerDAL
{
    public class DeleteCustomer
    {
        private readonly string _CS = StorePRocedure__CRUD__.ConnectionStrings.ConnectionStrings.ConnectionString;

        public CustModel Delete(int id)
        {
            CustModel customer = null;
            using (SqlConnection Connection = new SqlConnection(_CS))
            {
                Connection.Open();

                SqlCommand Command = new SqlCommand("SP_CustomerById", Connection);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@Id", id);

                SqlDataReader Reader = Command.ExecuteReader();

                if(Reader.Read())
                {
                    customer = new CustModel
                    {
                        id = Convert.ToInt16(Reader["id"]),
                        Name = Reader["Name"].ToString(),
                        Address = Reader["Address"].ToString(),
                        Phone = Reader["Phone"].ToString(),
                        Gender = Reader["Gender"].ToString()
                    };
                }
                Reader.Close();


                SqlCommand DeleteCommand = new SqlCommand("SP_DeleteCustomer", Connection);
                DeleteCommand.CommandType = CommandType.StoredProcedure;
                DeleteCommand.Parameters.AddWithValue("@Id", id);
                DeleteCommand.ExecuteNonQuery();

                return customer;
            }
           
        }
    }
}
