using AnotherDotnetToolkit.AspNetCoreExtensions;
using Application.HumanResources.EmployeeCategories;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monolitic_CQRS_Template.Domain.entities;

namespace Monolitic_CQRS_Template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeCategoryController : RestController<EmployeeCategory, EmployeeCategoryCreateCommand, EmployeeCategoryUpdateCommand, EmployeeCategoryDeleteCommand, GetAllEmployeeCategoriesQuery, GetEmployeeCategoryByIdQuery>
    {
        public EmployeeCategoryController(ISender sender) : base(sender)
        {
        }
    }
}
