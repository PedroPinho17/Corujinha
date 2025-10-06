using AnotherDotnetToolkit.MediatR.Commands;
using CorujinhaAPI.Domain.Entities;

namespace Application.HumanResources.Competences
{
    public class CompetenceCreateCommand : CreateCommand<Competence>, ICreateCommand<Competence>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
    }
    
    public class CompetenceUpdateCommand : CompetenceCreateCommand, IUpdateCommand<Competence>
    {
        // Inherits properties from CompetenceCreateCommand
    }

    public class CompetenceDeleteCommand : CompetenceCreateCommand, IDeleteCommand<Competence>
    {
        // Inherits properties from CompetenceCreateCommand
    }
}
