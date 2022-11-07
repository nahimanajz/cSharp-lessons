using seeSharpMVC.Models;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore;
namespace seeSharpMVC.Data;

public class ApplicationDBContext: DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options){

    }
    public DbSet<Category> Categories { get; set; } //creating category table

    protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder){
      optionsBuilder.UseMySQL("server=localhost;database=Bulky;user=user;password=");
    }
    protected override void OnModelCreating(ModalBuilder md){
        base.OnModelCreating(md);
        md.Entity<Category>(entity=> {
            entity.HasKey(e => e.ID);
            entity.Property(e => e.Name).IsRequired();

        });
    }
    
}
