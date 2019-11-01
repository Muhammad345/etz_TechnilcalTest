using System;
using System.Collections.Generic;
using System.Linq;
using ETZ.Models;
using ETZ.Repository;
using ETZ.ViewModel;

namespace ETZ.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepo<Employee> EmployeeRepo;
        private readonly IRepo<Position> PositionRepo;
        private const int NumberDaysInYear = 365;

        public EmployeeService(IRepo<Employee> employeeRepo, IRepo<Position> positionRepo)
        {
            EmployeeRepo = employeeRepo;
            PositionRepo = positionRepo;
        }

        public IEnumerable<Employee_Listing> GetEmployee_Listing()
        {
            var employeeList = from e in EmployeeRepo.GetAll()
                               join p in PositionRepo.GetAll() on e.Position_Id equals p.Id
                               select new Employee_Listing
                               {
                                   Id = e.Id,
                                   Name = e.Name,
                                   DateOfBirth = e.DateOfBirth,
                                   Location = e.Location,
                                   Position = p.Description,
                                   Sex = e.Sex.ToString(),
                                   Age = GetAge(e.DateOfBirth)
                               };

            return employeeList;
        }

        private static string GetAge(DateTime dateOfBirth)
        {
            var todayDate = DateTime.UtcNow;
            var timeSpan = todayDate.Date.Subtract(dateOfBirth);
            var years = Math.Round((timeSpan.TotalDays / NumberDaysInYear),0).ToString();

           return $"{years} Year"; 
        }
    }
}
