using AnotherDotnetToolkit.MediatR.Commands;
using CorujinhaAPI.Domain.Entities;

namespace Application.HumanResources.Trainers
{

    public class TrainerCreateCommand : CreateCommand<Trainer>, ICreateCommand<Trainer>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
    }
    public class TrainerUpdateCommand : TrainerCreateCommand, IUpdateCommand<Trainer>
    {
        // Inherits properties from TrainerCreateCommand
    }
    public class TrainerDeleteCommand : TrainerCreateCommand, IDeleteCommand<Trainer>
    {
        // Inherits properties from TrainerCreateCommand
    }
}
