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
  [Route("api/[controller]/[action]")]
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
    public Room AddUser(Guid userId, Guid roomId)
    {
        return this.roomService.AddUser(userId, roomId);
    }

    [HttpGet]
    public Room RemoveUser(Guid userId, Guid roomId)
    {
        return this.roomService.RemoveUser(userId, roomId);
    }

    [HttpGet]
    public Room ChangeOwner(Guid userId, Guid roomId)
    {
        return this.roomService.ChangeOwner(userId, roomId);
    }
  }
}
