namespace DesafioFullstack.Request
{
    public class CreateCollaboratorRequest
    {
        public string Name { get; set; } = default!;
        public string Password { get; set; } = default!;
    }
}