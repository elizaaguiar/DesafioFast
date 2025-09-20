
using System.ComponentModel.DataAnnotations;

namespace DesafioFullstack.Entity
{
    public class Base
    {
        public int Id { get; set; }
        public Guid Guid { get; set; } = Guid.NewGuid();
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? RemovedAt { get; set; }
    }
}