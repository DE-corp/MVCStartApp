using Microsoft.AspNetCore.Http;
using MVCStartApp.Models.Db;
using MVCStartApp.Models.Db.Repository;
using System;
using System.Threading.Tasks;

namespace MVCStartApp.Middlewares
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        /// <summary>
        ///  Middleware-компонент должен иметь конструктор, принимающий RequestDelegate
        /// </summary>
        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        /// <summary>
        ///  Необходимо реализовать метод Invoke  или InvokeAsync
        /// </summary>
        public async Task InvokeAsync(HttpContext context, IRequestRepository req)
        {
            var request = new RequestItem()
            {
                Url = $"New request to http://{context.Request.Host.Value + context.Request.Path}"
            };

            await req.addRequest(request);
            // Для логирования данных о запросе используем свойста объекта HttpContext
            Console.WriteLine($"[{DateTime.Now}]: New request to http://{context.Request.Host.Value + context.Request.Path}");

            // Передача запроса далее по конвейеру
            await _next.Invoke(context);
        }
    }
}
