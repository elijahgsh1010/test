using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace Test.SurerClient
{
    public class ClientAppService : TestAppService, IClientAppService
    {
        private readonly IRepository<ClientGroup, Guid> _clientGroupRepository;
        
        public ClientAppService(
            IRepository<ClientGroup, Guid> clientGroupRepository
            )
        {
            _clientGroupRepository = clientGroupRepository;
        }

        public virtual async Task<Dictionary<string, string>> GetClientGroupTypeList()
        {
            return null;
        }
        
        public virtual async Task<Dictionary<string, string>> GetNatureOfBusinessList()
        {
            return null;
        }

        public virtual async Task GetClient()
        {
        }

        public virtual async Task<PagedResultDto<GetCompanyForView>> GetAllCompanies()
        {
            return null;
        }

        public virtual async Task<PagedResultDto<GetFamilyForView>> GetAllFamilies()
        {
            return null;
        }
        
        public virtual async Task GetAllClientGroup()
        {
        }
        
        public virtual async Task GetAllClients(GetAllClientInput input)
        {
        }

        public virtual async Task<Guid> CreateOrEditClientGroup(CreateOrEditClientGroupInput input)
        {
            return await Task.FromResult(Guid.Empty);
        }

        public virtual async Task GetClientGroup(EntityDto<Guid> input)
        {
        }

        public virtual async Task DeleteClientGroup(List<EntityDto<Guid>> input)
        {
        }

        public virtual async Task CreateOrEditClient(CreateOrEditClientInput input)
        {
            if (input.Id != null)
            {
                await CreateClient();
            }
            else
            {
                await UpdateClient();
            }
        }

        public virtual async Task DeleteClient(List<EntityDto<Guid>> input)
        {
        }

        private async Task CreateClientGroup()
        {
        }
        
        private async Task UpdateClientGroup()
        {
        }
        
        private async Task CreateClient()
        {
        }
        
        private async Task UpdateClient()
        {
        }
        
        
    }
}