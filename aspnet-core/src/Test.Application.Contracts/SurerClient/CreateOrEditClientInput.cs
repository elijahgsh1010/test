using System;
using Volo.Abp.Application.Dtos;

namespace Test.SurerClient
{
    public class CreateOrEditClientInput : EntityDto<Guid?>
    {
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public string MailingAddress { get; set; }
        public string Relationship { get; set; }
        public string Designation { get; set; }
    }
}