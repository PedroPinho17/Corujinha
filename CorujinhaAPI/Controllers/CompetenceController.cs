using AnotherDotnetToolkit.AspNetCoreExtensions;
using Application.HumanResources.Competences;
using CorujinhaAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetenceController : RestController<Competence, CompetenceCreateCommand, CompetenceUpdateCommand, CompetenceDeleteCommand, GetAllCompetencesQuery, GetCompetenceByIdQuery>
    {
        public CompetenceController(ISender sender) : base(sender)
        { 
        }
    }
}
