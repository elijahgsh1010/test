using System;
using System.Collections.Generic;
using Test.SurerClient;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace Test.Family
{
    public class Family : Entity<long>, IMultiTenant
    {
        public Family(){ }
        
        public virtual string NucleusName { get; set; }
        
        public virtual string MailingAddress { get; set; }
        
        public virtual ICollection<ClientGroupRelation> ClientGroups { get; set; }
        
        public Guid? TenantId { get; }
    }
}