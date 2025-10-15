using AnotherDotnetToolkit.AspNetCoreExtensions;
using Application.HumanResources.Employees;
using Application.HumanResources.TrainerCompetences;
using CorujinhaAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainerCompetenceController : RestController<TrainerCompetence, TrainerCompetenceCreateCommand, TrainerCompetenceUpdateCommand, TrainerCompetenceDeleteCommand, GetAllTrainerCompetencesQuery, GetTrainerCompetenceByIdQuery>
    {
        public TrainerCompetenceController(ISender sender) : base(sender)
        { 
        }
    }
}
