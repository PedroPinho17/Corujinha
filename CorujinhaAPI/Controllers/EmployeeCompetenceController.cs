using AnotherDotnetToolkit.AspNetCoreExtensions;
using Application.HumanResources.EmployeeCompetences;
using Application.HumanResources.Employees;
using CorujinhaAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeCompetenceController : RestController<EmployeeCompetence, EmployeeCompetenceCreateCommand, EmployeeCompetenceUpdateCommand, EmployeeCompetenceDeleteCommand, GetAllEmployeeCompetencesQuery, GetEmployeeCompetenceByIdQuery>
    {
        public EmployeeCompetenceController(ISender sender) : base(sender)
        { 
        }
    }
}
