using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Test.SurerClient
{
    public class ClientGroup : FullAuditedAggregateRoot<Guid>, IMultiTenant
    {
        public ClientGroup() { }

        public ClientGroup(Guid id)
        {
            Id = id;
            Clients = new List<Client>();
        }
        public Guid? TenantId { get; }
        
        public ClientGroupType GroupType { get; set; }
        
        public virtual Company.Company Company {get; set; }
        
        public virtual Family.Family Family { get; set; }
        
        public virtual ICollection<Client> Clients { get; set; }
    }
}