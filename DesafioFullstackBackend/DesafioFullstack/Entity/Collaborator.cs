
using System.ComponentModel.DataAnnotations;


namespace DesafioFullstack.Entity
{
    public class Collaborator : Base
    {
        [Required]
        public string Name { get; set; } = default!;

         public string PasswordHash { get; set; } = default!;
    };
}
