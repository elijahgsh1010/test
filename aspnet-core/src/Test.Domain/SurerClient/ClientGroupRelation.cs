using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Test.SurerClient
{
    public class ClientGroupRelation 
    {
        public ClientGroupRelation() { }

        public long? CompanyId { get; set; }
        [CanBeNull] public virtual Company.Company Company { get; set; }

        public long? FamilyId { get; set; }
        [CanBeNull] public virtual Family.Family Family { get; set; } 
        
        public Guid ClientId { get; set; }
        public virtual Client Client { get; set; }  
    }
}