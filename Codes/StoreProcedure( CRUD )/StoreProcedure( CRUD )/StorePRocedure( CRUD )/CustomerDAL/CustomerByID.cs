namespace StorePRocedure__CRUD__.CustomerDAL
{
    public class CustomerByID
    {
        private readonly string _CS = StorePRocedure__CRUD__.ConnectionStrings.ConnectionStrings.ConnectionString;

        public CustModel CustomerById(int id)
        {
            CustModel customer = null;

            using (SqlConnection Connection = new SqlConnection(_CS))
            {
                Connection.Open();

                SqlCommand Command = new SqlCommand("SP_CustomerById", Connection);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@id", id);
                
                SqlDataReader Reader = Command.ExecuteReader();  

                if (Reader.Read())
                {
                    customer = new CustModel
                    {
                        id = Convert.ToInt16(Reader["ID"]),
                        Name = Reader["Name"].ToString(),
                        Address = Reader["Address"].ToString(),
                        Phone = Reader["Phone"].ToString(),
                        Gender = Reader["Gender"].ToString(),
                    };
                }
                Reader.Close();

            }
            return customer;

        }
    }
}
