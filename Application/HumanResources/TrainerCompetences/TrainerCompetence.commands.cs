using AnotherDotnetToolkit.MediatR.Commands;
using CorujinhaAPI.Domain.Entities;

namespace Application.HumanResources.TrainerCompetences
{
    public class TrainerCompetenceCreateCommand: CreateCommand<TrainerCompetence>, ICreateCommand<TrainerCompetence>
    {
        public int TrainerId { get; set; }
        public int CompetenceId { get; set; }
    }

    public class TrainerCompetenceUpdateCommand : TrainerCompetenceCreateCommand, IUpdateCommand<TrainerCompetence>
    {
        // Inherits properties from TrainerCompetenceCreateCommand
    }

    public class TrainerCompetenceDeleteCommand : TrainerCompetenceCreateCommand, IDeleteCommand<TrainerCompetence>
    {
        // Inherits properties from TrainerCompetenceCreateCommand
    }

}
