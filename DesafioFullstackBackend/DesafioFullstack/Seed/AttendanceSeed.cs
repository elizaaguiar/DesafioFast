using DesafioFullstack.Entity;
using Microsoft.EntityFrameworkCore;

namespace DesafioFullstack.Seed
{
    public class AttendanceSeed
    {
        public static void AttendanceSeedBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendance>()
                .HasKey(a => new { a.WorkshopId, a.CollaboratorId });
            modelBuilder.Entity<Attendance>().HasData(
                new Attendance { WorkshopId = 1, CollaboratorId = 1 },
                new Attendance { WorkshopId = 1, CollaboratorId = 2 },
                new Attendance { WorkshopId = 1, CollaboratorId = 3 },
                new Attendance { WorkshopId = 1, CollaboratorId = 4 },

                new Attendance { WorkshopId = 2, CollaboratorId = 1 },
                new Attendance { WorkshopId = 2, CollaboratorId = 2 },
                new Attendance { WorkshopId = 2, CollaboratorId = 3 },
                new Attendance { WorkshopId = 2, CollaboratorId = 4 },

                new Attendance { WorkshopId = 3, CollaboratorId = 1 },
                new Attendance { WorkshopId = 3, CollaboratorId = 2 },
                new Attendance { WorkshopId = 3, CollaboratorId = 3 },
                new Attendance { WorkshopId = 3, CollaboratorId = 4 },

                new Attendance { WorkshopId = 4, CollaboratorId = 1 },
                new Attendance { WorkshopId = 4, CollaboratorId = 2 },
                new Attendance { WorkshopId = 4, CollaboratorId = 3 },
                new Attendance { WorkshopId = 4, CollaboratorId = 4 }
            );
        }
    }
}