namespace DesafioFullstack.Request
{
    public class UpdateWorkshopRequest
    {
        public string Name { get; set; } = default!;
        public Guid Guid { get; set; }
        public string Description { get; set; } = default!;
    }
}