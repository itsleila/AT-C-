using InfnetMVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InfnetMVC.DAL
{
    public class InfnetDbContext : IdentityDbContext<IdentityUser>
    {
        public InfnetDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
            //modelBuilder.Entity<Funcionario>()
                //.HasOne(f => f.Departamento)
                //.WithMany(d => d.Funcionarios)
                //.HasForeignKey(f => f.DepartamentoId);
        //}
    }
}
