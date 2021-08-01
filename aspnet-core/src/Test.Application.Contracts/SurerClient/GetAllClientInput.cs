using Volo.Abp.Application.Dtos;

namespace Test.SurerClient
{
    public class GetAllClientInput : PagedAndSortedResultRequestDto
    {
        public long[] FilterFamilyId { get; set; }
        public long[] FilterCompanyId { get; set; }
        public string FilterClientName { get; set; }
    }
}