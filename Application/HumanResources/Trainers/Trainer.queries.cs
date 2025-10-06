using AnotherDotnetToolkit.MediatR.Queries;
using CorujinhaAPI.Domain.Entities;

namespace Application.HumanResources.Trainers
{
    public class GetAllTrainersQuery : GetAllQuery<Trainer>, IGetAllQuery<IReadOnlyList<Trainer>?>
    {
        public GetAllTrainersQuery()
        {
            IncludeParameters = ["Person"];
        }
    }
    
    public class GetTrainerByIdQuery : GetByIdQuery<Trainer>, IGetByIdQuery<Trainer?>
    {
        public GetTrainerByIdQuery()
        {
            IncludeParameters = ["Person"];
        }
    }
}
