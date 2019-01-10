using DotNetCore.Objects;
using DotNetCoreArchitecture.Database;
using DotNetCoreArchitecture.Model.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetCoreArchitecture.Domain
{
    public sealed class UserDomain : IUserDomain
    {
        public UserDomain(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        private IUserRepository UserRepository { get; }

        public Task<PagedList<UserModel>> ListAsync(PagedListParameters parameters)
        {
            return UserRepository.ListAsync<UserModel>(parameters);
        }

        public Task<IEnumerable<UserModel>> ListAsync()
        {
            return UserRepository.ListAsync<UserModel>();
        }

        public Task<UserModel> SelectAsync(long userId)
        {
            return UserRepository.SelectAsync<UserModel>(userId);
        }
    }
}
