namespace Test.SurerClient
{
    public class GetAllClientGroupInput
    {
        public string FilterGroupName { get; set; }
        public string FilterCompanyName { get; set; }
        public ClientGroupType[] GroupTypeFilter { get; set; }
        public NatureOfBusiness[] BusinessFilter { get; set; }
    }
}