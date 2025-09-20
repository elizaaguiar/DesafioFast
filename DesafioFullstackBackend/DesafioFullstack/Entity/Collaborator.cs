
using System.ComponentModel.DataAnnotations;


namespace DesafioFullstack.Entity
{
    public class Collaborator : Base
    {
        public string Name { get; set; } = default!; 

        // public ICollection<AttendanceList> AttendancesLists { get; set; } = default!;
    };

}
