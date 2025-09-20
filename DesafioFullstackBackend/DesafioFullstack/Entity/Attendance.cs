namespace DesafioFullstack.Entity
{
    public class Attendance
    {
        public int CollaboratorId { get; set; }
        public int WorkshopId { get; set; }
        public Collaborator Collaborator { get; set; } = default!;
        public Workshop Workshop { get; set; } = default!;
    }
}