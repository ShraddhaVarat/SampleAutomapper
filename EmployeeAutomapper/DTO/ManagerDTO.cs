using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAutomapper.DTO
{
    public class ManagerDTO: EmployeeDTO
    {
        public override string ReportsTo
        {
            get => null;
            set => throw new InvalidOperationException("ReportsTo can not be set to other than the preset value.");
        }
    }
}
