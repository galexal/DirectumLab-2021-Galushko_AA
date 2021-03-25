using DataService.Models;

namespace PlanPoker.Services
{
    /// <summary>
    /// Сервисы участника.
    /// </summary>
    public class UserServices
    {
        /// <summary>
        /// Состояние участника.
        /// </summary>
        public User CurrentUser { get; set; }

        /// <summary>
        /// Создать учачтника.
        /// </summary>
        /// <param name="name">Имя участника.</param>
        public void Create(string name)
        {
            this.CurrentUser = new User(name);
        }

        /// <summary>
        /// Изменить имя.
        /// </summary>
        /// <param name="newName">Новое имя.</param>
        public void ChangeName(string newName)
        {
            this.CurrentUser.Name = newName;
        }
    }
}
