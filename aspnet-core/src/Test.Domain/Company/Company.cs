using System;
using System.Collections.Generic;
using Test.SurerClient;
using Volo.Abp.Data;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace Test.Company
{
    public class Company : Entity<long>, IHasExtraProperties, IMultiTenant
    {
        public Company() { }
        public Company(ExtraPropertyDictionary extraProperties)
        {
            ExtraProperties = extraProperties;
        }
        
        public string NucleusName { get; set; }
        
        public string UenNumber { get; set; }
        
        public string NatureOfBusiness { get; set; }
        
        public string MailingAddress { get; set; }
        
        public ExtraPropertyDictionary ExtraProperties { get; }
        
        public virtual ICollection<ClientGroupRelation> ClientGroups { get; set; }
        
        public Guid? TenantId { get; }
    }
}