using System;
using Microsoft.EntityFrameworkCore;
using TestProject.Models;

namespace TestProject.DataAccessLayer.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

		public DbSet<Category> categories { get; set; }
	}
}

