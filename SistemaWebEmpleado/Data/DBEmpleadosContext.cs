using Microsoft.EntityFrameworkCore;
using SistemaWebEmpleado.Models;

namespace SistemaWebEmpleado.Data
{
    public class DBEmpleadosContext: DbContext
    {

        public DBEmpleadosContext(DbContextOptions<DBEmpleadosContext> options):base(options) { }


        public DbSet<Empleado> Empleados { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>().HasData(
                new Empleado
                {
                    EmpleadoId = 1,
                    Nombre = "Rubén",
                    Apellido = "Lopez",
                    DNI = "39380965",
                    Legajo = "EC23456",
                    Titulo = "Comercio"
                },
                new Empleado
                {
                    EmpleadoId = 2,
                    Nombre = "Maria",
                    Apellido = "Zarate",
                    DNI = "39017487",
                    Legajo = "EC45637",
                    Titulo = "Contaduria"
                });
        }

    }
}
