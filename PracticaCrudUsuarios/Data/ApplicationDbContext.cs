
using Microsoft.EntityFrameworkCore;
using PracticaCrudUsuarios.Models;

namespace PracticaCrudUsuarios.Data{
	public class ApplicationDbContext :DbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>  options) : base(options){
            
        }
        public DbSet<User> User { get; set; }
    }
}
