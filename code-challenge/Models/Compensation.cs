using System;

namespace challenge.Models
{
    public class Compensation
    {
        public string CompensationId { get; set; }
        public decimal Salary { get; set; }
        public DateTime EffectiveDate { get; set; }
        public Employee Employee { get; set; }

        // Add navigation property to employee
    }
}
