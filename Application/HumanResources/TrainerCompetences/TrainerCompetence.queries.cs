using AnotherDotnetToolkit.MediatR.Queries;
using CorujinhaAPI.Domain.Entities;

namespace Application.HumanResources.TrainerCompetences
{
    public class GetAllTrainerCompetencesQuery : GetAllQuery<TrainerCompetence>, IGetAllQuery<IReadOnlyList<TrainerCompetence>?>
    {
        public GetAllTrainerCompetencesQuery()
        {
            IncludeParameters = ["Trainer","Competence"];
        }
    }
    
    public class GetTrainerCompetenceByIdQuery : GetByIdQuery<TrainerCompetence>, IGetByIdQuery<TrainerCompetence?>
    {
        public GetTrainerCompetenceByIdQuery()
        {
            IncludeParameters = ["Trainer","Competence"];
        }
    }
}
