using ETZ.Models;
using ETZ.Repository;
using ETZ.Services;
using ETZ.ViewModel;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETZ.UnitTests.NUnit.Services
{
    public class EmployeeServiceTests
    {
        private EmployeeService SUT;
        private Mock<IRepo<Employee>> Mock_EmployeeRepo;
        private Mock<IRepo<Position>> Mock_PositionRepo;
        private  List<Employee> employees;
        private List<Position> positions;
        private const string AccountExecutive = "Account Executive";

        [SetUp]
        public void Setup()
        {
            Mock_EmployeeRepo = new Mock<IRepo<Employee>>();
            Mock_PositionRepo = new Mock<IRepo<Position>>();

            employees = new List<Employee>() { new Employee 
            { Id = 1,
              Name ="Name",
             DateOfBirth = DateTime.UtcNow.AddYears(-20),
             Location ="London",
             Sex = Common.Geneder.Male,
             Position_Id = 1} };

            positions = new List<Position>()
            { new Position{ 
                Id = 1, 
                Description = AccountExecutive
            }
            };
            
            Mock_EmployeeRepo.Setup(x => x.GetAll()).Returns(employees.AsQueryable());
            Mock_PositionRepo.Setup(x => x.GetAll()).Returns(positions.AsQueryable());

            SUT = new EmployeeService(Mock_EmployeeRepo.Object, Mock_PositionRepo.Object);
        }

        [Test]
        public void GetEmployeeListing_Successfull()
        {
           var employee_Listings= SUT.GetEmployee_Listing();

            Assert.IsInstanceOf(typeof(Employee_Listing), employee_Listings);
            Assert.AreEqual(1, employee_Listings.Count());
            Assert.AreEqual(employee_Listings.FirstOrDefault().Position, AccountExecutive);
            Assert.AreEqual(employee_Listings.FirstOrDefault().Age, "20 Year");
        }
    }
}
