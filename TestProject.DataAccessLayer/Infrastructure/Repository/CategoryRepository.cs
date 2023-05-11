using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject.DataAccessLayer.Data;
using TestProject.DataAccessLayer.Infrastructure.IRepository;
using TestProject.Models;

namespace TestProject.DataAccessLayer.Infrastructure.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            _db.categories.Update(category);
        }
    }
}