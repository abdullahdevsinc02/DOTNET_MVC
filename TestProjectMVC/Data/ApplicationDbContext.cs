using System;
using Microsoft.EntityFrameworkCore;
using TestProjectMVC.Models;

namespace TestProjectMVC.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

		public DbSet<Category> categories { get; set; }
	}
}

