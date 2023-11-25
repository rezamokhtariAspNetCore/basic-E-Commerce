using BG.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BG.Data.DATA
{
	public class APDBCONX : IdentityDbContext
	{
		public APDBCONX(DbContextOptions<APDBCONX> options) : base(options)
		{

		}
		public DbSet<Category> Category { get; set; }
		public DbSet<GameType> GameType { get; set; }
		public DbSet<MenuItem> MenuItem { get; set; }
		public DbSet<ApplicationUser> ApplicationUser { get; set; }
		public DbSet<ShoppingCart> ShoppingCart { get; set; }
		public DbSet<OrderHeader> OrderHeader { get; set; }
		public DbSet<OrderDetails> OrderDetails { get; set; }

	}
}
