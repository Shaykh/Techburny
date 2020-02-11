using System.Threading.Tasks;
using TechburnyStore.Core.Business.Responses;
using TechburnyStore.Core.Domain.Warehouse;

namespace TechburnyStore.Core.Business.Contracts
{
    public interface IWarehouseService : IService
    {
        Task<IPagedResponse<Product>> GetProductsAsync(int? pageSize, int? pageNumber, int? productCategoryID = null);

        Task<IPagedResponse<Location>> GetWarehousesAsync(int pageSize = 10, int pageNumber = 1);

        Task<IListResponse<ProductInventory>> GetProductInventories(int? productID = null, string warehouseID = null);

        Task<ISingleResponse<Product>> CreateProductAsync(Product entity);

        Task<ISingleResponse<Product>> UpdateProductUnitPriceAsync(int? productID, decimal? unitPrice);
    }
}