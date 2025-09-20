using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFullstack.DTOs
{
    public class WorkshopDTO
    {
        public Guid Guid { get; set; }
        public string Name { get; set; } = default!;
        public DateTime ExecutionDate { get; set; }
        public string Description { get; set; } = default!;
    }
}