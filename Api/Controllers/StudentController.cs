using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Application.Services.Students;
using Domain;
using Domain.Entities;
using Domain.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Api.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class StudentController : BaseController
    {
        private readonly ILogger<StudentController> _logger;
        private readonly IStudentService _studentService;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public StudentController(ILogger<StudentController> logger, IStudentService studentService, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _studentService = studentService;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _logger = logger;

        }

        [HttpGet("GetStudents")]
        public async Task<GenericResponse<List<Student>>> GetStudents([FromQuery] PaginationFilter filter)
        {
            var response = await _studentService.GetStudents(filter, Request.Path.Value);
            response.Version = GetVersion();
            return response;
        }
        
        [Authorize(AuthenticationSchemes = "Bearer", Roles = "admin")]
        [HttpGet("GetStudentById/{id}")]
        public async Task<GenericResponse<Student>> GetStudentById(string id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                IEnumerable<Claim> claims = identity.Claims;
                // or
                // identity.FindFirst("ClaimName").Value;

            }
            var response = await _studentService.GetStudentsById(id);
            response.Version = GetVersion();
            return response;
        }

        [HttpPost("Create")]
        public GenericResponse<Student> Create(Student student)
        {
            var response = _studentService.Create(student);
            response.Version = GetVersion();
            return response;
        }

    }
}