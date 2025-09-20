using System.ComponentModel.DataAnnotations;

namespace DesafioFullstack.Entity
{
    public class Workshop : Base
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = default!;
        public DateTime ExecutionDate { get; set; }
        [MaxLength(400)]
        public string Description { get; set; } = default!;
        // public ICollection<AttendanceList> AttendancesLists { get; set; } = default!;
    }
}
