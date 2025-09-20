using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioFullstack.Entity;
using Microsoft.EntityFrameworkCore;

namespace DesafioFullstack.Seed
{
    public class CollaboratorSeed
    {
        public static void CollaboratorSeedBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Collaborator>().HasData(
                new Collaborator
                {
                    Id = 1,
                    Guid = Guid.Parse("d3f1a2b4-5c6d-7e8f-9012-3456789abfde"),
                    CreatedAt = DateTime.Parse("20/09/2025"),
                    Name = "Colaborador 1"
                },
                new Collaborator
                {
                    Id = 2,
                    Guid = Guid.Parse("d3f1a2b4-5c6d-7e8f-9012-3456789abfd1"),
                    CreatedAt = DateTime.Parse("21/09/2025"),
                    Name = "Colaborador 2"
                },
                new Collaborator
                {
                    Id = 3,
                    Guid = Guid.Parse("d3f1a2b4-5c6d-7e8f-9012-3456789abfd2"),
                    CreatedAt = DateTime.Parse("22/09/2025"),
                    Name = "Colaborador 3"
                },
                new Collaborator
                {
                    Id = 4,
                    Guid = Guid.Parse("d3f1a2b4-5c6d-7e8f-9012-3456789abfd3"),
                    CreatedAt = DateTime.Parse("23/09/2025"),
                    Name = "Colaborador 4"
                }
            );
        }
    }
}


