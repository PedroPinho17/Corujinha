using AnotherDotnetToolkit.MediatR.Commands;
using CorujinhaAPI.Domain.Entities;

namespace Application.HumanResources.TrainerTrainings
{
    public class TrainerTrainingCreateCommand : CreateCommand<TrainerTraining>, ICreateCommand<TrainerTraining>
    {
        public int TrainerId { get; set; }
        public int TrainingId { get; set; }
        public DateTime AssignedDate { get; set; }
    }

    public class TrainerTrainingUpdateCommand : TrainerTrainingCreateCommand, IUpdateCommand<TrainerTraining>
    {
        // Inherits properties from TrainerTrainingCreateCommand
    }

    public class TrainerTrainingDeleteCommand : TrainerTrainingCreateCommand, IDeleteCommand<TrainerTraining>
    {
        // Inherits properties from TrainerTrainingCreateCommand
    }


}
