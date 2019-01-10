using DotNetCore.AspNetCore;
using DotNetCoreArchitecture.Application;
using DotNetCoreArchitecture.Model.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetCoreArchitecture.Web
{
    [ApiController]
    [RouteController]
    public class UsersController : ControllerBase
    {
        public UsersController(IUserApplication userApplication)
        {
            UserApplication = userApplication;
        }

        private IUserApplication UserApplication { get; }

        [HttpGet]
        public Task<IEnumerable<UserModel>> GetAsync()
        {
            return UserApplication.ListAsync();
        }

        [HttpGet("{id}")]
        public Task<UserModel> GetAsync(long id)
        {
            return UserApplication.SelectAsync(id);
        }
    }
}
