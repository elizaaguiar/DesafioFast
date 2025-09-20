namespace DesafioFullstack.Request
{
    public class CreateWorkshopRequest
    {
        public string Name { get; set; } = default!;
        public DateTime ExecutionDate { get; set; }
        public string Description { get; set; } = default!;
    }
}