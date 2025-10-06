using AnotherDotnetToolkit.MediatR.Commands;
using CorujinhaAPI.Domain.Entities;

namespace Application.HumanResources.Trainings
{
    public class TrainingCreateCommand : CreateCommand<Training>, ICreateCommand<Training>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Duration { get; set; }
        public string Location { get; set; }
    }
    public class TrainingUpdateCommand : TrainingCreateCommand, IUpdateCommand<Training>
    {
        // Inherits properties from TrainingCreateCommand
    }

    public class TrainingDeleteCommand : TrainingCreateCommand, IDeleteCommand<Training>
    {
        // Inherits properties from TrainingCreateCommand
    }

}
