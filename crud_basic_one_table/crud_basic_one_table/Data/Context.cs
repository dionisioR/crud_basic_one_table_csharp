using crud_basic_one_table.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_basic_one_table.Data {
    public class Context:DbContext {
        public Context(DbContextOptions<Context> options):base(options)
        {
            
        }

        // Temos que criar um DbSet para cada Modelo/tabela
        public DbSet<Usuario> Usuario { get; set; }
    }
}
