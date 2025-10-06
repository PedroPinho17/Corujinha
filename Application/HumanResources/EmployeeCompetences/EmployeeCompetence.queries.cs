using AnotherDotnetToolkit.MediatR.Queries;
using CorujinhaAPI.Domain.Entities;

namespace Application.HumanResources.EmployeeCompetences
{
    public class GetAllEmployeeCompetencesQuery : GetAllQuery<EmployeeCompetence>, IGetAllQuery<IReadOnlyList<EmployeeCompetence>?>
    {
        public GetAllEmployeeCompetencesQuery()
        {
            IncludeParameters = ["Employee", "Competence"];
        }
    }

    public class GetEmployeeCompetenceByIdQuery : GetByIdQuery<EmployeeCompetence>, IGetByIdQuery<EmployeeCompetence?>
    {
        public GetEmployeeCompetenceByIdQuery()
        {
            IncludeParameters = ["Employee", "Competence"];
        }
    }

}
