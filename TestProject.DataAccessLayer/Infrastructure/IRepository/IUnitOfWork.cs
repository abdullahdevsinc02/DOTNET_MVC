using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.DataAccessLayer.Infrastructure.IRepository
{
    public interface IUnitOfWork 
    {
        ICategoryRepository Category { get; }

        void Save();
    }
}