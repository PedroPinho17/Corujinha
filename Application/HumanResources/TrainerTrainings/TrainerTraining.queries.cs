using AnotherDotnetToolkit.MediatR.Queries;
using CorujinhaAPI.Domain.Entities;

namespace Application.HumanResources.TrainerTrainings
{
    public class GetAllTrainerTrainingsQuery : GetAllQuery<TrainerTraining>, IGetAllQuery<IReadOnlyList<TrainerTraining>?>
    {
        public GetAllTrainerTrainingsQuery()
        {
            IncludeParameters = ["Trainer", "Training"];
        }
    }
    
    public class GetTrainerTrainingByIdQuery : GetByIdQuery<TrainerTraining>, IGetByIdQuery<TrainerTraining?>
    {
        public GetTrainerTrainingByIdQuery()
        {
            IncludeParameters = ["Trainer", "Training"];
        }
    }
}
