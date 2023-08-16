using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCStartApp.Models.Db.Repository;
using System.Threading.Tasks;

namespace MVCStartApp.Controllers
{
    public class UsersController : Controller
    {
        // ссылка на репозиторий
        private readonly IBlogRepository _repo;
        private readonly ILogger<HomeController> _logger;

        public UsersController(ILogger<HomeController> logger, IBlogRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            var authors = await _repo.GetUsers();
            return View(authors);
        }
    }
}
