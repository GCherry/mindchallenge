using challenge.Models;
using System;

namespace challenge.Services
{
    public interface IEmployeeService
    {
        Employee GetById(string id);
        Employee Create(Employee employee);
        Employee Replace(Employee originalEmployee, Employee newEmployee);
        ReportingStructure GetReportingStructure(string employeeId);
    }
}
