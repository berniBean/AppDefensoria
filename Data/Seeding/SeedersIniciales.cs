using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Seeding
{
    public static class SeedersIniciales
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var oficina = new Oficina { Idoficina = "9d58cb76-53b7-11ed-b965-a4bb6dda82fc", Nombre = "COATEPEC", Abreviatura = "COA" };
            var cargo = new Cargo { Idcargo = "3e53adf4-53b8-11ed-b965-a4bb6dda82fc", Puesto = "Defensor publico" };
            var persona = new Persona { IdPersona = "100014414521958400", Apaterno = "CUEVAS", Amaterno = "RAMIREZ", Nombre = "EDNA DONAJI" };
            var funcionario = new Funcionario
            {
                IdFuncionario = "5df131f7-4bc1-11ed-975f-f4ee08b6e8c4",
                PersonaIdPersona = "100014414521958400",
                OficinaIdoficina = "9d58cb76-53b7-11ed-b965-a4bb6dda82fc",
                CargoIdcargo = "3e53adf4-53b8-11ed-b965-a4bb6dda82fc"
            };

            modelBuilder.Entity<Oficina>().HasData(oficina);
            modelBuilder.Entity<Cargo>().HasData(cargo);
            modelBuilder.Entity<Persona>().HasData(persona);
            modelBuilder.Entity<Funcionario>().HasData(funcionario);
        }
    }
}
