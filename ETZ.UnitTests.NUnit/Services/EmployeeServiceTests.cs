using ETZ.Models;
using ETZ.Repository;
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

        private readonly Mock<IRepo<Employee>> Mock_EmployeeRepo;
        private readonly Mock<IRepo<Position>> Mock_PositionRepo;
        private readonly List<Employee> employees;
        private readonly List<Position> positions;
        
        [SetUp]
        public void Setup()
        {
            Mock_EmployeeRepo.Setup(x => x.GetAll()).Returns(employees.AsQueryable());
            Mock_PositionRepo.Setup(x => x.GetAll()).Returns(positions.AsQueryable());
        }

        [Test]
        public void GetEmployeeListing_Successfull()
        {

        }
    }
}
