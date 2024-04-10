using pruebapostman.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace pruebapostman.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
    }
}

