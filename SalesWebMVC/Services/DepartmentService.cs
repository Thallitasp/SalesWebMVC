using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Models;

namespace SalesWebMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMVCContext Context;

        public DepartmentService(SalesWebMVCContext context)
        {
            Context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await Context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}