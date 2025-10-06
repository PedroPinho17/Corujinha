using AnotherDotnetToolkit.MediatR.Commands;
using CorujinhaAPI.Domain.Entities;

namespace Application.HumanResources.EmployeeCompetences
{
    public class EmployeeCompetenceCreateCommand: CreateCommand<EmployeeCompetence>, ICreateCommand<EmployeeCompetence>
    {
        public int EmployeeId { get; set; }
        public int CompetenceId { get; set; }
    }
    public class EmployeeCompetenceUpdateCommand : EmployeeCompetenceCreateCommand, IUpdateCommand<EmployeeCompetence>
    {
        // Inherits properties from EmployeeCompetenceCreateCommand
    }

    public class EmployeeCompetenceDeleteCommand : EmployeeCompetenceCreateCommand, IDeleteCommand<EmployeeCompetence>
    {
        // Inherits properties from EmployeeCompetenceCreateCommand
    }

}
