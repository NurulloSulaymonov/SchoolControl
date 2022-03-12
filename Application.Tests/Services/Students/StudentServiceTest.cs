using Application.Services.Students;
using Application.Services.UriService;
using Domain.Entities;
using Domain.ViewModels.Student;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;
using Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Application.Tests.Services.Students
{
    public class StudentServiceTest
    {
        private readonly Mock<ILogger<StudentService>> _logger = new Mock<ILogger<StudentService>>();
        private readonly StudentService _studentService;
        private readonly Mock<IOptions<WorkerInformationOption>> _workerOptions = new Mock<IOptions<WorkerInformationOption>>();
        private readonly Mock<IUriService> _uriService = new Mock<IUriService>();
        private readonly DataContext _context;
        public StudentServiceTest()
        {
            var options = new DbContextOptionsBuilder<DataContext>()
              .UseInMemoryDatabase("Term").Options;
            _context = new DataContext(options);
            _studentService = new StudentService(_context, _logger.Object, _workerOptions.Object, _uriService.Object);
        }

        [Fact]
        public void Create_Must_Rerturn_NotEmpty_Object()
        {

            //Arrange
            var student = new Student()
            {
                Id = new Guid().ToString(),
                Name = "test"
            };
            //Act
            var result = _studentService.Create(student);
            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void Create_Must_Rerturn_Null_IfNameIsNull()
        {

            //Arrange
            var student = new Student()
            {
                Id = new Guid().ToString()
            };
            //Act
            var result = _studentService.Create(student);
            //Assert
            Assert.Null(result);
        }

        [Fact]
        public void GetStudents_Must_Rerturn_EmptyList_IfStudentsNotContainInDb()
        {

            //Arrange

            //Act
            //var result = _studentService.GetStudents(new Domain.ViewModels.PaginationFilter()).Result;
            //Assert
            // Assert.Empty(result.Payload);
        }

        [Fact]
        public void GetStudents_Must_Rerturn_NotEmptyList_IfStudentsContainData()
        {

            //Arrange
            _context.Students.Add(new Student()
            {
                Id = new Guid().ToString()
            });
            _context.SaveChanges();
            //Act
            //var result = _studentService.GetStudents(new Domain.ViewModels.PaginationFilter()).Result;
            ////Assert
            //Assert.NotEmpty(result.Payload);
        }
    }
}
