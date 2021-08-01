using System.Collections.Generic;

namespace Test.SurerClient
{
    public class GetCompanyForView
    {
        public long Id { get; set; }
        public string NucleusName { get; set; }
        public string MailingAddress { get; set; }
        public string UenNumber { get; set; }
        public string NatureOfBusiness { get; set; }
        public List<string> BusinessLocation { get; set; }
    }
}