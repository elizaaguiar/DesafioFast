using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFullstack.DTOs
{
    public class LoginDTO
    {
        public Guid Guid { get; set; }
        public string Name { get; set; } = default!;
        public string Password { get; set; } = default!;
    }
}