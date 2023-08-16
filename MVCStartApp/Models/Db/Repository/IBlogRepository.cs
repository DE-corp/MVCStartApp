using System.Threading.Tasks;

namespace MVCStartApp.Models.Db.Repository
{
    public interface IBlogRepository
    {
        Task AddUser(User user);
    }
}
