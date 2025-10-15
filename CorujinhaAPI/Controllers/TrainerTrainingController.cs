using AnotherDotnetToolkit.AspNetCoreExtensions;
using Application.HumanResources.Employees;
using Application.HumanResources.TrainerTrainings;
using CorujinhaAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainerTrainingController : RestController<TrainerTraining, TrainerTrainingCreateCommand, TrainerTrainingUpdateCommand, TrainerTrainingDeleteCommand, GetAllTrainerTrainingsQuery, GetTrainerTrainingByIdQuery>
    {
        public TrainerTrainingController(ISender sender) : base(sender)
        { 
        }
    }
}
