using AnotherDotnetToolkit.MediatR.Queries;
using CorujinhaAPI.Domain.Entities;

namespace Application.HumanResources.Trainings
{
    public class GetAllTrainingsQuery : GetAllQuery<Training>, IGetAllQuery<IReadOnlyList<Training>?>
    {
        public GetAllTrainingsQuery()
        {
            IncludeParameters = ["TrainingCategory"];
        }
    }
    public class GetTrainingByIdQuery : GetByIdQuery<Training>, IGetByIdQuery<Training?>
    {
        public GetTrainingByIdQuery()
        {
            IncludeParameters = ["TrainingCategory"];
        }
    }
}
