using Domain;
using Domain.Entities;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Students
{
    public interface IStudentService
    {
        public Task<PagedResponse<List<Student>>> GetStudents(PaginationFilter filter, string route);
        public Task<GenericResponse<Student>> GetStudentsById(string id);
        public GenericResponse<Student> Create(Student students);
        public GenericResponse<Student> Update(Student student);

    }
}
