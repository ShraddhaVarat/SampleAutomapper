using AutoMapper;
using EmployeeAutomapper.DTO;
using EmployeeAutomapper.Model;
using EmployeeAutomapper.Shared;

namespace EmployeeAutomapper.AutomapperProfiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeDTO, EmployeeModel>()
                .ForMember(empmodel => empmodel.FullName, empdto => empdto.MapFrom(empdto => empdto.Name))
                .ForMember(empmodel => empmodel.Type, empdto => empdto.MapFrom(empdto => EmployeeType.Employee));

            CreateMap<ManagerDTO, EmployeeModel>()
               .ForMember(model => model.FullName, dto => dto.MapFrom(dto => dto.Name))
               .ForMember(model => model.Type, dto => dto.MapFrom(dto => EmployeeType.Manager));

            CreateMap<EmployeeModel, ManagerDTO>()
               .ForMember(dto => dto.Name, model => model.MapFrom(model => model.FullName))
               .ForMember(t => t.ReportsTo, t => t.Ignore());

            CreateMap<EmployeeModel, EmployeeDTO>()
                .ForMember(dto => dto.Name, model => model.MapFrom(model => model.FullName));
        }
    }
}
