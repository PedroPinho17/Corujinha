using AnotherDotnetToolkit.AspNetCoreExtensions;
using Application.HumanResources.Employees;
using Application.HumanResources.Trainers;
using CorujinhaAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainerController : RestController<Trainer, TrainerCreateCommand, TrainerUpdateCommand, TrainerDeleteCommand, GetAllTrainersQuery, GetTrainerByIdQuery>
    {
        public TrainerController(ISender sender) : base(sender)
        { 
        }
    }
}
