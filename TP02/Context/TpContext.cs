using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using TP02.Models.Entity;

// João Vitor Pedral do Nascimento CB3022391
// Rodrigo Braga Guimarães Brito CB3018105

namespace TP02.Context;

public class TpContext : DbContext
{
    public TpContext(DbContextOptions<TpContext> options) : base(options)
    {
    }
    public DbSet<Container> Containers { get; set; }
    public DbSet<BillOfLading> BillOfLadings { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Container>().HasKey(m => m.Id);
        builder.Entity<Container>()
            .HasOne(c => c.Bill) 
            .WithMany(b => b.Containers) 
            .HasForeignKey(c => c.BillId);

        builder.Entity<BillOfLading>().HasKey(m => m.Id);

        base.OnModelCreating(builder);
    }
}
