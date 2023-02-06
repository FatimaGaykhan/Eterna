using System;
using Eterna.Models;
using Microsoft.EntityFrameworkCore;

namespace Eterna.DataAccessLayer
{
	public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}

		public DbSet <Pricing> Pricings { get; set; }



	}
}

