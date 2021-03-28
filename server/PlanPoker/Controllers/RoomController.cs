using DataService.Models;
using Microsoft.AspNetCore.Mvc;
using PlanPoker.Services;
using System;

namespace PlanPoker.Controllers
{
  /// <summary>
  /// Контроллер.
  /// </summary>
  [ApiController]
  [Route("api/[controller]")]
  public class RoomController : ControllerBase
  {
    private readonly RoomServices roomService;
    
    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="roomService">Сервис.</param>
    public RoomController(RoomServices roomService)
    {
      this.roomService = roomService;
    }

    [HttpGet]
    public Room Create(string name, Guid ownerId)
    {
        return this.roomService.Create(name, ownerId);
    }

    [HttpGet]
    public void AddUser(Guid userId)
    {
        throw new NotImplementedException();
    }
  }
}
