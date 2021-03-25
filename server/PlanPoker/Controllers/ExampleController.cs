using Microsoft.AspNetCore.Mvc;
using PlanPoker.Services;

namespace PlanPoker.Controllers
{
  /// <summary>
  /// Контроллер.
  /// </summary>
  [ApiController]
  [Route("api/[controller]")]
  public class ExampleController : ControllerBase
  {
    private readonly ExampleService exampleService;
    
    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="exampleService">Сервис.</param>
    public ExampleController(ExampleService exampleService)
    {
      this.exampleService = exampleService;
    }

    /// <summary>
    /// Тестовый метод.
    /// </summary>
    /// <param name="id">Отправленное число.</param>
    /// <returns>Возвращенное число.</returns>
    [HttpGet("test/{id}")]
    public int Test(int id)
    {
      return this.exampleService.TestMethod(id);
    }
  }
}
