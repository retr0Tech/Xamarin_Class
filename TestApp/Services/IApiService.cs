using System;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.Services
{
    public interface IApiService
    {
        Task<Users> GetRate();
    }
}
