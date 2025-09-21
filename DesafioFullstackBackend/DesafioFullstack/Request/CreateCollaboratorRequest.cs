namespace DesafioFullstack.Request
{
    public class CreateCollaboratorRequest
    {
        public string Name { get; set; } = default!;
        public string PasswordHash { get; set; } = default!;
    }
}