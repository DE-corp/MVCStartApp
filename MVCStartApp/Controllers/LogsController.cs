using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCStartApp.Models.Db.Repository;
using System.Threading.Tasks;

namespace MVCStartApp.Controllers
{
    public class LogsController : Controller
    {
        // ссылка на репозиторий
        private readonly IRequestRepository _repo;
        private readonly ILogger<HomeController> _logger;

        public LogsController(ILogger<HomeController> logger, IRequestRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            var logs = await _repo.GetLogs();
            return View(logs);
        }
    }
}
