using AnotherDotnetToolkit.AspNetCoreExtensions;
using Application.HumanResources.Employees;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using CorujinhaAPI.Domain.entities;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : RestController<Employee, EmployeeCreateCommand, EmployeeUpdateCommand, EmployeeDeleteCommand, GetAllEmployeesQuery, GetEmployeeByIdQuery>
    {
        public EmployeeController(ISender sender) : base(sender)
        { 
        }
    }
}
