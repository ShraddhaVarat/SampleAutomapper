using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAutomapper.DTO
{
    public partial class EmployeeDTO
    {
        public virtual long Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string ReportsTo { get; set; }
    }
}
