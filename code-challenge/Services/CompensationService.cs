using challenge.Models;
using challenge.Repositories;
using System;

namespace challenge.Services
{
    public class CompensationService : ICompensationService
    {
        private readonly ICompensationRepository _compensationRepository;

        public CompensationService(ICompensationRepository compensationRepository)
        {
            _compensationRepository = compensationRepository;
        }
        public Compensation Create(Compensation compensation)
        {
            if (compensation != null)
            {
                _compensationRepository.Add(compensation);
                _compensationRepository.SaveAsync();
            }

            return compensation;
        }

        public Compensation GetByEmployeeId(string employeeId)
        {
            if (!String.IsNullOrEmpty(employeeId))
            {
                return _compensationRepository.GetByEmployeeId(employeeId);
            }

            return null;
        }
    }
}
