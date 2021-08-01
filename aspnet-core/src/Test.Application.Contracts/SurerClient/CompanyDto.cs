using System.ComponentModel.DataAnnotations;

namespace Test.SurerClient
{
    public class CompanyDto
    {
        [Required]
        public string NucleusName { get; set; }
                
        [Required]
        public string UenNumber { get; set; }
        
        [Required]
        public string NatureOfBusiness { get; set; }
        
        [Required]
        public string MailingAddress { get; set; }
    }
}