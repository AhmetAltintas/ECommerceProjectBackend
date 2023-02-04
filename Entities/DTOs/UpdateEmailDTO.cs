using Core.Entities.Abstract;

namespace Entities.DTOs
{
    public class UpdateEmailDTO : IDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
    }
}
