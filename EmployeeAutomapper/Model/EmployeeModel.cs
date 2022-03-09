using EmployeeAutomapper.Shared;

namespace EmployeeAutomapper.Model
{
    public class EmployeeModel
    {
        public long Id { get; set; }

        public string FullName { get; set; }

        public EmployeeType Type { get; set; }

        public string ReportsTo { get; set; }
    }
}
