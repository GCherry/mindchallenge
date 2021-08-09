using challenge.Data;
using challenge.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace challenge.Repositories
{
    public class CompensationRepository : ICompensationRepository
    {
        private readonly EmployeeContext _context;

        public CompensationRepository(EmployeeContext context)
        {
            _context = context;
        }
        public Compensation Add(Compensation compensation)
        {
            compensation.CompensationId = Guid.NewGuid().ToString();
            _context.Compensation.Add(compensation);
            return compensation;
        }

        public Compensation GetByEmployeeId(string id)
        {
            return _context.Compensation
                .Where(x => x.Employee.EmployeeId == id)
                .Include(x => x.Employee)
                .OrderByDescending(x => x.EffectiveDate)
                .FirstOrDefault();
        }

        public Task SaveAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
