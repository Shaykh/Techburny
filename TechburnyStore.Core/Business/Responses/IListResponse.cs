using System.Collections.Generic;

namespace TechburnyStore.Core.Business.Responses
{
    public interface IListResponse<TModel> : IResponse
    {
        IEnumerable<TModel> Model { get; set; }
    }
}