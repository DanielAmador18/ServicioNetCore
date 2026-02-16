using System.Globalization;

namespace TaskManagerAPI.Entities
{
    public class UsersEntity
    {
        public int Id { get; set; }
        public string Rol { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
    }
}
