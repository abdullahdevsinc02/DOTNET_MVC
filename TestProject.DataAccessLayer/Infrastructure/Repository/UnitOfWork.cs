using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject.DataAccessLayer.Data;
using TestProject.DataAccessLayer.Infrastructure.IRepository;

namespace TestProject.DataAccessLayer.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICategoryRepository Category {get;private set;}
        private ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(db);
        }
        public void Save()
        {
           _db.SaveChanges();
        }
    }
}