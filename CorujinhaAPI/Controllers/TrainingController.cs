using AnotherDotnetToolkit.AspNetCoreExtensions;
using Application.HumanResources.Employees;
using Application.HumanResources.Trainings;
using CorujinhaAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : RestController<Training, TrainingCreateCommand, TrainingUpdateCommand, TrainingDeleteCommand, GetAllTrainingsQuery, GetTrainingByIdQuery>
    {
        public TrainingController(ISender sender) : base(sender)
        { 
        }
    }
}
