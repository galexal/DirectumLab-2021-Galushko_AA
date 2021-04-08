using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PlanPoker.DTO;

namespace PlanPoker
{
    /// <summary>
    /// Фильтр исключений.
    /// </summary>
    internal class ExceptionFilter : IExceptionFilter
    {
        /// <summary>
        /// Обработка исключения.
        /// </summary>
        /// <param name="context">Сведения об исключении.</param>
        public void OnException(ExceptionContext context)
        {
            var dto = new ExceptionDto()
            {
                Message = context.Exception.Message
            };

            context.Result = new JsonResult(dto)
            {
                StatusCode = StatusCodes.Status500InternalServerError
            };

            context.ExceptionHandled = true;
        }
    }
}
