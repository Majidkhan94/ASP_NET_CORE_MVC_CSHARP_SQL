namespace ShowStdDetails_Through_Repository.Data
{
    public class StdDetailsModelData
    {
        public List<StdDetailsModel> stdDetailsModel() => new List<StdDetailsModel>
            {
                new StdDetailsModel{ID=101,Name="Student-1",Address="Student-1_Address",Phone="111111111"},
                new StdDetailsModel{ID=102,Name="Student-2",Address="Student-2_Address",Phone="222222222"},
                new StdDetailsModel{ID=103,Name="Student-3",Address="Student-3_Address",Phone="333333333"},
                new StdDetailsModel{ID=104,Name="Student-4",Address="Student-4_Address",Phone="444444444"},
                new StdDetailsModel{ID=105,Name="Student-5",Address="Student-5_Address",Phone="555555555"},
                
            };
    }
}
