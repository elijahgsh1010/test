using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Test.SurerClient
{
    public class Client : FullAuditedAggregateRoot<Guid>, IMultiTenant
    {
        public Client() { }

        public virtual string Name { get; set; }
        
        public virtual string ContactNumber { get; set; }
        
        public virtual string EmailAddress { get; set; }
        
        public virtual string MailingAddress { get; set; }
        
        public virtual string Relationship { get; set; }
        
        public virtual string Designation { get; set; }

        public virtual ICollection<ClientGroupRelation> ClientGroupRelations { get; set; } = new List<ClientGroupRelation>();
        
        public Guid? TenantId { get; }
    }
}