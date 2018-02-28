using System.Threading;
using System.Threading.Tasks;

namespace Template.Core.Interfaces
{
    public interface IRestService
    {
        Task<string> Get(string url, string content, CancellationToken cancellationToken);
        Task<string> Post(string url, CancellationToken cancellationToken);
    }
}