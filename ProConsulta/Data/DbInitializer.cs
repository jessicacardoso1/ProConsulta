using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProConsulta.Models;

namespace ProConsulta.Data
{
    public class DbInitializer
    {
        private readonly ModelBuilder _modelBuilder;
        public DbInitializer(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }
        internal void seed()
        {
            _modelBuilder.Entity<IdentityRole>().HasData
                (
                    new IdentityRole
                    {
                        Id = "48fa3c28-61f8-4e61-9f48-fb18b0f0f277",
                        Name = "Atendente",
                        NormalizedName = "ATENDENTE"
                    },
                    new IdentityRole
                    {
                        Id = "400d58cd-f2ad-4093-a559-0afe90c6936e",
                        Name = "Medico",
                        NormalizedName = "MEDICO"
                    }
                );
            var hasher = new PasswordHasher<IdentityUser>();
            _modelBuilder.Entity<Atendente>().HasData
            (
                new Atendente
                {
                    Id = "0c13b544-d2be-4a73-9660-c26aedf15285",
                    Nome = "Pro Consulta",
                    Email = "proconsulta@hotmail.com.br",
                    EmailConfirmed = true,
                    UserName = "proconsulta@hotmail.com.br",
                    NormalizedEmail = "PROCONSULTA@HOTMAIL.COM.BR",
                    NormalizedUserName = "PROCONSULTA@HOTMAIL.COM.BR",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd")
                }
            );

            _modelBuilder.Entity<IdentityUserRole<string>>().HasData
            (
                new IdentityUserRole<string>
                {
                    RoleId = "48fa3c28-61f8-4e61-9f48-fb18b0f0f277",
                    UserId = "0c13b544-d2be-4a73-9660-c26aedf15285"
                }
            );

            _modelBuilder.Entity<Especialidade>().HasData
            (
                new Especialidade { Id = 1, Nome = "Cardiologia", Descricao = "Especialidade médica que trata doenças do coração." },
                new Especialidade { Id = 2, Nome = "Pediatria", Descricao = "Especialidade dedicada ao cuidado da saúde infantil." },
                new Especialidade { Id = 3, Nome = "Dermatologia", Descricao = "Ramo da medicina que trata doenças da pele, cabelos e unhas." },
                new Especialidade { Id = 4, Nome = "Neurologia", Descricao = "Especialidade que cuida do sistema nervoso central e periférico." },
                new Especialidade { Id = 5, Nome = "Ortopedia", Descricao = "Focada no tratamento de doenças e lesões do sistema musculoesquelético." },
                new Especialidade { Id = 6, Nome = "Oftalmologia", Descricao = "Área médica dedicada ao diagnóstico e tratamento de doenças dos olhos." },
                new Especialidade { Id = 7, Nome = "Gastroenterologia", Descricao = "Especialidade que trata do sistema digestivo e seus transtornos." },
                new Especialidade { Id = 8, Nome = "Psiquiatria", Descricao = "Ramo da medicina que lida com o diagnóstico e tratamento de transtornos mentais." },
                new Especialidade { Id = 9, Nome = "Endocrinologia", Descricao = "Estudo e tratamento de doenças hormonais e metabólicas." },
                new Especialidade { Id = 10, Nome = "Oncologia", Descricao = "Especialidade médica que trata do diagnóstico e tratamento do câncer." },
                new Especialidade { Id = 11, Nome = "Urologia", Descricao = "Área responsável por cuidar do sistema urinário e do sistema reprodutor masculino." }
            );

        }
    }
}
