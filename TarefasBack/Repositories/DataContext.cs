using Microsoft.EntityFrameworkCore;
using TarefasBack.Models;

namespace TarefasBack.Repositories
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base (options) {}

        public DbSet<Tarefa> Tarefas {get;set;}
        public DbSet<Usuario> Usuarios {get;set;}

        
    }

}