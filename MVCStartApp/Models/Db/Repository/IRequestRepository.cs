using System.Threading.Tasks;

namespace MVCStartApp.Models.Db.Repository
{
    public interface IRequestRepository
    {
        Task addRequest(RequestItem request);
        Task<RequestItem[]> GetLogs();
    }
}
