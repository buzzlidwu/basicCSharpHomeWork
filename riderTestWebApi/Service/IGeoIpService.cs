using System.Threading.Tasks;

namespace riderTestWebApi.Service
{
    public interface IGeoIpService
    {
        Task<string> GetCurrentIpAsync();
    }
}