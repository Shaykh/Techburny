using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TechburnyStore.Core.Business.Contracts;
using TechburnyStore.Core.Business.Responses;
using TechburnyStore.Core.Domain;
using TechburnyStore.Core.Domain.HumanResources;
using TechburnyStore.Core.Domain.Repositories;

namespace TechburnyStore.Core.Business
{
    public class HumanResourcesService : Service, IHumanResourcesService
    {
        public HumanResourcesService(ILogger<HumanResourcesService> logger, TechburnyStoreDbContext dbContext, IUserInfo userInfo)
            : base(logger, dbContext, userInfo)
        {
        }

        public async Task<IListResponse<Employee>> GetEmployeesAsync(int pageSize = 0, int pageNumber = 0)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetEmployeesAsync));

            var response = new ListResponse<Employee>();

            try
            {
                response.Model = await DbContext.Employees.Paging(pageSize, pageNumber).ToListAsync();
            }
            catch (Exception ex)
            {
                response.SetError(Logger, nameof(GetEmployeesAsync), ex);
            }

            return response;
        }

        public async Task<ISingleResponse<Employee>> GetEmployeeAsync(Employee entity)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetEmployeeAsync));

            var response = new SingleResponse<Employee>();

            try
            {
                response.Model = await DbContext.GetEmployeeAsync(entity);
            }
            catch (Exception ex)
            {
                response.SetError(Logger, nameof(GetEmployeeAsync), ex);
            }

            return response;
        }

        public async Task<IResponse> UpdateEmployeeAsync(Employee changes)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(UpdateEmployeeAsync));

            var response = new Response();

            try
            {
                DbContext.Update(changes);

                await DbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                response.SetError(Logger, nameof(UpdateEmployeeAsync), ex);
            }

            return response;
        }
    }
}