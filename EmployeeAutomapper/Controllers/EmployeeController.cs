using AutoMapper;
using EmployeeAutomapper.DTO;
using EmployeeAutomapper.Model;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAutomapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMapper _mapper;

        public EmployeeController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPatch]
        public IActionResult Patch([FromBody] Delta<EmployeeDTO> entityDelta)
        {
            var existingModel = new EmployeeModel
            {
                Id = 123,
                FullName = "XYZ",
                Type = Shared.EmployeeType.Manager,
                ReportsTo = null
            };

            var existingEntity = _mapper.Map<EmployeeDTO>(existingModel);
            entityDelta.Patch(existingEntity);

            // Following mapping incorrectly sets type of updatedModel as EmployeeType.Employee
            var updatedModel = _mapper.Map(existingEntity, existingModel);
            return Ok(updatedModel);
        }
    }
}
