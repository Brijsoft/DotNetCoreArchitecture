using DotNetCore.Objects;
using DotNetCoreArchitecture.Model.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetCoreArchitecture.Domain
{
    public interface IUserDomain
    {
        Task<PagedList<UserModel>> ListAsync(PagedListParameters parameters);

        Task<IEnumerable<UserModel>> ListAsync();

        Task<UserModel> SelectAsync(long userId);
    }
}
