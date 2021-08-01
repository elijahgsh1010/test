using System.ComponentModel.DataAnnotations;

namespace Test.SurerClient
{
    public class ClientDto
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string ContactNumber { get; set; }
        
        [Required]
        public string EmailAddress { get; set; }
        
        [Required]
        public string MailingAddress { get; set; }
        
        [Required]
        public string Relationship { get; set; }
        
        [Required]
        public string Designation { get; set; }
    }
}