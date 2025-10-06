using AnotherDotnetToolkit.AspNetCoreExtensions;
using AnotherDotnetToolkit.MediatR.Commands;
using AnotherDotnetToolkit.MediatR.Commands.handlers;
using AnotherDotnetToolkit.MediatR.Queries;
using AnotherDotnetToolkit.MediatR.Queries.handlers;
using Application.HumanResources.Competences;
using Application.HumanResources.Employees;
using Application.HumanResources.EmployeeCompetences;
using Application.HumanResources.TrainerCompetences;
using Application.HumanResources.Trainers;
using Application.HumanResources.TrainerTrainings;
using Application.HumanResources.Trainings;
using CorujinhaAPI.Domain.Entities;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application.HumanResourcesDomainModule
{
    public static class HumanResourcesDomainModule
    {
        /// <summary>  
        /// Registers the library's services.  
        /// </summary>  
        /// <param name="services">The service collection.</param>  
        /// <returns>The updated service collection.</returns>  
        public static IServiceCollection RegisterHumanResourcesServices(this IServiceCollection services)
        {
            services.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssembly(typeof(HumanResourcesDomainModule).Assembly);
            });

            AddEntityHandlers<Employee, EmployeeCreateCommand, EmployeeUpdateCommand, EmployeeDeleteCommand, GetAllEmployeesQuery, GetEmployeeByIdQuery>(services);
            AddEntityHandlers<Competence, CompetenceCreateCommand, CompetenceUpdateCommand, CompetenceDeleteCommand, GetAllCompetencesQuery, GetCompetenceByIdQuery>(services);
            AddEntityHandlers<EmployeeCompetence, EmployeeCompetenceCreateCommand, EmployeeCompetenceUpdateCommand, EmployeeCompetenceDeleteCommand, GetAllEmployeeCompetencesQuery, GetEmployeeCompetenceByIdQuery>(services);
            AddEntityHandlers<TrainerCompetence, TrainerCompetenceCreateCommand, TrainerCompetenceUpdateCommand, TrainerCompetenceDeleteCommand, GetAllTrainerCompetencesQuery, GetTrainerCompetenceByIdQuery>(services);
            AddEntityHandlers<Trainer, TrainerCreateCommand, TrainerUpdateCommand, TrainerDeleteCommand, GetAllTrainersQuery, GetTrainerByIdQuery>(services);
            AddEntityHandlers<TrainerTraining, TrainerTrainingCreateCommand, TrainerTrainingUpdateCommand, TrainerTrainingDeleteCommand, GetAllTrainerTrainingsQuery, GetTrainerTrainingByIdQuery>(services);
            AddEntityHandlers<Training, TrainingCreateCommand, TrainingUpdateCommand, TrainingDeleteCommand, GetAllTrainingsQuery, GetTrainingByIdQuery>(services);

            return services;
        }

        /// <summary>
        /// Registers entity handlers for commands and queries.
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TCreateCommand"></typeparam>
        /// <typeparam name="TUpdateCommand"></typeparam>
        /// <typeparam name="TDeleteCommand"></typeparam>
        /// <typeparam name="TGetAllQuery"></typeparam>
        /// <typeparam name="TGetByIdQuery"></typeparam>
        /// <param name="services"></param>
        /// <returns>The updated service collection.</returns> 
        private static IServiceCollection AddEntityHandlers<TEntity, TCreateCommand, TUpdateCommand, TDeleteCommand, TGetAllQuery, TGetByIdQuery>(
            this IServiceCollection services)
            where TEntity : class, IEntity, new()
            where TCreateCommand : ICreateCommand<TEntity>
            where TUpdateCommand : IUpdateCommand<TEntity>
            where TDeleteCommand : IDeleteCommand<TEntity>
            where TGetAllQuery : IGetAllQuery<IReadOnlyList<TEntity>?>
            where TGetByIdQuery : IGetByIdQuery<TEntity?>
        {
            services.AddScoped<IRequestHandler<TCreateCommand, TEntity>, CreateCommandHandler<TCreateCommand, TEntity>>();
            services.AddScoped<IRequestHandler<TUpdateCommand, TEntity?>, UpdateCommandHandler<TUpdateCommand, TEntity>>();
            services.AddScoped<IRequestHandler<TDeleteCommand, TEntity?>, DeleteCommandHandler<TDeleteCommand, TEntity>>();
            services.AddScoped<IRequestHandler<TGetAllQuery, IReadOnlyList<TEntity>?>, GetAllQueryHandler<TGetAllQuery, TEntity>>();
            services.AddScoped<IRequestHandler<TGetByIdQuery, TEntity?>, GetByIdQueryHandler<TGetByIdQuery, TEntity>>();
            return services;
        }
    }
}
