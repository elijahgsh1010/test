using System.ComponentModel.DataAnnotations;

namespace Test.SurerClient
{
    public class FamilyDto
    {
        [Required]
        public string NucleusName { get; set; }
        
        [Required]
        public string MailingAddress { get; set; }
    }
}