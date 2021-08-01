using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Test.SurerClient
{
    public class CreateOrEditClientGroupInput : EntityDto<Guid?>
    {
        public CompanyDto Company { get; set; }
        public FamilyDto Family { get; set; }
        public List<ClientDto> Clients { get; set; } = new List<ClientDto>();
    }
}