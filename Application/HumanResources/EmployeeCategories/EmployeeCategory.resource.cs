

namespace Application.HumanResources.EmployeeCategories
{
    public class EmployeeCategoryResource
    {
        public string Name { get; set; }
        public string? Description { get; set; }
    }

    public class EmployeeCategoryQuery
    {

    }

    public class EmplyeeCategoryQuerySingleById : EmployeeCategoryQuery
    {
        public int Id { get; set; }
    }
}
