using System.Threading.Tasks;
using TechburnyStore.Core.Business.Responses;
using TechburnyStore.Core.Domain.HumanResources;

namespace TechburnyStore.Core.Business.Contracts
{
    public interface IHumanResourcesService : IService
    {
        Task<IListResponse<Employee>> GetEmployeesAsync(int pageSize = 0, int pageNumber = 0);

        Task<ISingleResponse<Employee>> GetEmployeeAsync(Employee entity);

        Task<IResponse> UpdateEmployeeAsync(Employee changes);
    }
}