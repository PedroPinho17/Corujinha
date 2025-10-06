using Application.HumanResources.Employees;
using Application.HumanResources.Competences;
using Application.HumanResources.EmployeeCompetences;
using Application.HumanResources.TrainerCompetences;
using Application.HumanResources.Trainers;
using Application.HumanResources.TrainerTrainings;
using Application.HumanResources.Trainings;
using AutoMapper;
using CorujinhaAPI.Domain.Entities;

namespace Application.HumanResources
{
    public class HumanResourcesMapperProfile : Profile
    {
        public HumanResourcesMapperProfile()
        {
            CreateMap<EmployeeCreateCommand, Employee>().ReverseMap();
            CreateMap<CompetenceCreateCommand, Competence>().ReverseMap();
            CreateMap<EmployeeCompetenceCreateCommand, EmployeeCompetence>().ReverseMap();
            CreateMap<TrainerCompetenceCreateCommand, TrainerCompetence>().ReverseMap();
            CreateMap<TrainerCreateCommand, Trainer>().ReverseMap();
            CreateMap<TrainerTrainingCreateCommand, TrainerTraining>().ReverseMap();
            CreateMap<TrainingCreateCommand, Training>().ReverseMap();
        }
    }
}
