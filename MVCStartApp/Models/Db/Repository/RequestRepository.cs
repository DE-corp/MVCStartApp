using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace MVCStartApp.Models.Db.Repository
{
    public class RequestRepository : IRequestRepository
    {
        public BlogContext _context;
        public RequestRepository(BlogContext context)
        {
            _context = context;
        }

        public async Task addRequest(RequestItem request)
        {
            request.Date = DateTime.Now;
            request.Id = Guid.NewGuid();

            var entry = _context.Entry(request);
            if (entry.State == EntityState.Detached)
                await _context.requestPosts.AddAsync(request);

            // Сохранение изенений
            await _context.SaveChangesAsync();
        }

        public async Task<RequestItem[]> GetLogs()
        {
            // Получаем все логи
            return await _context.requestPosts.ToArrayAsync();
        }
    }
}
