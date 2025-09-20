using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioFullstack.Entity;
using Microsoft.EntityFrameworkCore;

namespace DesafioFullstack.Seed
{
    public class WorshopSeed
    {
        public static void WorshopSeedBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Workshop>().HasData(
               new Workshop
               {
                   Id = 1,
                   Guid = Guid.Parse("d3f1a2b4-5c6d-7e8f-9012-3456789abcde"),
                   CreatedAt = DateTime.Parse("17/09/2025"),
                   Name = "Workshop 1",
                   ExecutionDate = DateTime.Parse("23/09/2025"),
                   Description = "Participe deste workshop prático e intensivo sobre tecnologia e aprenda com o especialista a dominar as técnicas e ferramentas essenciais para aplicar o conhecimento imediatamente."
               },
               new Workshop
               {
                   Id = 2,
                   Guid = Guid.Parse("d3f1a2b4-5c6d-7e8f-9012-3456789abcf1"),
                   CreatedAt = DateTime.Parse("18/09/2025"),
                   Name = "Workshop de Inteligência Artificial",
                   ExecutionDate = DateTime.Parse("30/09/2025"),
                   Description = "Descubra o potencial da IA. Neste evento, vamos explorar algoritmos de machine learning e criar um modelo preditivo do zero, sem necessidade de conhecimento prévio."
               },
                new Workshop
                {
                Id = 3,
                Guid = Guid.Parse("d3f1a2b4-5c6d-7e8f-9012-3456789abcf2"),
                CreatedAt = DateTime.Parse("19/09/2025"),
                Name = "APIs RESTful com .NET",
                ExecutionDate = DateTime.Parse("05/10/2025"),
                Description = "Aprenda a construir APIs robustas e escaláveis. Abordaremos desde os conceitos fundamentais de REST até a implementação de segurança com JWT e documentação com Swagger."
                },
                new Workshop
                {
                Id = 4,
                Guid = Guid.Parse("d3f1a2b4-5c6d-7e8f-9012-3456789abcf3"),
                CreatedAt = DateTime.Parse("20/09/2025"),
                Name = "Design de Interfaces Modernas",
                ExecutionDate = DateTime.Parse("12/10/2025"),
                Description = "Focado em UI/UX, este workshop ensina a criar interfaces intuitivas e atraentes. Você aprenderá sobre prototipação, sistemas de design e testes de usabilidade."
                }

           );
        }
    }
}