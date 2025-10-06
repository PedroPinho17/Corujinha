using AnotherDotnetToolkit.MediatR.Queries;
using CorujinhaAPI.Domain.Entities;

namespace Application.HumanResources.Competences
{
    public class GetAllCompetencesQuery : GetAllQuery<Competence>, IGetAllQuery<IReadOnlyList<Competence>?>
    {
        public GetAllCompetencesQuery()
        {
            IncludeParameters = ["CompetenceCategory"];
        }
    }

    public class GetCompetenceByIdQuery : GetByIdQuery<Competence>, IGetByIdQuery<Competence?>
    {
        public GetCompetenceByIdQuery()
        {
            IncludeParameters = ["CompetenceCategory"];
        }
    }

}
