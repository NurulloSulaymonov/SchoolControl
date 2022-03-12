using System.Net.Http;
using Domain;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.ViewModels.Student;
using Microsoft.Extensions.Options;
using Domain.ViewModels;
using Application.Services.UriService;
using Application.Helpers;

namespace Application.Services.Students
{
    public class StudentService : IStudentService
    {
        private readonly DataContext _context;
        private readonly ILogger<StudentService> _logger;
        private readonly WorkerInformationOption _workerOptions;
        private readonly IUriService _uriService;

        public StudentService(DataContext context, ILogger<StudentService> logger,
            IOptions<WorkerInformationOption> workerOptions, IUriService uriService)
        {
            _uriService = uriService;
            _context = context;
            _logger = logger;
            _workerOptions = workerOptions.Value;
        }
        /// <summary>
        /// Get Students
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        public async Task<PagedResponse<List<Student>>> GetStudents(PaginationFilter filter, string route)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);

            var pagedData = _context.Students.Skip((validFilter.PageNumber - 1) * validFilter.PageSize).Take(validFilter.PageSize).ToList();
            var totalRecords = await _context.Students.CountAsync();
            return PaginationHelper.CreatePagedReponse<Student>(System.Net.HttpStatusCode.OK, pagedData, validFilter, totalRecords, _uriService, route);
        }

        public async Task<GenericResponse<Student>> GetStudentsById(string id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null) return new GenericResponse<Student>(System.Net.HttpStatusCode.NotFound, "student NOt found");
            return new GenericResponse<Student>(System.Net.HttpStatusCode.OK, student);
        }

        /// <summary>
        /// Create a new student
        /// </summary>
        /// <param name="student">student model</param>
        /// <returns>return created student</returns>
        public GenericResponse<Student> Create(Domain.Entities.Student student)
        {
            try
            {
                int rand = new Random().Next(1, 100);
                _context.Add(new Section() { Id = rand, Name = "test" });
                _context.SaveChanges();
                if (student.Name == null) return new GenericResponse<Student>(System.Net.HttpStatusCode.BadRequest, "Student name Must not be empty");
                student.CreatedAt = DateTime.Now;
                student.Id = Guid.NewGuid().ToString();
                student.SectionId = rand;
                _context.Students.Add(student);
                _context.SaveChanges();
                return new GenericResponse<Student>(System.Net.HttpStatusCode.OK, student);
            }
            catch (System.Exception ex)
            {
                return new GenericResponse<Student>(System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Update Student 
        /// </summary>
        /// <param name="student">Updated Student model</param>
        /// <returns>Updated student</returns>
        public GenericResponse<Student> Update(Student student)
        {
            try
            {
                var editStudent = _context.Students.Find(student.Id);
                if (editStudent != null)
                {
                    editStudent.DateOfBirth = student.DateOfBirth;
                    editStudent.FathersName = student.FathersName;
                    editStudent.Gender = student.Gender;
                    editStudent.Language = student.Language;
                    editStudent.MothersName = student.MothersName;
                    editStudent.Nationality = student.Nationality;
                    editStudent.Name = student.Name;
                    editStudent.PlaceOfBirth = student.PlaceOfBirth;
                    editStudent.SectionId = student.SectionId;
                    editStudent.Surname = student.Surname;
                    editStudent.PassportNumber = student.PassportNumber;
                    _context.SaveChanges();
                    return new GenericResponse<Student>(System.Net.HttpStatusCode.OK, editStudent);
                }
                else
                {
                    return new GenericResponse<Student>(System.Net.HttpStatusCode.NotFound);
                }
            }
            catch (Exception ex)
            {
                return new GenericResponse<Student>(System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        public void Payment(){

            var model = new Student(){};

// var httclin = new HttpClient();
            // var getingo = httpclietn.get("api",model);
            // if(getinfo succsess)
                 
        }

    }
}
