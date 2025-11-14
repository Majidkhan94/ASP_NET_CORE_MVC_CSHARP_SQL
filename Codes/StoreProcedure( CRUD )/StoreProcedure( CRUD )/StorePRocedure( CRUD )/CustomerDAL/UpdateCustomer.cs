using NuGet.Protocol.Plugins;

namespace StorePRocedure__CRUD__.CustomerDAL
{
    public class UpdateCustomer
    {
        private readonly string _CS = StorePRocedure__CRUD__.ConnectionStrings.ConnectionStrings.ConnectionString;

        public CustModel Update(int id, CustModel UpdateCustomer)
        {
            using (SqlConnection Connection = new SqlConnection(_CS))
            {
                Connection.Open();

                SqlCommand command = new SqlCommand("SP_UpdateCustomer", Connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", UpdateCustomer.Name);
                command.Parameters.AddWithValue("@Address", UpdateCustomer.Address);
                command.Parameters.AddWithValue("@Phone", UpdateCustomer.Phone);
                command.Parameters.AddWithValue("@Gender", UpdateCustomer.Gender);

                command.ExecuteNonQuery();

                UpdateCustomer.id = id;
                return UpdateCustomer;

            }
        }
    }
}
